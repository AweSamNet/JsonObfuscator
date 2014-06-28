AweSamNet.JsonObfuscator
==============

This library makes use of JSON.Net custom Contract Resolver to serialize/deserialize objects to/from obfuscated JSON.

## Usage

```c#
    //serialize an object to obfuscated JSON
    string text = JsonConvert.SerializeObject(myObject, new JsonSerializerSettings { ContractResolver =  new ObfuscationContractResolver()});

	//deserialize obfuscated to proper object
    ObfuscationTest deserialized = JsonConvert.DeserializeObject<ObfuscationTest>(modifiedText, new JsonSerializerSettings { ContractResolver = new ObfuscationContractResolver()});
```
