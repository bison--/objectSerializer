# object serializer #
Serialize and Deserialize any object to XML and back in **C#** / **Unity3D**

## WAT ##

It takes one object and ALL its (public) properties/getter and setter and dumps it to XML.

## constraints ##

* it ONLY serializes public variables / getter and setter
* the class itself MUST be public
* the class MUST have a conbstructor without parameter (could be overloaded, but it MUST work without any param!)
* no refereces/pointer to other objects or streams
* arrays: OK; generic lists: OK; dictionarys: LOLNOPE

Works with **Unity3D**, because its .net 2.0 and 100% board tools.  
It could not serialize objects inherited from **MonoBehaviour**, but there is a workaround for that (at least GameObjects as prefabs) now and with other "primitive" classes like settings and so on it will work just fine ;)

## TEST ##

### Unity3D ###

There is now a test-project with sample use and GUI and stuff.

### VisualStudio ###

There is an Object within the Testform which will be **serialized**.  
Then you can make changes to it and click **deserialize** and it will be loaded back and a Mesagebox will show its (new) name.  
You can also watch your refreshed object with the Debugger ;)
