# XmlSerializer-sample
This is a sample showing how to use XMLSerializer to convert an object to serialized XML.
## Creating Serializer
To start using an XMLSerializer object we must create an object with the type of the object that would be serialized as parameter.
```
XmlSerializer serializer = new XmlSerializer(typeof(Inquiry));
```
Here Inquiery is the object that is going to be serialized.
