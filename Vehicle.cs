using System;

public class Vehicle
{
	// Private fields (encapsulation)
	private string _make;
	private string _model;
	private int _year;
	private double _mileage;
	private double _lastServiceMileage;

	// Public properties
	public string Make
	{
		get { return _make; }
		set { _make = value; }
	}

	public string Model
	{
		get { return _model; }
		set { _model = value; }
	}

	public int Year
	{
		get { return _year; }
		set { _year = value; }
	}

	public double Mileage
	{
		get { return _mileage; }
		private set { _mileage = value; }  // protected from outside changes
	}

	public double LastServiceMileage
	{
		get { return _lastServiceMileage; }
		private set { _lastServiceMileage = value; }
	}

	// Default constructor
	public Vehicle()
	{
		_make = "Unknown";
		_model = "Unknown";
		_year = 0;
		_mileage = 0;
		_lastServiceMileage = 0;
	}

	// Overloaded constructor
	public Vehicle(string make, string model, int year, double mileage)
	{
		_make = make;
		_model = model;
		_year = year;
		_mileage = mileage;
		_lastServiceMileage = mileage;
	}

	// Add mileage (cannot be negative)
	public void AddMileage(double miles)
	{
		if (miles > 0)
		{
			_mileage += miles;
		}
	}

	// Check if service is needed
	public bool NeedsService()
	{
		return (_mileage - _lastServiceMileage) > 10000;
	}

	// Perform service
	public void PerformService()
	{
		_lastServiceMileage = _mileage;
	}

	// Get summary
	public string GetSummary()
	{
		string status = NeedsService() ? "Needs Service" : "OK";
		return $"{_year} {_make} {_model} | Mileage: {_mileage} | Status: {status}";
	}
}
