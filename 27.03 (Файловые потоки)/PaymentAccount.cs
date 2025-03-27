using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NewPractice_27._03_
{
    [Serializable]
    public class PaymentAccount : ISerializable
    {
        public decimal DailyPayment {  get; set; }
        public int NumberOfDays { get; set; }
        public decimal PenaltyPerDay { get; set; }
        public int DelayDays { get; set; }

        public decimal TotalWithoutPenalty => DailyPayment * NumberOfDays;

        public decimal Penalty => PenaltyPerDay * DelayDays;

        public decimal TotalWithPenalty => TotalWithoutPenalty + Penalty;

        public static bool SerializeComputedFields {  get; set; }

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
        public override string ToString()
        {
            return $"DailyPayment = {DailyPayment}, NumberOfDays = {NumberOfDays}, PenaltyPerDay = {PenaltyPerDay}, DelayDays = {DelayDays}" +
                $"TotalWithoutPenalty = {TotalWithoutPenalty}, Penalty = {Penalty}, TotalWithPenalty = {TotalWithPenalty}"; 
        }
    }
}
