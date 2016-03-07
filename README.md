AweSamNet.JsonObfuscator
==============

Makes use of JSON.Net custom Contract Resolver to serialize/deserialize objects to/from obfuscated JSON.

[![donate](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif "PayPal - The safer, easier way to pay online!")](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=NDQ8MLABHKXWN)


## License
See license details [here](/LICENSE.md).

## Usage

```c#
    //serialize an object to obfuscated JSON
    string json = myObject.JsonObfuscate();

	//deserialize obfuscated to proper object
    MyClass deserialized = json.JsonDeobfuscate<MyClass>();
```

## NuGet

https://www.nuget.org/packages/AweSamNet.JsonObfuscator

### To Install
```
    PM> Install-Package AweSamNet.JsonObfuscator
```