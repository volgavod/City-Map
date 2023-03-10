using System;

namespace City_Map
{
	public class Building
	{
		public Address Adress => _adress;
		public BuildingType Type => _type;

		private Address _adress;
		private BuildingType _type;

		public Building(Address adress, BuildingType type)
		{
			_adress = adress;
			_type = type;
		}

		public override string ToString()
		{
			return Adress.ToString() + " - " + BuildingTypeToString(_type);
		}

		private string BuildingTypeToString(BuildingType type)
		{
			switch (type)
			{
				case BuildingType.Shop: return "Магазин";
				case BuildingType.Theater: return "Театр";
				case BuildingType.ApartmentHouse: return "Жилой дом";
				default: throw new Exception("Незарегистрированный тип здания");
			}
		}

		public static BuildingType ToBuildingType(string type)
		{
			switch (type)
			{
				case "Магазин": return BuildingType.Shop;
				case "Театр": return BuildingType.Theater;
				case "Жилой дом": return BuildingType.ApartmentHouse;
				default: throw new Exception("Незарегистрированный тип здания");
			}
		}
	}

	public enum BuildingType
	{
		Shop,
		Theater,
		ApartmentHouse
	}
}
