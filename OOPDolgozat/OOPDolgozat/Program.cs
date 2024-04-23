using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDolgozat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car(5, 6.5, "Fehér", "Toyota", "Corolla", 2021, 8000000, 150000);

			OffRoad offRoad = new OffRoad("4WD", 3500, true, "Land Rover", "Defender", 2020, 15000000, 20000);

			CarSaloon carSaloon = new CarSaloon();

			carSaloon.AddVehicle(car);
			carSaloon.AddVehicle(offRoad);

			carSaloon.AddClient("Suri", "Gyál", "06201111111");

			carSaloon.SellVehicle("Toyota", "Corolla", 0);

			carSaloon.SearchVehicle("Land Rover", "Defender");

			carSaloon.ListVehicles();
		}
	}
}
