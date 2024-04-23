using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class Vehicle
	{
		public string Manufacturer { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public int BasePrice { get; set; }
		public int OdometerPosition { get; set; }
		public List<string> ServiceLogBook { get; set; }

		public Vehicle(string manufacturer, string model, int year, int basePrice, int odometerPosition)
		{
			Manufacturer = manufacturer;
			Model = model;
			Year = year;
			BasePrice = basePrice;
			OdometerPosition = odometerPosition;
			ServiceLogBook = new List<string>();
		}

		public void VehicleInfo()
		{
            Console.WriteLine($"Autó információi:");
			Console.WriteLine($"Gyártó: {Manufacturer}");
			Console.WriteLine($"Modell: {Model}");
			Console.WriteLine($"Évjárat: {Year}");
			Console.WriteLine($"Alapár: {BasePrice}");
        }

		public int PriceCalculation()
		{
			int price = BasePrice - (Year * 4000);
            Console.WriteLine($"Autó aktuális ára: {price}");
            return price; 
		}

		public void OdometerUpdate(int km)
		{
            Console.WriteLine("Kilométeróra frissítve");
            OdometerPosition += km;
		}

		public void AddService(string service)
		{
			ServiceLogBook.Add(service);
			Console.WriteLine($"{service} hozzáadva a szervíznaplóhoz");
		}

		public void ListServiceLogBook()
		{
            Console.WriteLine("Elvégzett szervizelési események: ");
            foreach (string service in ServiceLogBook)
			{
                Console.Write($"{service}, ");
            }
		}
	}
}
