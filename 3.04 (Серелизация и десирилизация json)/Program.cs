using Newtonsoft.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace NewPractice_3._04_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // partial class - класс, который распределен по разным файлам

            var person = new Person()
            {
                Name = "Test",
                //Adress = "Test st.",
                //Age = 22,
                //Id = 1
            };
            //string json2 = @"{
            //""Name"": ""Test"",
            //""Id"": 1,
            //""Age"": 22,
            //""Adress"": ""Test st.""
            //  }";
            //JsonConvert.PopulateObject(json2, person);
            //Console.WriteLine(person.Age);


            //string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            //Console.WriteLine(json);


            //          string json2 = @"{
            //""Name"": ""Test"",
            //""Id"": 1,
            //""Age"": 22,
            //""Adress"": ""Test st.""
            //  }";
            //          // это нужно бы завернуть в try-catch
            //Person person1 = JsonConvert.DeserializeObject<Person>(json2);
            //Console.WriteLine(person1.Age);


            //string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            //Console.WriteLine(json);
            //File.WriteAllText("person.json", json);


            string json3 = @"{
""Employees"":[
{""Name"": ""Peter"", ""Age"":20},
{""Name"": ""Tom"", ""Age"":18},
{""Name"": ""Garry"", ""Age"":33}
]

}";

            JObject obj = JObject.Parse(json3);
            var names = obj["Employees"].Select(obj => obj["Name"].ToString()).ToList();

            foreach (var i in names)
            {
                Console.WriteLine(i);
            }

            //var acc = new PaymentAccount(100m, 3, 50m, 4);
            //Console.WriteLine(acc.ToString());
            //acc.ToJson("accTrue.json");
            //PaymentAccount.SerializeComputedFields = false;
            //acc.ToJson("accFalse.json");


            var acc = PaymentAccount.FromJson("accTrue.json");
            Console.WriteLine(acc.ToString());
        }
    }
}
