using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class OffRoad : Vehicle
	{
		public string Drive { get; set; }
		public bool OffRoadCapabilities { get; set; }
		public int TowingCapacity { get; set; }

		public OffRoad(string drive, int towingCapacity,bool offRoadCapabilities, string manufacturer, string model, int year, int basePrice, int odometerPosition) : base(manufacturer, model, year, basePrice, odometerPosition)
		{
			Drive = drive;
			OffRoadCapabilities = offRoadCapabilities;
			TowingCapacity = towingCapacity;
		}	

		public void OffRoadPackage()
		{
            Console.WriteLine("Off-Road csomag felszerelve");
			BasePrice += 700;
            Console.WriteLine($"Frissített alapár: {BasePrice}");
        }

		public void SetTowingCapacity(int capacity)
		{
			TowingCapacity = capacity;
            Console.WriteLine("Vontatóképesség frissítve");
        }
	}
}
