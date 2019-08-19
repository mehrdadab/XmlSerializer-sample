using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using TestWebApiXml.Models;

namespace TestWebApiXml.Controllers
{
    public class InquiryController : Controller
    {
        public ActionResult Get(int id)
        {
            string xml = "";

            var inquiry = new Inquiry { DocumentID = "A2", BuyInfo = new BuyInfo { AgencyCode = 100, PartyId = 200 } };

            XmlSerializer serializer = new XmlSerializer(typeof(Inquiry));

            using (var sww = new MemoryStream())
            {

                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    NamespaceHandling = NamespaceHandling.OmitDuplicates
                };

                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    ns.Add("ew", "http://www.w3.org/TR/html4/");

                    ns.Add("", "");

                    serializer.Serialize(writer, inquiry, ns);

                    xml = Encoding.UTF8.GetString(sww.ToArray()); ;
                }
            }
            return Content(xml, "text/xml");
        }
    }
}
