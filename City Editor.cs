using System;
using System.Linq;
using System.Windows.Forms;

namespace City_Map
{
	public partial class CityEditor : Form
	{
		private CityManager _cityManager;

		public CityEditor(CityManager cityManager)
		{
			_cityManager = cityManager;
			InitializeComponent();
		}

		#region Редактор зданий

		private void button_AddBuilding_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.AddBuilding(input_AddBuilding_Street.Text,
										 input_AddBuilding_Number.Value,
										 input_AddBuilding_Type.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_DeleteBuilding_Street_Click(object sender, EventArgs e)
		{
			input_DeleteBuilding_Street.Items.Clear();
			input_DeleteBuilding_Street.Items.AddRange(
				_cityManager.GetBuildings().Select(building => building.Adress.Street).Distinct().ToArray());
		}

		private void input_DeleteBuilding_Number_Click(object sender, EventArgs e)
		{
			input_DeleteBuilding_Number.Items.Clear();
			input_DeleteBuilding_Number.Items.AddRange(
				_cityManager.GetBuildings()
				.Where(building => building.Adress.Street == input_DeleteBuilding_Street.Text)
				.Select(building => building.Adress.BuildingNumber)
				.Cast<object>().ToArray());
		}

		private void button_DeleteBuilding_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.DeleteBuilding(input_DeleteBuilding_Street.Text,
											input_DeleteBuilding_Number.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		#endregion

		#region Редактор метро

		private void button_AddMetroLine_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.AddMetroLine(input_AddMetroLine_Number.Value);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_AddMetroStation_LineNumber_Click(object sender, EventArgs e)
		{
			input_AddMetroStation_LineNumber.Items.Clear();
			input_AddMetroStation_LineNumber.Items.AddRange(_cityManager.GetMetroLineNumbers());
		}

		private void button_AddMetroStation_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.AddMetroStation(input_AddMetroStation_LineNumber.Text,
											 input_AddMetroStation_Name.Text,
											 input_AddMetroStation_Street.Text,
											 input_AddMetroStation_BuildingNumber.Value);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_DeleteMetroLine_Number_Click(object sender, EventArgs e)
		{
			input_DeleteMetroLine_Number.Items.Clear();
			input_DeleteMetroLine_Number.Items.AddRange(_cityManager.GetMetroLineNumbers());
		}

		private void button_DeleteMetroLine_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.DeleteMetroLine(input_DeleteMetroLine_Number.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_DeleteMetroStation_LineNumber_Click(object sender, EventArgs e)
		{
			input_DeleteMetroStation_LineNumber.Items.Clear();
			input_DeleteMetroStation_LineNumber.Items.AddRange(_cityManager.GetMetroLineNumbers());
		}

		private void input_DeleteMetroStation_Name_Click(object sender, EventArgs e)
		{
			try
			{
				input_DeleteMetroStation_Name.Items.Clear();
				input_DeleteMetroStation_Name.Items.AddRange(
					_cityManager.GetMetroStations(input_DeleteMetroStation_LineNumber.Text)
					.Select(station => station.Name).Cast<object>().ToArray());
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void button_DeleteMetroStation_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.DeleteMetroStation(input_DeleteMetroStation_LineNumber.Text,
												input_DeleteMetroStation_Name.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		#endregion

		#region Редактор общественного транспорта

		private void button_AddPublicTransport_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.AddPublicTransport(input_AddPublicTransport_Number.Value,
												input_AddPublicTransport_Type.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_AddPublicTransportStop_TransportNumber_Click(object sender, EventArgs e)
		{
			input_AddPublicTransportStop_TransportNumber.Items.Clear();
			input_AddPublicTransportStop_TransportNumber.Items.AddRange(_cityManager.GetPublicTransportNumbers());
		}

		private void button_AddPublicTransportStop_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.AddPublicTransportStop(input_AddPublicTransportStop_TransportNumber.Text,
													input_AddPublicTransportStop_Street.Text,
													input_AddPublicTransportStop_BuildingNumber.Value);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_DeletePublicTransport_Number_Click(object sender, EventArgs e)
		{
			input_DeletePublicTransport_Number.Items.Clear();
			input_DeletePublicTransport_Number.Items.AddRange(_cityManager.GetPublicTransportNumbers());
		}

		private void button_DeletePublicTransport_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.DeletePublicTransport(input_DeletePublicTransport_Number.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		private void input_DeletePublicTransportStop_TransportNumber_Click(object sender, EventArgs e)
		{
			input_DeletePublicTransportStop_TransportNumber.Items.Clear();
			input_DeletePublicTransportStop_TransportNumber.Items.AddRange(_cityManager.GetPublicTransportNumbers());
		}

		private void input_DeletePublicTransportStop_Adress_Click(object sender, EventArgs e)
		{
			input_DeletePublicTransportStop_Adress.Items.Clear();
			input_DeletePublicTransportStop_Adress.Items.AddRange(
				_cityManager.GetPublicTransport(input_DeletePublicTransportStop_TransportNumber.Text).GetAdresses());
		}

		private void button_DeletePublicTransportStop_Click(object sender, EventArgs e)
		{
			try
			{
				_cityManager.DeletePublicTransportStop(input_DeletePublicTransportStop_TransportNumber.Text,
													   input_DeletePublicTransportStop_Adress.Text);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

		#endregion
	}
}
