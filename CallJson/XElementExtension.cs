using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CallJson
{
    static class XElementExtension
    {

        public static string AttributeAsString(this XElement element,string attributeName)
        {
            if (element.Attribute(attributeName) != null)
            {
                return element.Attribute(attributeName).Value;
            }else
            {
                return string.Empty;
            }
        }
    }
}
