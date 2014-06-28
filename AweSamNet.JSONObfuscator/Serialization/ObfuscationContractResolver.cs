using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace AweSamNet.JsonObfuscator.Serialization
{
    public class ObfuscationContractResolver : DefaultContractResolver
    {
        public new static readonly ObfuscationContractResolver Instance = new ObfuscationContractResolver();
        
        protected override IList<JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, JsonPropertyCollection memberProperties)
        {
            var parameters = base.CreateConstructorParameters(constructor, memberProperties);

            foreach (var jsonProperty in parameters)
            {
                //set obfuscated name
                jsonProperty.PropertyName = GetObfuscatedName(parameters.IndexOf(jsonProperty));
            }
            return parameters;
        }

        protected override IList<JsonProperty> CreateProperties(Type type, Newtonsoft.Json.MemberSerialization memberSerialization)
        {
            var properties = base.CreateProperties(type, memberSerialization);
            foreach (var jsonProperty in properties)
            {
                //set obfuscated name
                jsonProperty.PropertyName = GetObfuscatedName(properties.IndexOf(jsonProperty));
            }

            return properties;
        }

        /// <summary>
        /// Generates an obfuscated name based on the passed index
        /// </summary>
        /// <param name="index">Index to derive name from.  Generally, this will be the position of the property in a class.</param>
        /// <returns>Returns the obfuscated name.</returns>
        static protected string GetObfuscatedName(int index)
        {
            //get the letter of the property position.
            var letterPos = (index) % (26);
            string letter = ((Char)(97 + letterPos)).ToString();

            if (index >= 26) //26 letters in the english alphabet
            {
                //get the next set of letters
                var nextSet = (index / 26) - 1;

                letter = GetObfuscatedName(nextSet) + letter;
            }

            return letter;
        }
    }
}
