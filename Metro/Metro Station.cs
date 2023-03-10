using System;

namespace City_Map
{
	public class MetroStation
	{
		public Address Adress => _adress;
		public string Name => _name;
		
		private string _name;
		private Address _adress;
		
		public MetroStation(string name, Address adress)
		{
			_ = IsNameCorrect(name) ?
				_name = name :
				throw new Exception("Название станции метро может содержать только буквы, цифры и тире; " +
					"должно начинаться с заглавной буквы и быть в длину не меньше 3 символов");

			_adress = adress;
		}

		public override string ToString()
		{
			return _name + " - " + _adress.ToString();
		}

		private bool IsNameCorrect(string name)
		{
			if (name.Length < 3)
				return false;
			if (char.IsLower(name[0]))
				return false;
			foreach (char letter in name)
				if (!char.IsLetterOrDigit(letter) && letter != '-')
					return false;
			return true;
		}
	}
}
