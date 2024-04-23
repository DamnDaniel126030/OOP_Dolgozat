using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class Client
	{
		public string Name { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public List<Vehicle> PurchaseHistory { get; set; }

		public Client(string name, string address, string phoneNumber)
		{
			Name = name;
			Address = address;
			PhoneNumber = phoneNumber;
			PurchaseHistory = new List<Vehicle>();
		}

		public void PurchasedVehicle(Vehicle vehicle)
		{
            Console.WriteLine("Vásárolt jármű sikeresen hozzáadva a vásárlási előzményhez");
            PurchaseHistory.Add(vehicle);
		}
	}
}
