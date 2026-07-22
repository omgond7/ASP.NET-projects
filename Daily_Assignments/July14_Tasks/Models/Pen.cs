using System;

namespace StationeryStoreManagement
{
    public class Pen : StationeryItem
    {
        public string InkColor { get; set; } = string.Empty;
        public string PenType { get; set; } = string.Empty;

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Ink Color : " + InkColor);
            Console.WriteLine("Pen Type  : " + PenType);
        }

        public override double CalculateDiscount(double amount)
        {
            return amount * 0.05;
        }
    }
}