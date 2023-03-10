using System;
using System.Collections.Generic;

namespace City_Map
{
	public class MetroLine
	{
		public MetroStation[] Stations => _stations.ToArray();
		public int LineNumber { get; private set; }

		private List<MetroStation> _stations = new List<MetroStation>();

		public MetroLine(int lineNumber)
		{
			LineNumber = lineNumber;
		}

		public void AddStation(MetroStation station)
		{
			if (IsStationExist(station))
				throw new Exception("Станция метро с идентичным(и) названием и/или адресом уже существует");

			_stations.Add(station);
		}


		public void DeleteStation(string name)
		{
			if (IsStationExist(name) == false)
				throw new Exception("Станции метро с таким названием не существует");

			_stations.Remove(GetStation(name));
		}

		public MetroStation GetStation(string name)
		{
			foreach (MetroStation station in _stations)
				if (station.Name == name)
					return station;
			return null;
		}

		private bool IsStationExist(string name)
		{
			foreach (MetroStation station in _stations)
				if (station.Name == name)
					return true;
			return false;
		}

		private bool IsStationExist(MetroStation checkingStation)
		{
			foreach (MetroStation station in _stations)
				if (station.Name == checkingStation.Name || station.Adress == checkingStation.Adress)
					return true;
			return false;
		}
	}
}
