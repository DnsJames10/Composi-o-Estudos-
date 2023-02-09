using System;


namespace Estudos1.Entities
{
    internal class HourContract
    {
        public DateTime Data { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime data, double valueperhour , int hours)
        {
            Data = data; ValuePerHour = valueperhour; Hours = hours; 
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
