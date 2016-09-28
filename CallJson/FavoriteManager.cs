using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Resources;
using System.Xml.Linq;

namespace CallJson
{
    class FavoriteManager
    {
        const string xmlFavoriteFilename = "favorite.xml";

        internal void FillTreeView(System.Windows.Forms.TreeView trv)
        {

            trv.Nodes.Clear();
            trv.BeginUpdate();

            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {

                CreateFileIfNotExists(storage);

                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(xmlFavoriteFilename, FileMode.Open, storage))
                {
                    XDocument doc = XDocument.Load(stream, LoadOptions.None);
                    var firstLevel = doc.Elements("favorites").Elements("favorite");
                    AddNodeAndChild(trv.Nodes, firstLevel);
                }
            }

            trv.EndUpdate();
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



        private void CreateFileIfNotExists(IsolatedStorageFile storage)
        {
            if (!storage.FileExists(xmlFavoriteFilename))
            {
                var stream = storage.CreateFile(xmlFavoriteFilename);
                StreamWriter wri = new StreamWriter(stream);
                wri.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8"" ?><favorites/> ");
                wri.Flush();
                wri.Close();

            }
        }

        internal void SaveTreeView(TreeView trvFavorite)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {


                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(xmlFavoriteFilename, FileMode.Create, storage))
                {

                    var elementParent = new XElement("favorites");
                    XDocument doc = new XDocument(elementParent);
                    GenerateNodeAndChile(elementParent, trvFavorite.Nodes);
                    doc.Save(stream);
                    stream.Close();
                }
            }
        }

        private void GenerateNodeAndChile(XElement elementParent, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                elementParent.Add(GenerateNodeAndChile(node));
            }
        }

        private XElement GenerateNodeAndChile(TreeNode node)
        {
            var favorite = node.Tag as Favorite;
            var element = favorite.AsXElement();
            foreach (TreeNode subNode in node.Nodes)
            {
                element.Add(GenerateNodeAndChile(subNode));
            }
            return element;
        }
    }
}
