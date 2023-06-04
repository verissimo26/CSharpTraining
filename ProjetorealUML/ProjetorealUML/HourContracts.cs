﻿
namespace ProjetorealUML
{
    internal class HourContracts
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContracts() 
        {
            
        }

        public HourContracts(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue ()
        {
            return Hours * ValuePerHour;
        }
     }
}
