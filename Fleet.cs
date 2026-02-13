using System;
using System;

namespace VehicleFleetManager
{

	using System.Collections.Generic;
	using System.Linq;
	using VehicleFleetManager;

	public class Fleet
	{
		private List<Vehicle> _vehicles;

		public Fleet()
		{
			_vehicles = new List<Vehicle>();
		}

		public void AddVehicle(Vehicle v)
		{
			_vehicles.Add(v);
		}

		public void RemoveVehicle(string model)
		{
			_vehicles.RemoveAll(v => v.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
		}

		public double GetAverageMileage()
		{
			if (_vehicles.Count == 0)
				return 0;

			return _vehicles.Average(v => v.Mileage);
		}

		public void DisplayAllVehicles()
		{
			if (_vehicles.Count == 0)
			{
				Console.WriteLine("No vehicles in fleet.");
				return;
			}

			foreach (var v in _vehicles)
			{
				Console.WriteLine(v.GetSummary());
			}
		}

		public void ServiceAllDue()
		{
			int serviced = 0;

			foreach (var v in _vehicles)
			{
				if (v.NeedsService())
				{
					v.PerformService();
					serviced++;
				}
			}

			Console.WriteLine($"{serviced} vehicles serviced.");
		}
	}
}
