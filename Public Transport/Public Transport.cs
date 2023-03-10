using System;
using System.Collections.Generic;

namespace City_Map
{
	public class PublicTransport
	{
		public int Number => _number;
		public PublicTransportType Type => _type;

		private int _number;
		private PublicTransportType _type;
		private List<Address> _route = new List<Address>();

		public PublicTransport(int number, PublicTransportType type)
		{
			if (IsRouteNumberCorrect(number))
				_number = number;
			else
				throw new Exception("Номер маршрута не может быть меньше единицы");

			_type = type;
		}

		public void AddStop(Address adress)
		{
			foreach (Address stop in _route)
				if (stop == adress)
					throw new Exception("Остановка с таким адресом уже существует");
			_route.Add(adress);
		}

		public void DeleteStop(Address deletingAdress)
		{
			if (IsAdressExist(deletingAdress) == false)
				throw new Exception("Остановки по такому адресу не существует");

			foreach (Address adress in _route.ToArray())
				if (deletingAdress == adress)
					_route.Remove(adress);
		}

		public Address[] GetAdresses()
		{
			return _route.ToArray();
		}

		private bool IsAdressExist(Address checkedAdress)
		{
			foreach (Address adress in _route)
				if (checkedAdress == adress)
					return true;
			return false;
		}

		private bool IsRouteNumberCorrect(int number)
		{
			if (number < 1)
				return false;
			return true;
		}

		public static PublicTransportType ToPublicTransportType(string type)
		{
			switch (type)
			{
				case "Автобус": return PublicTransportType.Bus;
				case "Трамвай": return PublicTransportType.Tram;
				case "Троллейбус": return PublicTransportType.Trolleybus;
				default: throw new Exception("Незарегистрированный тип транспорта");
			}
		}
	}

	public enum PublicTransportType
	{
		Bus,
		Tram,
		Trolleybus
	}
}
