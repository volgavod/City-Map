using System;
using System.IO;
using System.Windows.Forms;

namespace City_Map
{
	public partial class CityMap : Form
	{
		private CityManager _cityManager = new CityManager();
		private CityEditor _cityEditor;
		private CityViewer _cityViewer;

		public CityMap()
		{
			InitializeComponent();
		}

		private void Button_CityViewer_Click(object sender, EventArgs e)
		{
			if (_cityViewer is null || _cityViewer.IsDisposed)
			{
				_cityViewer = new CityViewer(_cityManager);
				_cityViewer.Show();
			}
			else
				_cityViewer.Activate();
		}

		private void Button_CityEditor_Click(object sender, EventArgs e)
		{
			if (_cityEditor is null || _cityEditor.IsDisposed)
			{
				_cityEditor = new CityEditor(_cityManager);
				_cityEditor.Show();
			}
			else
				_cityEditor.Activate();
		}

		private void Button_LoadCityMap_Click(object sender, EventArgs e)
		{
			string unloadedBuildings = "";
			try
			{
				_cityManager.LoadBuildings(CityDataLoader.LoadBuildings(out int totalNotesOfBuildings, out int errorNotesOfBuildings));
				unloadedBuildings = errorNotesOfBuildings + "/" + totalNotesOfBuildings;
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}

			string unloadedMetroStations = "";
			try
			{
				_cityManager.LoadMetro(CityDataLoader.LoadMetro(out int totalNotesOfMetro, out int errorNotesOfMetro));
				unloadedMetroStations = errorNotesOfMetro + "/" + totalNotesOfMetro;
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}

			string unloadedPublicTransport = "";
			try
			{
				_cityManager.LoadPublicTransport(CityDataLoader.LoadPublicTransport(out int totalNotesOfPublicTransport, out int errorNotesOfPublicTransport));
				unloadedPublicTransport = errorNotesOfPublicTransport + "/" + totalNotesOfPublicTransport;
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}

			MessageBox.Show("Карта была загружена\n" +
				$"Не загружено записей о зданиях: {unloadedBuildings}\n" +
				$"Не загружено записей о зданиях: {unloadedMetroStations}\n" +
				$"Не загружено записей о зданиях: {unloadedPublicTransport}");
		}

		private void Button_SaveCityMap_Click(object sender, EventArgs e)
		{
			CityDataSaver.SaveMap(_cityManager);
			MessageBox.Show("Карта успешно сохранена\n" + Directory.GetCurrentDirectory() + @"\City Data");
		}
	}
}
