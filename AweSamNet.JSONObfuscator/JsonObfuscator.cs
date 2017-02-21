
using AweSamNet.JsonObfuscator.Serialization;
using Newtonsoft.Json;

namespace AweSamNet.JsonObfuscator
{
    public static class JsonObfuscator
    {
        /// <summary>
        /// Serializes an object into an obfuscated json string
        /// </summary>
        public static string Obfuscate(object obj)
        {
            return JsonConvert.SerializeObject(obj,
                new JsonSerializerSettings {ContractResolver = new ObfuscationContractResolver()});
        }

        /// <summary>
        /// Deserializes an obfuscated json string into the passed generic type.
        /// </summary>
        public static T Deobfuscate<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json,
                new JsonSerializerSettings {ContractResolver = new ObfuscationContractResolver()});
        }

        /// <summary>
        /// Serializes an object into an obfuscated json string
        /// </summary>
        public static string JsonObfuscate(this object obj)
        {
            return Obfuscate(obj);
        }

        /// <summary>
        /// Deserializes an obfuscated json string into the passed generic type.
        /// </summary>
        public static T JsonDeobfuscate<T>(this string json)
        {
            return Deobfuscate<T>(json);
        }
    }
}
