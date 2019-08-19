using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace TestWebApiXml.Models
{
    [XmlRoot("Inquiry", Namespace = "http://www.reifen.net/",IsNullable = false)]
    public class Inquiry
    {
        [XmlElement(Namespace = "")]
        public string DocumentID { get; set; }
        [XmlElement(Namespace ="")]
        public BuyInfo BuyInfo { get; set; }
    }
}