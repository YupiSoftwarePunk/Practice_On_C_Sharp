using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NewPractice_3._04_
{
    [Serializable]
    public class PaymentAccount : ISerializable
    {
        public decimal DailyPayment { get; set; }
        public int NumberOfDays { get; set; }
        public decimal PenaltyPerDay { get; set; }
        public int DelayDays { get; set; }


        public decimal TotalWithoutPenalty => DailyPayment * NumberOfDays;

        public decimal Penalty => PenaltyPerDay * DelayDays;

        public decimal TotalWithPenalty => TotalWithoutPenalty + Penalty;

        public bool ShoudSerializeTotalWithoutPenalty() => SerializeComputedFields;
        public bool ShoudSerializePenalty() => SerializeComputedFields;
        public bool ShoudSerializeTotalWithPenalty() => SerializeComputedFields;



        public static bool SerializeComputedFields { get; set; } = true;


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


        // метод для серилизации в xml
        public void ToXml(string path)
        {

        }


        public override string ToString()
        {
            return $"DailyPayment = {DailyPayment}, NumberOfDays = {NumberOfDays}, PenaltyPerDay = {PenaltyPerDay}, DelayDays = {DelayDays}" +
                $"TotalWithoutPenalty = {TotalWithoutPenalty}, Penalty = {Penalty}, TotalWithPenalty = {TotalWithPenalty}";
        }


        // серилизация в json
        public void ToJson(string path)
        {

            try
            {
                string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(path, json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

        public static PaymentAccount FromJson(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<PaymentAccount>(json);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}