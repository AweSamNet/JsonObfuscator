using System;
using NUnit.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AweSamNet.JsonObfuscator.Serialization;

namespace AweSamNet.JsonObfuscator.Tests
{
    [TestFixture]
    public class JsonObfuscatorTest
    {
        private class ObfuscationTest
        {
            public ObfuscationTest()
            {
                #region Set Values
                StringProperty1 = "Should be StringProperty1";
                AnIntProperty2 = 2;
                StringProperty3 = "Should be StringProperty3";
                ADoubleProperty4 = 4.4;
                ComplexProperty5 = new ComplexObjectTest();
                StringProperty6 = "Should be StringProperty6";
                StringProperty7 = "Should be StringProperty7";
                StringProperty8 = "Should be StringProperty8";
                StringProperty9 = "Should be StringProperty9";
                StringProperty10 = "Should be StringProperty10";
                StringProperty11 = "Should be StringProperty11";
                StringProperty12 = "Should be StringProperty12";
                StringProperty13 = "Should be StringProperty13";
                StringProperty14 = "Should be StringProperty14";
                StringProperty15 = "Should be StringProperty15";
                StringProperty16 = "Should be StringProperty16";
                StringProperty17 = "Should be StringProperty17";
                StringProperty18 = "Should be StringProperty18";
                StringProperty19 = "Should be StringProperty19";
                StringProperty20 = "Should be StringProperty20";
                StringProperty21 = "Should be StringProperty21";
                StringProperty22 = "Should be StringProperty22";
                StringProperty23 = "Should be StringProperty23";
                StringProperty24 = "Should be StringProperty24";
                StringProperty25 = "Should be StringProperty25";
                StringProperty26 = "Should be StringProperty26";
                StringProperty27 = "Should be StringProperty27";
                StringProperty28 = "Should be StringProperty28";
                StringProperty29 = "Should be StringProperty29";
                StringProperty30 = "Should be StringProperty30";
                StringProperty31 = "Should be StringProperty31";
                StringProperty32 = "Should be StringProperty32";
                StringProperty33 = "Should be StringProperty33";
                StringProperty34 = "Should be StringProperty34";
                StringProperty35 = "Should be StringProperty35";
                StringProperty36 = "Should be StringProperty36";
                StringProperty37 = "Should be StringProperty37";
                StringProperty38 = "Should be StringProperty38";
                StringProperty39 = "Should be StringProperty39";
                StringProperty40 = "Should be StringProperty40";
                StringProperty41 = "Should be StringProperty41";
                StringProperty42 = "Should be StringProperty42";
                StringProperty43 = "Should be StringProperty43";
                StringProperty44 = "Should be StringProperty44";
                StringProperty45 = "Should be StringProperty45";
                StringProperty46 = "Should be StringProperty46";
                StringProperty47 = "Should be StringProperty47";
                StringProperty48 = "Should be StringProperty48";
                StringProperty49 = "Should be StringProperty49";
                StringProperty50 = "Should be StringProperty50";
                StringProperty51 = "Should be StringProperty51";
                StringProperty52 = "Should be StringProperty52";
                StringProperty53 = "Should be StringProperty53";
                #endregion Set Values
            }

            #region properties
            public string StringProperty1 { get; set; }
            public int AnIntProperty2 { get; set; }
            public string StringProperty3 { get; set; }
            public double ADoubleProperty4 { get; set; }
            public ComplexObjectTest ComplexProperty5 { get; set; }
            public string StringProperty6 { get; set; }
            public string StringProperty7 { get; set; }
            public string StringProperty8 { get; set; }
            public string StringProperty9 { get; set; }
            public string StringProperty10 { get; set; }
            public string StringProperty11 { get; set; }
            public string StringProperty12 { get; set; }
            public string StringProperty13 { get; set; }
            public string StringProperty14 { get; set; }
            public string StringProperty15 { get; set; }
            public string StringProperty16 { get; set; }
            public string StringProperty17 { get; set; }
            public string StringProperty18 { get; set; }
            public string StringProperty19 { get; set; }
            public string StringProperty20 { get; set; }
            public string StringProperty21 { get; set; }
            public string StringProperty22 { get; set; }
            public string StringProperty23 { get; set; }
            public string StringProperty24 { get; set; }
            public string StringProperty25 { get; set; }
            public string StringProperty26 { get; set; }
            public string StringProperty27 { get; set; }
            public string StringProperty28 { get; set; }
            public string StringProperty29 { get; set; }
            public string StringProperty30 { get; set; }
            public string StringProperty31 { get; set; }
            public string StringProperty32 { get; set; }
            public string StringProperty33 { get; set; }
            public string StringProperty34 { get; set; }
            public string StringProperty35 { get; set; }
            public string StringProperty36 { get; set; }
            public string StringProperty37 { get; set; }
            public string StringProperty38 { get; set; }
            public string StringProperty39 { get; set; }
            public string StringProperty40 { get; set; }
            public string StringProperty41 { get; set; }
            public string StringProperty42 { get; set; }
            public string StringProperty43 { get; set; }
            public string StringProperty44 { get; set; }
            public string StringProperty45 { get; set; }
            public string StringProperty46 { get; set; }
            public string StringProperty47 { get; set; }
            public string StringProperty48 { get; set; }
            public string StringProperty49 { get; set; }
            public string StringProperty50 { get; set; }
            public string StringProperty51 { get; set; }
            public string StringProperty52 { get; set; }
            public string StringProperty53 { get; set; }
            #endregion properties
        }

        private class ComplexObjectTest
        {
            public string StringProperty1 { get; set; }
            public int AnIntProperty2 { get; set; }
            public string StringProperty3 { get; set; }
            public double ADoubleProperty4 { get; set; }

            public ComplexObjectTest()
            {
                StringProperty1 = "Should be StringProperty1";
                AnIntProperty2 = 2;
                StringProperty3 = "Should be StringProperty3";
                ADoubleProperty4 = 4.4;
            }
        }

        [Test]
        public void SerializeEnableObfuscation()
        {
            string text = JsonConvert.SerializeObject(new ObfuscationTest(), new JsonSerializerSettings { ContractResolver =  new ObfuscationContractResolver()});

            var json = JObject.Parse(text);
            Assert.AreEqual(json["a"].Value<string>(), "Should be StringProperty1");
            Assert.AreEqual(json["b"].Value<int>(), 2);
            Assert.AreEqual(json["d"].Value<double>(), 4.4);
            Assert.AreEqual(json["e"]["a"].Value<string>(), "Should be StringProperty1");
            Assert.AreEqual(json["z"].Value<string>(), "Should be StringProperty26");
            Assert.AreEqual(json["aa"].Value<string>(), "Should be StringProperty27");
            Assert.AreEqual(json["az"].Value<string>(), "Should be StringProperty52");
            Assert.AreEqual(json["ba"].Value<string>(), "Should be StringProperty53");

            json["a"] = "Should be StringProperty1 Modified";
            json["b"] = 3;
            json["d"] = 4.5;
            json["e"]["a"] = "Should be StringProperty1 Modified";
            json["z"] = "Should be StringProperty26 Modified";
            json["aa"] = "Should be StringProperty27 Modified";
            json["az"] = "Should be StringProperty52 Modified";
            json["ba"] = "Should be StringProperty53 Modified";

            var modifiedText = json.ToString();

            ObfuscationTest deserialized = JsonConvert.DeserializeObject<ObfuscationTest>(modifiedText, new JsonSerializerSettings { ContractResolver = ObfuscationContractResolver.Instance});

            Assert.AreEqual(json["a"].Value<string>(), deserialized.StringProperty1);
            Assert.AreEqual(json["b"].Value<int>(), deserialized.AnIntProperty2);
            Assert.AreEqual(json["d"].Value<double>(), deserialized.ADoubleProperty4);
            Assert.AreEqual(json["e"]["a"].Value<string>(), deserialized.ComplexProperty5.StringProperty1);
            Assert.AreEqual(json["z"].Value<string>(), deserialized.StringProperty26);
            Assert.AreEqual(json["aa"].Value<string>(), deserialized.StringProperty27);
            Assert.AreEqual(json["az"].Value<string>(), deserialized.StringProperty52);
            Assert.AreEqual(json["ba"].Value<string>(), deserialized.StringProperty53);
        }
    }
}
