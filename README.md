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

SHOULD work with **Unity3D**, because its .net 2.0 and 100% board tools.  
NOT testes yet, i am not ready (yet) to do so.

## TEST ##

Theres an Object within the Testform which will be **serialized**.  
Then you can make changes to it and click *deserialize* and it will be loaded back and a Mesagebox will show its (new) name.  
You can also watch your refreshed object with the Debugger ;)