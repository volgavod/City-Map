using System;
using System.Linq;
using System.Collections.Generic;

namespace City_Map
{
	public class CityManager
	{
		private Metro _metro = new Metro();
		private BuildingsManager _buildingsManager = new BuildingsManager();
		private PublicTransportManager _publicTransportManager = new PublicTransportManager();

		#region Здания

		public void AddBuilding(string street, decimal number, string type)
		{
			_buildingsManager.AddBuilding(new Address(street, (int)number), Building.ToBuildingType(type));
		}

		public void DeleteBuilding(string street, string number)
		{
			if (string.IsNullOrEmpty(street))
				throw new Exception("Вы не указали улицу");
			if (string.IsNullOrEmpty(number))
				throw new Exception("Вы не указали номер дома");

			_buildingsManager.DeleteBuilding(new Address(street, Convert.ToInt32(number)));
		}

		public void LoadBuildings(Building[] buildings)
		{
			_buildingsManager.LoadBuildings(buildings);
		}

		public Building[] GetBuildings()
		{
			return _buildingsManager.GetBuildings();
		}

		#endregion

		#region Метро

		public void AddMetroLine(decimal number)
		{
			_metro.AddLine((int)number);
		}

		public void AddMetroStation(string lineNumber, string name, string street, decimal buildingNumber)
		{
			if (string.IsNullOrEmpty(lineNumber))
				throw new Exception("Вы не указали линию метро");

			_metro.AddStation(int.Parse(lineNumber), name, new Address(street, (int)buildingNumber));
		}

		public void DeleteMetroLine(string lineNumber)
		{
			_metro.DeleteMetroLine(int.Parse(lineNumber));
		}

		public void DeleteMetroStation(string lineNumber, string stationName)
		{
			_metro.DeleteStation(int.Parse(lineNumber), stationName);
		}

		public MetroStation[] GetMetroStations(string lineNumber)
		{
			return _metro.GetStations(int.Parse(lineNumber));
		}

		public MetroLine[] GetMetroLines()
		{
			return _metro.GetLines().ToArray();
		}

		public object[] GetMetroLineNumbers()
		{
			return _metro.GetLines().Select(line => line.LineNumber).Cast<object>().ToArray();
		}

		public void LoadMetro(Metro metro)
		{
			foreach (MetroLine line in metro.GetLines())
				_metro.AddLine(line);
		}

		#endregion

		#region Общественный транспорт

		public void AddPublicTransport(decimal transportNumber, string publicTransportType)
		{
			_publicTransportManager.AddTransport((int)transportNumber, PublicTransport.ToPublicTransportType(publicTransportType));
		}

		public void AddPublicTransportStop(string transportNumber, string street, decimal buildingNumber)
		{
			_publicTransportManager.AddTransportStop(int.Parse(transportNumber), new Address(street, (int)buildingNumber));
		}

		public void DeletePublicTransport(string transportNumber)
		{
			_publicTransportManager.DeleteTransport(int.Parse(transportNumber));
		}

		public void DeletePublicTransportStop(string transportNumber, string adress)
		{
			_publicTransportManager.DeleteStop(int.Parse(transportNumber), Address.Parse(adress));
		}

		public PublicTransport GetPublicTransport(string transportNumber)
		{
			return _publicTransportManager.GetTransport(int.Parse(transportNumber));
		}

		public IEnumerable<PublicTransport> GetPublicTransports()
		{
			return _publicTransportManager.GetTransports();
		}

		public object[] GetPublicTransportNumbers()
		{
			return GetPublicTransports()
				   .Select(publicTransport => publicTransport.Number)
				   .Cast<object>().ToArray();
		}

		public void LoadPublicTransport(PublicTransport[] transports)
		{
			foreach (PublicTransport transport in transports)
				_publicTransportManager.AddTransport(transport);
		}

		#endregion
	}
}
