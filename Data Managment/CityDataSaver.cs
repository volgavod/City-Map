using System.IO;

namespace City_Map
{
	public static class CityDataSaver
	{
		private static readonly string path = @"City Data\";

		public static void SaveMap(CityManager cityManager)
		{
			Directory.CreateDirectory(path);

			SaveMetro(cityManager);
			SaveBuildings(cityManager);
			SavePublicTransport(cityManager);
		}

		private static void SaveBuildings(CityManager cityManager)
		{
			using (StreamWriter file = new StreamWriter(path + "Buildings.txt"))
				foreach (Building building in cityManager.GetBuildings())
					file.WriteLine(building.ToString());
		}

		private static void SaveMetro(CityManager cityManager)
		{
			using (StreamWriter file = new StreamWriter(path + "Metro.txt"))
				foreach (MetroLine line in cityManager.GetMetroLines())
					foreach (MetroStation station in line.Stations)
						file.WriteLine(line.LineNumber + " " + station.ToString());
		}

		private static void SavePublicTransport(CityManager cityManager)
		{
			using (StreamWriter file = new StreamWriter(path + "Public Transport.txt"))
				foreach (PublicTransport transport in cityManager.GetPublicTransports())
				{
					file.WriteLine(transport.Number + " " + transport.Type);

					foreach (Address adress in transport.GetAdresses())
						file.WriteLine(adress.ToString());
				}
		}
	}
}
