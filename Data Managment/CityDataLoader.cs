using System;
using System.IO;
using System.Collections.Generic;

namespace City_Map
{
	public static class CityDataLoader
	{
		private static readonly string path = @"City Data\";

		public static Building[] LoadBuildings(out int totalNotes, out int errorsNotes)
		{
			CheckFile("Buildings.txt");

			string[] buildingsFromFile = File.ReadAllLines(path + "Buildings.txt");
			List<Building> buildings = new List<Building>();
			totalNotes = buildingsFromFile.Length;
			errorsNotes = 0;

			foreach (string building in buildingsFromFile)
			{
				string[] buildingProperties = building.Split(' ');
				if (buildingProperties.Length < 5 || buildingProperties.Length > 6)
				{
					errorsNotes++;
					continue;
				}

				string buildingType = buildingProperties[4];
				if (buildingProperties.Length == 6)
					buildingType += " " + buildingProperties[5];

				try
				{
					buildings.Add(new Building(
						new Address(buildingProperties[0], int.Parse(buildingProperties[2])),
						Building.ToBuildingType(buildingType)));
				}
				catch
				{
					errorsNotes++;
				}
			}

			return buildings.ToArray();
		}

		public static Metro LoadMetro(out int totalNotes, out int errorsNotes)
		{
			CheckFile("Metro.txt");

			string[] metroFromFile = File.ReadAllLines(path + "Metro.txt");
			Metro metro = new Metro();
			totalNotes = 0;
			errorsNotes = 0;

			foreach (string station in metroFromFile)
			{
				string[] stationProperties = station.Split(' ');
				if (stationProperties.Length != 6)
				{
					errorsNotes++;
					continue;
				}

				try
				{
					metro.AddLine(int.Parse(stationProperties[0]));
				}
				catch
				{
					
				}
				finally
				{
					try
					{
						metro.AddStation(int.Parse(stationProperties[0]), stationProperties[1],
							new Address(stationProperties[3], int.Parse(stationProperties[5])));

						totalNotes++;
					}
					catch
					{
						errorsNotes++;
					}
				}
			}

			return new Metro();
		}

		public static PublicTransport[] LoadPublicTransport(out int totalNotes, out int errorsNotes)
		{
			CheckFile("Public Transport.txt");

			string[] transportsFromFile = File.ReadAllLines(path + "Public Transport.txt");
			List<PublicTransport> transports = new List<PublicTransport>();
			totalNotes = transportsFromFile.Length;
			int currentTransport = 0;
			errorsNotes = 0;

			foreach (string transport in transportsFromFile)
			{
				string[] transportProperties = transport.Split(' ');

				if (transportProperties.Length == 2)
				{
					try
					{
						transports.Add(new PublicTransport(int.Parse(transportProperties[0]),
							PublicTransport.ToPublicTransportType(transportProperties[1])));

						currentTransport = int.Parse(transportProperties[0]);
					}
					catch
					{
						errorsNotes++;
					}
				}

				if (transportProperties.Length == 3 || currentTransport == 0)
				{
					for (int i = 0; i < transports.Count; i++)
						if (transports[i].Number == currentTransport)
						{
							try
							{
								transports[i].AddStop(new Address(transportProperties[0], int.Parse(transportProperties[2])));
							}
							catch
							{
								errorsNotes++;
							}
						}
				}
				else
					errorsNotes++;
			}

			return transports.ToArray();
		}

		private static void CheckFile(string fileName)
		{
			if (File.Exists(path + fileName) == false)
				throw new Exception("Файла с информацией о зданиях не существует");
		}
	}
}
