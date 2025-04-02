using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NewPractice_2._04_
{

    // сереализация и десереализация в xml

    internal class Program
    {
        static void Main(string[] args)
        {
            // сереализация

            //var person = new Person
            //{
            //    Id = 1,
            //    Name = "Denis", 
            //    Age = 18, 
            //    Adress = "8 Marta, 3"
            //};
            //XmlSerializer serializer = new XmlSerializer(typeof(Person));

            //// записывание xml в файл
            //using (StreamWriter sw = new StreamWriter("Denis.xml"))
            //{
            //    serializer.Serialize(sw, person);
            //}



            // десереализация

            //XmlSerializer serializer = new XmlSerializer(typeof(Person));
            //using(StreamReader sr = new StreamReader("Denis.xml"))
            //{
            //    try
            //    {
            //        Person person = (Person)serializer.Deserialize(sr);
            //        Console.WriteLine(person.Name);
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}



            // задание значений и создание элементов и аттрибутов в xml файле

            //XDocument doc = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    new XElement("Company",
            //        new XElement("Employee",
            //            new XElement("Name", "John"),
            //            new XAttribute("Id", 1),
            //            new XElement("Age", 22)),

            //        new XElement("Employee",
            //            new XElement("Name", "Anny"),
            //            new XAttribute("Id", 2),
            //            new XElement("Age", 20))
            //        )
            //    );

            //doc.Save("Company.xml");




            // изменение данных в xml документе с помощью linq

            //XDocument doc2 = XDocument.Load("Company.xml");  // создание документа

            //var employees = doc2.Descendants("Employee").FirstOrDefault(i => (int)i.Attribute("Id") == 1);

            //if (employees != null)
            //{
            //    employees.Element("Age").Value = "33";
            //}
            //doc2.Save("Company.xml");



            // вывод данных из xml

            //foreach (var i in employees)
            //{
            //    int id = (int)i.Attribute("Id");
            //    string name = i.Element("Name")?.Value;
            //    int age = (int)i.Element("Age");

            //    Console.WriteLine($"id = {id}, name = {name}, age = {age}");
            //}


            /*
             отличие XDocument От XmlDocument

            поддержка старых версий
            громоздский синтаксис - XmlDocument

             XDocument вроде лучше
             */


            //XmlDocument doc = new XmlDocument();  // создание документа
            //XmlElement company = doc.CreateElement("company");   // создание корневого элемента
            //doc.AppendChild(company);    // создание дочернего элемента
            //XmlElement employee1 = doc.CreateElement("Emloyee");
            //employee1.SetAttribute("Id", "1");
            //employee1.AppendChild(doc.CreateElement("Name", "John"));
            //employee1.AppendChild(doc.CreateElement("Age", "22"));
            //company.AppendChild(employee1);

            //XmlElement employee2 = doc.CreateElement("Emloyee");
            //employee2.SetAttribute("Id", "2");
            //employee2.AppendChild(doc.CreateElement("Name", "Anny"));
            //employee2.AppendChild(doc.CreateElement("Age", "24"));
            //company.AppendChild(employee2);

            //doc.Save("companyy2.xml");

            XmlDocument doc = new XmlDocument();
            doc.Load("companyy2.xml");    // companyy2.xml возможно companny3.xml

            XmlNode employee = doc.SelectSingleNode("//Employee[@Id='1']");

            if (employee != null)
            {
                employee["Id"].InnerText = "25";
                doc.Save("companyy2.xml");
            }

            //XmlNodeList employees = doc.SelectNodes("//Employees");

            //foreach (XmlNode i in employees)
            //{
            //    int id = Convert.ToInt32(i.Attributes["Id"].Value);
            //    string name = i["Name"]?.InnerText;   // ? - это проверка на null
            //    int age = Convert.ToInt32(i["Age"]?.InnerText);

            //    Console.WriteLine($"id = {id}, name = {name}, age = {age}");
            //}
        }
    }
}
