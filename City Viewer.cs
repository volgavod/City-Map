using System;
using System.Linq;
using System.Windows.Forms;

namespace City_Map
{
	public partial class CityViewer : Form
	{
		CityManager _cityManager;

		public CityViewer(CityManager cityManager)
		{
			_cityManager = cityManager;
			InitializeComponent();
		}

		private void input_GetBuildingsByStreet_Click(object sender, EventArgs e)
		{
			input_GetBuildingsByStreet.Items.Clear();
			input_GetBuildingsByStreet.Items.AddRange(
				_cityManager.GetBuildings()
				.Select(building => building.Adress.Street)
				.Distinct().ToArray());
		}

		private void button_GetBuildingsByStreet_Click(object sender, EventArgs e)
		{
			output_Buildings.Clear();
			output_Buildings.Lines = _cityManager.GetBuildings()
				.Where(building => building.Adress.Street == input_GetBuildingsByStreet.Text)
				.Select(building => building.ToString()).ToArray();
		}

		private void button_GetBuildingsByType_Click(object sender, EventArgs e)
		{
			output_Buildings.Clear();
			output_Buildings.Lines = _cityManager.GetBuildings()
				.Where(building => building.Type == Building.ToBuildingType(input_GetBuildingsByType.Text))
				.Select(building => building.Adress.ToString()).ToArray();
		}

		private void input_GetMetroStationsNamesByLineNumber_Click(object sender, EventArgs e)
		{
			input_GetMetroStationsNamesByLineNumber.Items.Clear();
			input_GetMetroStationsNamesByLineNumber.Items.AddRange(_cityManager.GetMetroLineNumbers());
		}

		private void button_GetMetroStationsNamesByLineNumber_Click(object sender, EventArgs e)
		{
			output_Metro.Clear();
			output_Metro.Lines = _cityManager
				.GetMetroStations(input_GetMetroStationsNamesByLineNumber.Text)
				.Select(station => station.ToString()).ToArray();
		}

		private void input_GetMetroStationsAmount_Click(object sender, EventArgs e)
		{
			input_GetMetroStationsAmount.Items.Clear();
			input_GetMetroStationsAmount.Items.AddRange(_cityManager.GetMetroLineNumbers());
		}

		private void button_GetMetroStationsAmount_Click(object sender, EventArgs e)
		{
			output_Metro.Clear();
			output_Metro.Text = _cityManager
				.GetMetroStations(input_GetMetroStationsAmount.Text)
				.Count().ToString();
		}

		private void input_GetStopAdressesByRouteNumber_Click(object sender, EventArgs e)
		{
			input_GetStopAdressesByRouteNumber.Items.Clear();
			input_GetStopAdressesByRouteNumber.Items.AddRange(_cityManager.GetPublicTransportNumbers());
		}

		private void button_GetStopAdressesByRouteNumber_Click(object sender, EventArgs e)
		{
			output_PublicTransportRoutes.Clear();
			output_PublicTransportRoutes.Lines = _cityManager
				.GetPublicTransport(input_GetStopAdressesByRouteNumber.Text)
				.GetAdresses().Select(adress => adress.ToString()).ToArray();
		}

		private void button_GetRouteNumbersByPublicTransportType_Click(object sender, EventArgs e)
		{
			PublicTransportType transportType = 
				PublicTransport.ToPublicTransportType(input_GetRouteNumbersByPublicTransportType.Text);

			output_PublicTransportRoutes.Clear();
			output_PublicTransportRoutes.Lines = _cityManager.GetPublicTransports()
				.Where(transport => transport.Type == transportType)
				.Select(transport => transport.Number.ToString()).ToArray();
		}
	}
}
