
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewPractice_2._04_
{
    // сереализация в xml

    /* [Serializable]
     [XmlRoot("Employee")]   */// переименование корневого элемента
    public class Person
    {
        [JsonProperty("full_name")]
        /*[XmlElement("FullName")]*/
        public string Name { get; set; }   // преобразовавается в элемент с таким названием при сереализации
        [JsonIgnore]
        /*        [XmlAttribute("Id")]
        */
        public int Id { get; set; }   // преобразовавается в атрибут при сереализации

        public int Age { get; set; }

        /*[XmlIgnore]*/
        public string Adress { get; set; }   // игнорирование при сереализации

        // сереализация массива в xml
        //[XmlArray("Array name")]
        //[XmlArrayItem("название элемента массива")]
    }
}