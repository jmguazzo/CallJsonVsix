using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Resources;
using System.Xml.Linq;

namespace CallJson
{
    class FavoriteManager
    {
        static object lockObject = new object();
        string xmlFilename;
        const string XML_FAVORITE_FILENAME = "favorite.xml";

        private bool saving;
        private FileSystemWatcher fileWatcher;
        private string folderForXmlFile;

        public TreeView TreeView { get; private set; }
        public Control Owner { get; private set; }

        public FavoriteManager(Control owner, TreeView trv)
        {
            this.Owner = owner;
            this.TreeView = trv;
            GenerateFileNameWithAppData();

            CreateFileIfNotExists();

            CreateFileWatcher();
        }

        private void GenerateFileNameWithAppData()
        {
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            folderForXmlFile = Path.Combine(appDataFolder, "CallJsonVsix");

            if (!Directory.Exists(folderForXmlFile))
                Directory.CreateDirectory(folderForXmlFile);

            xmlFilename = Path.Combine(folderForXmlFile, XML_FAVORITE_FILENAME);
        }

        internal void FillTreeView()
        {
            //Because this can be called from the FileSystemWatcher, it must be invoked by the control that owns the treeview
            Owner.Invoke(new MethodInvoker(delegate ()
            {
                TreeView.Nodes.Clear();
                TreeView.BeginUpdate();


                using (var stream = File.OpenRead(xmlFilename))
                {
                    XDocument doc = XDocument.Load(stream, LoadOptions.None);
                    var firstLevel = doc.Elements("favorites").Elements("favorite");
                    AddNodeAndChild(TreeView.Nodes, firstLevel);
                }



                TreeView.EndUpdate();
            }));

        }

        private void CreateFileWatcher()
        {

            lock (lockObject)
            {
                if (fileWatcher != null)
                {
                    fileWatcher.Dispose();
                }

                fileWatcher = new FileSystemWatcher(folderForXmlFile, "*.xml");
                fileWatcher.Changed += FileWatcher_Changed;
                fileWatcher.EnableRaisingEvents = true;
            }
        }

        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (this.saving)
                return;

            if (e.FullPath == xmlFilename && e.ChangeType == WatcherChangeTypes.Changed)
            {
                FillTreeView();
            }
        }





        private void AddNodeAndChild(TreeNodeCollection nodes, IEnumerable<XElement> elementList)
        {
            foreach (XElement element in elementList)
            {
                Favorite favorite = new Favorite(element);
                var node = CreateNode(favorite);

                nodes.Add(node);

                AddNodeAndChild(node.Nodes, element.Elements());
            }
        }

        internal TreeNode CreateNode(Favorite favorite)
        {
            TreeNode node = new TreeNode(favorite.Name);
            node.ImageIndex = favorite.IsFolder ? 0 : 1;
            node.SelectedImageIndex = node.ImageIndex;
            node.Tag = favorite;
            node.ToolTipText = favorite.Url;
            return node;
        }



        private void CreateFileIfNotExists()
        {

            if (!File.Exists(xmlFilename) && !CopyFileFromIsolatedStorage())
            {
                System.IO.File.WriteAllText(xmlFilename, @"<?xml version=""1.0"" encoding=""utf-8"" ?><favorites/> ");
            }

        }

        private bool CopyFileFromIsolatedStorage()
        {
            //For user of the former version, if the file doesn't exists in the new location but is in the isolatedstorage, 
            //we copy it

            var fileCopied = false;
            
            using (var storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {
                if (storage.FileExists(XML_FAVORITE_FILENAME))
                {
                    using (var stream = new IsolatedStorageFileStream(XML_FAVORITE_FILENAME, FileMode.Open, storage))
                    {
                        using (var targetStream = File.OpenWrite(xmlFilename))
                        {
                            stream.CopyTo(targetStream);
                            fileCopied = true;
                        }
                    }
                }
            }
            return fileCopied;
        }

        internal void SaveTreeView()
        {
            saving = true;

            using (var stream = File.OpenWrite(xmlFilename))
            {

                var elementParent = new XElement("favorites");
                XDocument doc = new XDocument(elementParent);

                GenerateNodeAndChild(elementParent, TreeView.Nodes);

                doc.Save(stream);

                stream.Close();
            }

            saving = false;
        }

        private void GenerateNodeAndChild(XElement elementParent, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                elementParent.Add(GenerateNodeAndChildRecursive(node));
            }
        }

        private XElement GenerateNodeAndChildRecursive(TreeNode node)
        {
            var favorite = node.Tag as Favorite;
            var element = favorite.AsXElement();
            foreach (TreeNode subNode in node.Nodes)
            {
                element.Add(GenerateNodeAndChildRecursive(subNode));
            }
            return element;
        }


    }
}
