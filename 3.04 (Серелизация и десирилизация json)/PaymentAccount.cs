using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace NewPractice_3._04_ // партиал класс это класс который распределен по разным файлам
{
    [Serializable]
    public class PaymentAccount : ISerializable
    {
        private decimal v1;
        private int v2;
        private decimal v3;
        private int v4;

        /*public PaymentAccount(decimal v1, int v2, decimal v3, int v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }*/

        public decimal DailyPayment { get; set; }
        public int NumberOfDays { get; set; }
        public decimal PenaltyPerDay { get; set; }
        public int DelayDays { get; set; }

        public PaymentAccount() { }


        public decimal TotalWithoutPenalty => DailyPayment * NumberOfDays;

        public decimal Penalty => PenaltyPerDay * DelayDays;

        public decimal TotalWithPenalty => TotalWithoutPenalty + Penalty;


        public static bool SerializeComputedFields { get; set; }

        public bool ShouldSerializeTotalWithoutPenalty() => SerializeComputedFields;
        public bool ShouSerializePenalty() => SerializeComputedFields;
        public bool ShouldSerializeTotalWithPenalty() => SerializeComputedFields;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(DailyPayment), DailyPayment);    // передаем название и значение того, что будет сериализовано
            info.AddValue(nameof(NumberOfDays), NumberOfDays);
            info.AddValue(nameof(PenaltyPerDay), PenaltyPerDay);
            info.AddValue(nameof(DelayDays), DelayDays);

            if (SerializeComputedFields)
            {
                info.AddValue(nameof(TotalWithoutPenalty), TotalWithoutPenalty);
                info.AddValue(nameof(Penalty), Penalty);
                info.AddValue(nameof(TotalWithPenalty), TotalWithPenalty);
            }
        }
        // Метод для сериализации в XML

        public void ToXmlFile(string path)
        {
            // создание документа
            XmlDocument doc = new XmlDocument();
            // создания корневого элемента
            XmlElement account = doc.CreateElement("PaymentAccount");
            doc.AppendChild(account);
            // заполнения полей
            XmlElement dailyPayment = doc.CreateElement("DailyPayment");
            dailyPayment.InnerText = DailyPayment.ToString(CultureInfo.InvariantCulture);
            account.AppendChild(dailyPayment);
            //
            XmlElement numOfDays = doc.CreateElement("NumberOfDays");
            numOfDays.InnerText = NumberOfDays.ToString();
            account.AppendChild(numOfDays);

            XmlElement penaltyPerDay = doc.CreateElement("PenaltyPerDay");
            penaltyPerDay.InnerText = PenaltyPerDay.ToString(CultureInfo.InvariantCulture);
            account.AppendChild(penaltyPerDay);

            XmlElement delayDays = doc.CreateElement("DelayDays");
            delayDays.InnerText = DelayDays.ToString();
            account.AppendChild(delayDays);

            // сериализация вычисляемых свойств
            if (SerializeComputedFields)
            {
                XmlElement totalWithoutPenalty = doc.CreateElement("TotalWithoutPenalty");
                totalWithoutPenalty.InnerText =
                    TotalWithoutPenalty.ToString(CultureInfo.InvariantCulture);
                account.AppendChild(totalWithoutPenalty);

                XmlElement penalty =
                    doc.CreateElement("Penalty");
                penalty.InnerText = Penalty.ToString(CultureInfo.InvariantCulture);
                account.AppendChild(penalty);

                XmlElement totalWithPenalty =
                    doc.CreateElement("TotalWithPenalty");
                totalWithPenalty.InnerText =
                    TotalWithPenalty.ToString(CultureInfo.InvariantCulture);
                account.AppendChild(totalWithPenalty);

            }
            doc.Save(path);
        }

        //дессериализация из xml в обьект
        public static PaymentAccount FromXml(string path)
        {
            var serializer = new XmlSerializer(typeof(PaymentAccount));

            using (StreamReader sr = new StreamReader(path))
            {
                try
                {
                    return (PaymentAccount)serializer.Deserialize(sr);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        // сериализация в JSON
        public void ToJson(string path)
        {
            try
            {
                string json = JsonConvert.SerializeObject
                (this, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(path, json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Десериализация из Json
        public static PaymentAccount FromJson(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<PaymentAccount>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }

        // Переопределения ToString для удобного вывода
        public override string ToString()
        {
            return $"DailyPayment = {DailyPayment}, NumberOfDays = {NumberOfDays}, PenaltyPerDay = {PenaltyPerDay}, DelayDays = {DelayDays}" +
                $"TotalWithoutPenalty = {TotalWithoutPenalty}, Penalty = {Penalty}, TotalWithPenalty = {TotalWithPenalty}";
        }
    }
}