using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CallJson
{
    class Favorite
    {
        public Favorite()
        { }
        public Favorite(XElement element)
        {
            Name = element.AttributeAsString("name");
            IsFolder = (element.AttributeAsString("folder") == "true");
            Url = element.AttributeAsString("url");
            if (!IsFolder)
            {
                Body = element.Value;
            }
        }



        public string Url { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
        public bool IsFolder { get; set; }

        internal XElement AsXElement()
        {
            var element = new XElement("favorite");
            element.Add(new XAttribute("name", Name));
            if (IsFolder)
            {
                element.Add(new XAttribute("folder", "true"));
            }
            else
            {
                element.Add(new XAttribute("url", Url));

                if (!string.IsNullOrEmpty(Body))
                {
                    element.Value = Body;
                }

            }
            return element;
        }
    }
}
