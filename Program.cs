using System;
using System.Windows.Forms;

namespace City_Map
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new CityMap());
		}
	}
}

/*
	Необходимо создать систему для создания, просмотра и модификации карты города. На карте могут быть следующие объекты:
	улицы ( названия ), дома ( номера ), метро ( название ), магазины(название ), театры(
	название ), маршруты транспорта ( автобусы, трамваи, троллейбусы).
	Система должна быть разделена на две части - редактор и просмотрщик.
	В программе редактора можно создавать, модифицировать, загружать и сохранять карты.
	При просмотре должны быть доступны функции поиска объектов.
*/