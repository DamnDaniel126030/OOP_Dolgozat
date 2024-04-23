using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class CarSaloon
	{
		public List<Vehicle> Vehicles { get; set; }
		public List<Client> Clients { get; set; }
		public List<Vehicle> SoldVehicles { get; set; }


		public CarSaloon()
		{
			Vehicles = new List<Vehicle>();
			Clients = new List<Client>();
			SoldVehicles = new List<Vehicle>();
		}

		public void AddVehicle(Vehicle vehicle)
		{
			Vehicles.Add(vehicle);
            Console.WriteLine("Sikeresen hozzáadta a listához a járművet");
        }

		public bool SellVehicle(string manufacturer, string model, int clientIndex)
		{
			foreach (Vehicle vehicle in Vehicles)
			{
				if (vehicle.Manufacturer == manufacturer && vehicle.Model == model)
				{
					Vehicles.Remove(vehicle);
					SoldVehicles.Add(vehicle);
					Clients[clientIndex].PurchasedVehicle(vehicle);
					Console.WriteLine("Jármű sikeresen eladva");
					return true;
				}
			}
            Console.WriteLine("Sikertelen eladás");
			return false;
        }

		public Vehicle SearchVehicle(string manufacturer, string model)
		{
			foreach (Vehicle vehicle in Vehicles)
			{
				if (vehicle.Manufacturer == manufacturer && vehicle.Model == model)
				{
                    Console.WriteLine("Megtalálta a keresett járművet");
                    return vehicle;
				}
			}
            Console.WriteLine("Sikertelen keresés");
			return null;
        }

		public void ListVehicles()
		{
			foreach (Vehicle vehicle in Vehicles)
			{
				vehicle.VehicleInfo();
			}
		}

		public void AddClient(string name, string address, string phoneNumber)
		{
            Console.WriteLine("Ügyfél sikeresen hozzáadva");
            Clients.Add(new Client(name, address, phoneNumber));
		}

		public void SalesReport()
		{
            Console.WriteLine($"Eladott autók száma: {SoldVehicles.Count}");
			int income = 0;
			foreach (Vehicle vehicle in SoldVehicles)
			{
				income += vehicle.BasePrice;
			}
            Console.WriteLine($"Összes bevétel: {income}");
        }
	}
}
