using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace TestWebApiXml.Models
{
    [XmlRoot("Inquiry", Namespace = "http://www.w3.org/TR/html4/", IsNullable = false)]
    public class Inquiry
    {
        public string DocumentID { get; set; }
        [XmlElement(Namespace ="")]
        public BuyInfo BuyInfo { get; set; }
    }
}