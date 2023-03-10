namespace City_Map
{
	partial class CityViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityViewer));
			this.gb_PublicTransportRoutes_Viewer = new System.Windows.Forms.GroupBox();
			this.output_PublicTransportRoutes = new System.Windows.Forms.RichTextBox();
			this.button_GetRouteNumbersByPublicTransportType = new System.Windows.Forms.Button();
			this.lb_GetStopAdressesByRouteNumber = new System.Windows.Forms.Label();
			this.button_GetStopAdressesByRouteNumber = new System.Windows.Forms.Button();
			this.input_GetRouteNumbersByPublicTransportType = new System.Windows.Forms.ComboBox();
			this.lb_GetRouteNumbersByPublicTransportType = new System.Windows.Forms.Label();
			this.input_GetStopAdressesByRouteNumber = new System.Windows.Forms.ComboBox();
			this.gb_Metro_Viewer = new System.Windows.Forms.GroupBox();
			this.output_Metro = new System.Windows.Forms.RichTextBox();
			this.button_GetMetroStationsAmount = new System.Windows.Forms.Button();
			this.lb_GetMetroStationsNamesByLineNumber = new System.Windows.Forms.Label();
			this.input_GetMetroStationsAmount = new System.Windows.Forms.ComboBox();
			this.input_GetMetroStationsNamesByLineNumber = new System.Windows.Forms.ComboBox();
			this.lb_GetMetroStationsAmount = new System.Windows.Forms.Label();
			this.button_GetMetroStationsNamesByLineNumber = new System.Windows.Forms.Button();
			this.gb_Buildings_Viewer = new System.Windows.Forms.GroupBox();
			this.output_Buildings = new System.Windows.Forms.RichTextBox();
			this.button_GetBuildingsByType = new System.Windows.Forms.Button();
			this.input_GetBuildingsByType = new System.Windows.Forms.ComboBox();
			this.lb_GetBuildingsByType = new System.Windows.Forms.Label();
			this.button_GetBuildingsByStreet = new System.Windows.Forms.Button();
			this.input_GetBuildingsByStreet = new System.Windows.Forms.ComboBox();
			this.lb_GetBuildingsByStreet = new System.Windows.Forms.Label();
			this.gb_PublicTransportRoutes_Viewer.SuspendLayout();
			this.gb_Metro_Viewer.SuspendLayout();
			this.gb_Buildings_Viewer.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_PublicTransportRoutes_Viewer
			// 
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.output_PublicTransportRoutes);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.button_GetRouteNumbersByPublicTransportType);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.lb_GetStopAdressesByRouteNumber);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.button_GetStopAdressesByRouteNumber);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.input_GetRouteNumbersByPublicTransportType);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.lb_GetRouteNumbersByPublicTransportType);
			this.gb_PublicTransportRoutes_Viewer.Controls.Add(this.input_GetStopAdressesByRouteNumber);
			this.gb_PublicTransportRoutes_Viewer.Location = new System.Drawing.Point(12, 506);
			this.gb_PublicTransportRoutes_Viewer.Name = "gb_PublicTransportRoutes_Viewer";
			this.gb_PublicTransportRoutes_Viewer.Size = new System.Drawing.Size(665, 238);
			this.gb_PublicTransportRoutes_Viewer.TabIndex = 2;
			this.gb_PublicTransportRoutes_Viewer.TabStop = false;
			this.gb_PublicTransportRoutes_Viewer.Text = "Маршрутов общественного транспорта";
			// 
			// output_PublicTransportRoutes
			// 
			this.output_PublicTransportRoutes.BackColor = System.Drawing.Color.White;
			this.output_PublicTransportRoutes.Location = new System.Drawing.Point(10, 96);
			this.output_PublicTransportRoutes.Name = "output_PublicTransportRoutes";
			this.output_PublicTransportRoutes.ReadOnly = true;
			this.output_PublicTransportRoutes.Size = new System.Drawing.Size(647, 134);
			this.output_PublicTransportRoutes.TabIndex = 28;
			this.output_PublicTransportRoutes.Text = "";
			// 
			// button_GetRouteNumbersByPublicTransportType
			// 
			this.button_GetRouteNumbersByPublicTransportType.Location = new System.Drawing.Point(355, 67);
			this.button_GetRouteNumbersByPublicTransportType.Name = "button_GetRouteNumbersByPublicTransportType";
			this.button_GetRouteNumbersByPublicTransportType.Size = new System.Drawing.Size(110, 23);
			this.button_GetRouteNumbersByPublicTransportType.TabIndex = 33;
			this.button_GetRouteNumbersByPublicTransportType.Text = "Получить";
			this.button_GetRouteNumbersByPublicTransportType.UseVisualStyleBackColor = true;
			this.button_GetRouteNumbersByPublicTransportType.Click += new System.EventHandler(this.button_GetRouteNumbersByPublicTransportType_Click);
			// 
			// lb_GetStopAdressesByRouteNumber
			// 
			this.lb_GetStopAdressesByRouteNumber.AutoSize = true;
			this.lb_GetStopAdressesByRouteNumber.Location = new System.Drawing.Point(7, 18);
			this.lb_GetStopAdressesByRouteNumber.Name = "lb_GetStopAdressesByRouteNumber";
			this.lb_GetStopAdressesByRouteNumber.Size = new System.Drawing.Size(304, 16);
			this.lb_GetStopAdressesByRouteNumber.TabIndex = 28;
			this.lb_GetStopAdressesByRouteNumber.Text = "Получить адреса остановок по номеру марш.";
			// 
			// button_GetStopAdressesByRouteNumber
			// 
			this.button_GetStopAdressesByRouteNumber.Location = new System.Drawing.Point(10, 67);
			this.button_GetStopAdressesByRouteNumber.Name = "button_GetStopAdressesByRouteNumber";
			this.button_GetStopAdressesByRouteNumber.Size = new System.Drawing.Size(110, 23);
			this.button_GetStopAdressesByRouteNumber.TabIndex = 30;
			this.button_GetStopAdressesByRouteNumber.Text = "Получить";
			this.button_GetStopAdressesByRouteNumber.UseVisualStyleBackColor = true;
			this.button_GetStopAdressesByRouteNumber.Click += new System.EventHandler(this.button_GetStopAdressesByRouteNumber_Click);
			// 
			// input_GetRouteNumbersByPublicTransportType
			// 
			this.input_GetRouteNumbersByPublicTransportType.FormattingEnabled = true;
			this.input_GetRouteNumbersByPublicTransportType.Items.AddRange(new object[] {
            "Автобус",
            "Трамвай",
            "Троллейбус"});
			this.input_GetRouteNumbersByPublicTransportType.Location = new System.Drawing.Point(355, 37);
			this.input_GetRouteNumbersByPublicTransportType.Name = "input_GetRouteNumbersByPublicTransportType";
			this.input_GetRouteNumbersByPublicTransportType.Size = new System.Drawing.Size(302, 24);
			this.input_GetRouteNumbersByPublicTransportType.TabIndex = 32;
			this.input_GetRouteNumbersByPublicTransportType.Text = "Автобус";
			// 
			// lb_GetRouteNumbersByPublicTransportType
			// 
			this.lb_GetRouteNumbersByPublicTransportType.AutoSize = true;
			this.lb_GetRouteNumbersByPublicTransportType.Location = new System.Drawing.Point(352, 18);
			this.lb_GetRouteNumbersByPublicTransportType.Name = "lb_GetRouteNumbersByPublicTransportType";
			this.lb_GetRouteNumbersByPublicTransportType.Size = new System.Drawing.Size(296, 16);
			this.lb_GetRouteNumbersByPublicTransportType.TabIndex = 31;
			this.lb_GetRouteNumbersByPublicTransportType.Text = "Получить номера марш. по типу транспорта";
			// 
			// input_GetStopAdressesByRouteNumber
			// 
			this.input_GetStopAdressesByRouteNumber.FormattingEnabled = true;
			this.input_GetStopAdressesByRouteNumber.Location = new System.Drawing.Point(10, 37);
			this.input_GetStopAdressesByRouteNumber.Name = "input_GetStopAdressesByRouteNumber";
			this.input_GetStopAdressesByRouteNumber.Size = new System.Drawing.Size(302, 24);
			this.input_GetStopAdressesByRouteNumber.TabIndex = 29;
			this.input_GetStopAdressesByRouteNumber.Click += new System.EventHandler(this.input_GetStopAdressesByRouteNumber_Click);
			// 
			// gb_Metro_Viewer
			// 
			this.gb_Metro_Viewer.Controls.Add(this.output_Metro);
			this.gb_Metro_Viewer.Controls.Add(this.button_GetMetroStationsAmount);
			this.gb_Metro_Viewer.Controls.Add(this.lb_GetMetroStationsNamesByLineNumber);
			this.gb_Metro_Viewer.Controls.Add(this.input_GetMetroStationsAmount);
			this.gb_Metro_Viewer.Controls.Add(this.input_GetMetroStationsNamesByLineNumber);
			this.gb_Metro_Viewer.Controls.Add(this.lb_GetMetroStationsAmount);
			this.gb_Metro_Viewer.Controls.Add(this.button_GetMetroStationsNamesByLineNumber);
			this.gb_Metro_Viewer.Location = new System.Drawing.Point(12, 262);
			this.gb_Metro_Viewer.Name = "gb_Metro_Viewer";
			this.gb_Metro_Viewer.Size = new System.Drawing.Size(665, 238);
			this.gb_Metro_Viewer.TabIndex = 1;
			this.gb_Metro_Viewer.TabStop = false;
			this.gb_Metro_Viewer.Text = "Метро";
			// 
			// output_Metro
			// 
			this.output_Metro.BackColor = System.Drawing.Color.White;
			this.output_Metro.Location = new System.Drawing.Point(10, 96);
			this.output_Metro.Name = "output_Metro";
			this.output_Metro.ReadOnly = true;
			this.output_Metro.Size = new System.Drawing.Size(647, 134);
			this.output_Metro.TabIndex = 22;
			this.output_Metro.Text = "";
			// 
			// button_GetMetroStationsAmount
			// 
			this.button_GetMetroStationsAmount.Location = new System.Drawing.Point(355, 67);
			this.button_GetMetroStationsAmount.Name = "button_GetMetroStationsAmount";
			this.button_GetMetroStationsAmount.Size = new System.Drawing.Size(110, 23);
			this.button_GetMetroStationsAmount.TabIndex = 27;
			this.button_GetMetroStationsAmount.Text = "Получить";
			this.button_GetMetroStationsAmount.UseVisualStyleBackColor = true;
			this.button_GetMetroStationsAmount.Click += new System.EventHandler(this.button_GetMetroStationsAmount_Click);
			// 
			// lb_GetMetroStationsNamesByLineNumber
			// 
			this.lb_GetMetroStationsNamesByLineNumber.AutoSize = true;
			this.lb_GetMetroStationsNamesByLineNumber.Location = new System.Drawing.Point(7, 18);
			this.lb_GetMetroStationsNamesByLineNumber.Name = "lb_GetMetroStationsNamesByLineNumber";
			this.lb_GetMetroStationsNamesByLineNumber.Size = new System.Drawing.Size(308, 16);
			this.lb_GetMetroStationsNamesByLineNumber.TabIndex = 22;
			this.lb_GetMetroStationsNamesByLineNumber.Text = "Получить названия станций по номеру линии";
			// 
			// input_GetMetroStationsAmount
			// 
			this.input_GetMetroStationsAmount.FormattingEnabled = true;
			this.input_GetMetroStationsAmount.Location = new System.Drawing.Point(355, 37);
			this.input_GetMetroStationsAmount.Name = "input_GetMetroStationsAmount";
			this.input_GetMetroStationsAmount.Size = new System.Drawing.Size(302, 24);
			this.input_GetMetroStationsAmount.TabIndex = 26;
			this.input_GetMetroStationsAmount.Click += new System.EventHandler(this.input_GetMetroStationsAmount_Click);
			// 
			// input_GetMetroStationsNamesByLineNumber
			// 
			this.input_GetMetroStationsNamesByLineNumber.FormattingEnabled = true;
			this.input_GetMetroStationsNamesByLineNumber.Location = new System.Drawing.Point(10, 37);
			this.input_GetMetroStationsNamesByLineNumber.Name = "input_GetMetroStationsNamesByLineNumber";
			this.input_GetMetroStationsNamesByLineNumber.Size = new System.Drawing.Size(302, 24);
			this.input_GetMetroStationsNamesByLineNumber.TabIndex = 23;
			this.input_GetMetroStationsNamesByLineNumber.Click += new System.EventHandler(this.input_GetMetroStationsNamesByLineNumber_Click);
			// 
			// lb_GetMetroStationsAmount
			// 
			this.lb_GetMetroStationsAmount.AutoSize = true;
			this.lb_GetMetroStationsAmount.Location = new System.Drawing.Point(352, 18);
			this.lb_GetMetroStationsAmount.Name = "lb_GetMetroStationsAmount";
			this.lb_GetMetroStationsAmount.Size = new System.Drawing.Size(270, 16);
			this.lb_GetMetroStationsAmount.TabIndex = 25;
			this.lb_GetMetroStationsAmount.Text = "Получить количество станций на линии";
			// 
			// button_GetMetroStationsNamesByLineNumber
			// 
			this.button_GetMetroStationsNamesByLineNumber.Location = new System.Drawing.Point(10, 67);
			this.button_GetMetroStationsNamesByLineNumber.Name = "button_GetMetroStationsNamesByLineNumber";
			this.button_GetMetroStationsNamesByLineNumber.Size = new System.Drawing.Size(110, 23);
			this.button_GetMetroStationsNamesByLineNumber.TabIndex = 24;
			this.button_GetMetroStationsNamesByLineNumber.Text = "Получить";
			this.button_GetMetroStationsNamesByLineNumber.UseVisualStyleBackColor = true;
			this.button_GetMetroStationsNamesByLineNumber.Click += new System.EventHandler(this.button_GetMetroStationsNamesByLineNumber_Click);
			// 
			// gb_Buildings_Viewer
			// 
			this.gb_Buildings_Viewer.Controls.Add(this.output_Buildings);
			this.gb_Buildings_Viewer.Controls.Add(this.button_GetBuildingsByType);
			this.gb_Buildings_Viewer.Controls.Add(this.input_GetBuildingsByType);
			this.gb_Buildings_Viewer.Controls.Add(this.lb_GetBuildingsByType);
			this.gb_Buildings_Viewer.Controls.Add(this.button_GetBuildingsByStreet);
			this.gb_Buildings_Viewer.Controls.Add(this.input_GetBuildingsByStreet);
			this.gb_Buildings_Viewer.Controls.Add(this.lb_GetBuildingsByStreet);
			this.gb_Buildings_Viewer.Location = new System.Drawing.Point(12, 12);
			this.gb_Buildings_Viewer.Name = "gb_Buildings_Viewer";
			this.gb_Buildings_Viewer.Size = new System.Drawing.Size(665, 244);
			this.gb_Buildings_Viewer.TabIndex = 0;
			this.gb_Buildings_Viewer.TabStop = false;
			this.gb_Buildings_Viewer.Text = "Зданий";
			// 
			// output_Buildings
			// 
			this.output_Buildings.BackColor = System.Drawing.Color.White;
			this.output_Buildings.Location = new System.Drawing.Point(10, 103);
			this.output_Buildings.Name = "output_Buildings";
			this.output_Buildings.ReadOnly = true;
			this.output_Buildings.Size = new System.Drawing.Size(647, 134);
			this.output_Buildings.TabIndex = 21;
			this.output_Buildings.Text = "";
			// 
			// button_GetBuildingsByType
			// 
			this.button_GetBuildingsByType.Location = new System.Drawing.Point(355, 71);
			this.button_GetBuildingsByType.Name = "button_GetBuildingsByType";
			this.button_GetBuildingsByType.Size = new System.Drawing.Size(110, 23);
			this.button_GetBuildingsByType.TabIndex = 20;
			this.button_GetBuildingsByType.Text = "Получить";
			this.button_GetBuildingsByType.UseVisualStyleBackColor = true;
			this.button_GetBuildingsByType.Click += new System.EventHandler(this.button_GetBuildingsByType_Click);
			// 
			// input_GetBuildingsByType
			// 
			this.input_GetBuildingsByType.FormattingEnabled = true;
			this.input_GetBuildingsByType.Items.AddRange(new object[] {
            "Театр",
            "Магазин",
            "Жилой дом"});
			this.input_GetBuildingsByType.Location = new System.Drawing.Point(355, 41);
			this.input_GetBuildingsByType.Name = "input_GetBuildingsByType";
			this.input_GetBuildingsByType.Size = new System.Drawing.Size(302, 24);
			this.input_GetBuildingsByType.TabIndex = 19;
			this.input_GetBuildingsByType.Text = "Жилой дом";
			// 
			// lb_GetBuildingsByType
			// 
			this.lb_GetBuildingsByType.AutoSize = true;
			this.lb_GetBuildingsByType.Location = new System.Drawing.Point(352, 22);
			this.lb_GetBuildingsByType.Name = "lb_GetBuildingsByType";
			this.lb_GetBuildingsByType.Size = new System.Drawing.Size(191, 16);
			this.lb_GetBuildingsByType.TabIndex = 18;
			this.lb_GetBuildingsByType.Text = "Получить здания по их типу\r\n";
			// 
			// button_GetBuildingsByStreet
			// 
			this.button_GetBuildingsByStreet.Location = new System.Drawing.Point(10, 71);
			this.button_GetBuildingsByStreet.Name = "button_GetBuildingsByStreet";
			this.button_GetBuildingsByStreet.Size = new System.Drawing.Size(110, 23);
			this.button_GetBuildingsByStreet.TabIndex = 17;
			this.button_GetBuildingsByStreet.Text = "Получить";
			this.button_GetBuildingsByStreet.UseVisualStyleBackColor = true;
			this.button_GetBuildingsByStreet.Click += new System.EventHandler(this.button_GetBuildingsByStreet_Click);
			// 
			// input_GetBuildingsByStreet
			// 
			this.input_GetBuildingsByStreet.FormattingEnabled = true;
			this.input_GetBuildingsByStreet.Location = new System.Drawing.Point(10, 41);
			this.input_GetBuildingsByStreet.Name = "input_GetBuildingsByStreet";
			this.input_GetBuildingsByStreet.Size = new System.Drawing.Size(302, 24);
			this.input_GetBuildingsByStreet.TabIndex = 1;
			this.input_GetBuildingsByStreet.Click += new System.EventHandler(this.input_GetBuildingsByStreet_Click);
			// 
			// lb_GetBuildingsByStreet
			// 
			this.lb_GetBuildingsByStreet.AutoSize = true;
			this.lb_GetBuildingsByStreet.Location = new System.Drawing.Point(7, 22);
			this.lb_GetBuildingsByStreet.Name = "lb_GetBuildingsByStreet";
			this.lb_GetBuildingsByStreet.Size = new System.Drawing.Size(253, 16);
			this.lb_GetBuildingsByStreet.TabIndex = 0;
			this.lb_GetBuildingsByStreet.Text = "Получить здания по названию улицы\r\n";
			// 
			// CityViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(690, 755);
			this.Controls.Add(this.gb_PublicTransportRoutes_Viewer);
			this.Controls.Add(this.gb_Metro_Viewer);
			this.Controls.Add(this.gb_Buildings_Viewer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CityViewer";
			this.Text = "Просмотрщик";
			this.gb_PublicTransportRoutes_Viewer.ResumeLayout(false);
			this.gb_PublicTransportRoutes_Viewer.PerformLayout();
			this.gb_Metro_Viewer.ResumeLayout(false);
			this.gb_Metro_Viewer.PerformLayout();
			this.gb_Buildings_Viewer.ResumeLayout(false);
			this.gb_Buildings_Viewer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_Metro_Viewer;
		private System.Windows.Forms.RichTextBox output_Metro;
		private System.Windows.Forms.Label lb_GetBuildingsByType;
		private System.Windows.Forms.GroupBox gb_Buildings_Viewer;
		private System.Windows.Forms.RichTextBox output_Buildings;
		private System.Windows.Forms.Label lb_GetBuildingsByStreet;
		private System.Windows.Forms.Label lb_GetMetroStationsAmount;
		private System.Windows.Forms.Button button_GetBuildingsByType;
		private System.Windows.Forms.ComboBox input_GetBuildingsByType;
		private System.Windows.Forms.Button button_GetBuildingsByStreet;
		private System.Windows.Forms.ComboBox input_GetBuildingsByStreet;
		private System.Windows.Forms.Button button_GetMetroStationsAmount;
		private System.Windows.Forms.Label lb_GetStopAdressesByRouteNumber;
		private System.Windows.Forms.ComboBox input_GetMetroStationsAmount;
		private System.Windows.Forms.GroupBox gb_PublicTransportRoutes_Viewer;
		private System.Windows.Forms.RichTextBox output_PublicTransportRoutes;
		private System.Windows.Forms.Label lb_GetMetroStationsNamesByLineNumber;
		private System.Windows.Forms.Button button_GetStopAdressesByRouteNumber;
		private System.Windows.Forms.ComboBox input_GetStopAdressesByRouteNumber;
		private System.Windows.Forms.Label lb_GetRouteNumbersByPublicTransportType;
		private System.Windows.Forms.Button button_GetMetroStationsNamesByLineNumber;
		private System.Windows.Forms.ComboBox input_GetMetroStationsNamesByLineNumber;
		private System.Windows.Forms.Button button_GetRouteNumbersByPublicTransportType;
		private System.Windows.Forms.ComboBox input_GetRouteNumbersByPublicTransportType;
	}
}