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
> **Note**: If you need to change the encoding, you must use MemoryStream, if for example you use StringBuilder, the encoding will not applied to the final xml.
