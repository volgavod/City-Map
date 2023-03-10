using System;
using System.Collections.Generic;

namespace City_Map
{
	public class Metro
	{
		private List<MetroLine> _lines = new List<MetroLine>();
		private readonly string msg_LineDoesNotExist = "Такой линии метро не существует";
		private readonly string msg_LineAlreadyExist = "Линия метро под таким номером уже существует";

		public void AddLine(int lineNumber)
		{
			if (IsLineExist(lineNumber))
				throw new Exception(msg_LineAlreadyExist);

			_lines.Add(new MetroLine(lineNumber));
		}

		public void AddLine(MetroLine line)
		{
			if (IsLineExist(line))
				throw new Exception(msg_LineAlreadyExist);

			_lines.Add(line);
		}

		public void AddStation(int lineNumber, string name, Address adress)
		{
			if (IsLineExist(lineNumber) == false)
				throw new Exception(msg_LineDoesNotExist);

			for (int i = 0; i < _lines.Count; i++)
				if (_lines[i].LineNumber == lineNumber)
					_lines[i].AddStation(new MetroStation(name, adress));
		}

		public void DeleteMetroLine(int lineNumber)
		{
			if (IsLineExist(lineNumber) == false)
				throw new Exception(msg_LineDoesNotExist);

			_lines.Remove(GetLine(lineNumber));
		}

		public void DeleteStation(int lineNumber, string stationName)
		{
			if (IsLineExist(lineNumber) == false)
				throw new Exception(msg_LineDoesNotExist);

			for (int i = 0; i < _lines.Count; i++)
				if (_lines[i].LineNumber == lineNumber)
					_lines[i].DeleteStation(stationName);
		}

		public MetroLine[] GetLines()
		{
			return _lines.ToArray();
		}

		public MetroLine GetLine(int lineNumber)
		{
			foreach (MetroLine line in _lines)
				if (line.LineNumber == lineNumber)
					return line;
			return null;
		}

		public MetroStation[] GetStations(int lineNumber)
		{
			return GetLine(lineNumber).Stations;
		}

		private bool IsLineExist(MetroLine line)
		{
			return IsLineExist(line.LineNumber);
		}

		private bool IsLineExist(int lineNumber)
		{
			foreach (MetroLine line in _lines)
				if (line.LineNumber == lineNumber)
					return true;
			return false;
		}
	}
}
