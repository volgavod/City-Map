using System;
using System.Collections.Generic;

namespace City_Map
{
	class PublicTransportManager
	{
		private List<PublicTransport> _transports = new List<PublicTransport>();

		private readonly string msg_RouteDoesNotExist = "Общественного транспорта под таким номером не существует";
		private readonly string msg_RouteAlreadyExist = "Общественный транспорт под таким номером уже существует";

		public void AddTransport(int transportNumber, PublicTransportType type)
		{
			if (IsTransportExist(transportNumber))
				throw new Exception(msg_RouteAlreadyExist);

			_transports.Add(new PublicTransport(transportNumber, type));
		}

		public void AddTransport(PublicTransport transport)
		{
			if (IsTransportExist(transport.Number))
				throw new Exception(msg_RouteAlreadyExist);

			_transports.Add(transport);
		}

		public void AddTransportStop(int transportNumber, Address adress)
		{
			if (IsTransportExist(transportNumber) == false)
				throw new Exception(msg_RouteDoesNotExist);

			for (int i = 0; i < _transports.Count; i++)
				if (_transports[i].Number == transportNumber)
					_transports[i].AddStop(adress);
		}

		public void DeleteTransport(int transportNumber)
		{
			if (IsTransportExist(transportNumber) == false)
				throw new Exception(msg_RouteDoesNotExist);

			_transports.Remove(GetTransport(transportNumber));
		}

		public void DeleteStop(int transportNumber, Address adress)
		{
			if (IsTransportExist(transportNumber) == false)
				throw new Exception(msg_RouteDoesNotExist);

			for (int i = 0; i < _transports.Count; i++)
				if (_transports[i].Number == transportNumber)
				{
					_transports[i].DeleteStop(adress);
					break;
				}
		}

		public PublicTransport GetTransport(int transportNumber)
		{
			foreach (PublicTransport transport in _transports)
				if (transport.Number == transportNumber)
					return transport;
			return null;
		}

		public IEnumerable<PublicTransport> GetTransports()
		{
			return _transports;
		}

		public bool IsTransportExist(int transportNumber)
		{
			foreach (PublicTransport transport in _transports)
				if (transport.Number == transportNumber)
					return true;
			return false;
		}
	}
}
