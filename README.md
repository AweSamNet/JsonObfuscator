AweSamNet.JsonObfuscator
==============

Makes use of JSON.Net custom Contract Resolver to serialize/deserialize objects to/from obfuscated JSON.

## License
See license details [here](/LICENSE.md).

## Usage

```c#
    //serialize an object to obfuscated JSON
    string text = JsonConvert.SerializeObject(myObject, new JsonSerializerSettings { ContractResolver =  new ObfuscationContractResolver()});

	//deserialize obfuscated to proper object
    ObfuscationTest deserialized = JsonConvert.DeserializeObject<ObfuscationTest>(modifiedText, new JsonSerializerSettings { ContractResolver = new ObfuscationContractResolver()});
```

## NuGet

https://www.nuget.org/packages/AweSamNet.JsonObfuscator
