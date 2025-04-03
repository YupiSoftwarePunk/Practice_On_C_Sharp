using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewPractice_3._04_
{
    
    public class Person
    {
        [JsonProperty("full_name")]
        public string Name { get; set; }

        [JsonIgnore]
        public int Id { get; set; }   

        public int Age { get; set; }


        public string Adress { get; set; }  
    }
}
