# XmlSerializer-sample
This is a sample showing how to use XMLSerializer to convert an object to serialized XML.
## Creating Serializer
To start using an XMLSerializer object we must create an object with the type of the object that would be serialized as parameter.
```
XmlSerializer serializer = new XmlSerializer(typeof(Inquiry));
```
Here, Inquiery is the object that is going to be serialized.

## Changing encoding
By default, the xml encoding is utf-16, if you want to change it, you must to use:XmlWriterSettings
```
XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    NamespaceHandling = NamespaceHandling.OmitDuplicates
                };
```
> **Note**: If you need to change the encoding, you must use MemoryStream, if for example you use StringBuilder, the encoding will not be applied to the final xml.
## Changing namespaces
By default, XmlSerializer add a namespace to the created xml. If you need to change it, you should use XmlSerializerNamespaces as below:
```
  XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    ns.Add("ew", "http://www.w3.org/TR/html4/");

                    ns.Add("", "");

                    serializer.Serialize(writer, inquiry, ns);
```
>**Note**: You can add as many as namespace you want
## Clearing Namespace
Sometimes, you need to clear an added namespace, to do that you must first add an empty namespace as below:
```
XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                    ns.Add("ew", "http://www.w3.org/TR/html4/");

                    ns.Add("", "");
```
Then you need to add an attribute to the property you want to clear its namespace. On the code below, I want to clear the namespace assigned to BuyInfo:
```
    [XmlRoot("Inquiry", Namespace = "http://www.w3.org/TR/html4/", IsNullable = false)]
    public class Inquiry
    {
        public string DocumentID { get; set; }
        [XmlElement(Namespace ="")]
        public BuyInfo BuyInfo { get; set; }
    }
	
```