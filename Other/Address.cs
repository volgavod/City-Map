using System;

namespace City_Map
{
	public class Address
	{
		public string Street => _street;
		public int BuildingNumber => _buildingNumber;

		private string _street;
		private int _buildingNumber;

		public Address(string street, int buildingNumber)
		{
			_ = IsStreetCorrect(street) ?
				_street = street :
				throw new Exception("Название улицы может содержать только буквы, цифры и тире; " +
					"должно начинаться с заглавной буквы и быть в длину не меньше 3 символов");

			_ = IsNumberCorrect(buildingNumber) ?
				_buildingNumber = buildingNumber :
				throw new Exception("Номер дома не может быть меньше единицы");
		}

		private bool IsNumberCorrect(int number)
		{
			if (number < 1)
				return false;
			return true;
		}

		private bool IsStreetCorrect(string street)
		{
			if (street.Length < 3)
				return false;
			if (char.IsLower(street[0]))
				return false;
			foreach (char letter in street)
				if (!char.IsLetterOrDigit(letter) && letter != '-')
					return false;
			return true;
		}

		public static Address Parse(string input)
		{
			string[] adress = input.Split(' ');
			if (adress.Length < 3)
				throw new Exception("Недействительный адрес");

			return new Address(adress[0], int.Parse(adress[2]));
		}

		public override string ToString()
		{
			return $"{_street} дом {_buildingNumber}";
		}

		public static bool operator ==(Address a1, Address a2)
		{
			if (a1.Street == a2.Street)
				if (a1.BuildingNumber == a2.BuildingNumber)
					return true;
			return false;
		}

		public static bool operator !=(Address a1, Address a2)
		{
			if (a1.Street != a2.Street)
				return true;
			if (a1.BuildingNumber != a2.BuildingNumber)
				return true;
			return false;
		}
	}
}
