using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class Car : Vehicle
	{
		public int NumberOfSeats { get; set; }
		public double FuelConsumption { get; set; }
		public string Color { get; set; }


		public Car(int numberOfSeats, double fuelConsumption, string color, string manufacturer, string model, int year, int basePrice, int odometerPosition) : base(manufacturer, model, year, basePrice, odometerPosition)
		{
			NumberOfSeats = numberOfSeats;
			FuelConsumption = fuelConsumption;
			Color = color;
		}

		public void ExtraComfortPurchase(string extra)
		{
            Console.WriteLine($"Beszerzett extra: {extra}");
			int extraFee = 300;
			BasePrice += extraFee;
			Console.WriteLine($"Frissített alapár: {BasePrice}");
        }

		public void UpdateColor(string newColor)
		{
			Color = newColor;
            Console.WriteLine("Jármű színe frissítve");
        }

	}
}
