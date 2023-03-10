using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace City_Map
{
	public class BuildingsManager
	{
		private List<Building> _buildings = new List<Building>();

		public void AddBuilding(Address adress, BuildingType type)
		{
			if (IsBuildingExist(adress))
				throw new Exception("Такой адрес уже существует");
			_buildings.Add(new Building(adress, type));
		}
		
		public void DeleteBuilding(Address adress)
		{
			foreach (Building building in _buildings.ToArray())
				if (building.Adress == adress)
				{
					_buildings.Remove(building);
					return;
				}
			throw new Exception("Такого адреса не существует, или он был удалён");
		}

		public Building[] GetBuildings()
		{
			return _buildings.ToArray();
		}

		public void LoadBuildings(Building[] buildings)
		{
			foreach (Building building in buildings)
				if (IsBuildingExist(building.Adress) == false)
					_buildings.Add(building);
		}

		private bool IsBuildingExist(Address adress)
		{
			foreach (Building building in _buildings)
				if (building.Adress == adress)
					return true;
			return false;
		}
	}
}
