namespace City_Map
{
	partial class CityMap
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityMap));
			this.Button_CityViewer = new System.Windows.Forms.Button();
			this.Button_CityEditor = new System.Windows.Forms.Button();
			this.Button_LoadCityMap = new System.Windows.Forms.Button();
			this.Button_SaveCityMap = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button_CityViewer
			// 
			this.Button_CityViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button_CityViewer.Location = new System.Drawing.Point(70, 50);
			this.Button_CityViewer.Name = "Button_CityViewer";
			this.Button_CityViewer.Size = new System.Drawing.Size(250, 60);
			this.Button_CityViewer.TabIndex = 0;
			this.Button_CityViewer.Text = "Просмотрщик карты";
			this.Button_CityViewer.UseVisualStyleBackColor = true;
			this.Button_CityViewer.Click += new System.EventHandler(this.Button_CityViewer_Click);
			// 
			// Button_CityEditor
			// 
			this.Button_CityEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button_CityEditor.Location = new System.Drawing.Point(70, 150);
			this.Button_CityEditor.Name = "Button_CityEditor";
			this.Button_CityEditor.Size = new System.Drawing.Size(250, 60);
			this.Button_CityEditor.TabIndex = 1;
			this.Button_CityEditor.Text = "Редактор карты";
			this.Button_CityEditor.UseVisualStyleBackColor = true;
			this.Button_CityEditor.Click += new System.EventHandler(this.Button_CityEditor_Click);
			// 
			// Button_LoadCityMap
			// 
			this.Button_LoadCityMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button_LoadCityMap.Location = new System.Drawing.Point(70, 250);
			this.Button_LoadCityMap.Name = "Button_LoadCityMap";
			this.Button_LoadCityMap.Size = new System.Drawing.Size(250, 60);
			this.Button_LoadCityMap.TabIndex = 2;
			this.Button_LoadCityMap.Text = "Загрузить карту";
			this.Button_LoadCityMap.UseVisualStyleBackColor = true;
			this.Button_LoadCityMap.Click += new System.EventHandler(this.Button_LoadCityMap_Click);
			// 
			// Button_SaveCityMap
			// 
			this.Button_SaveCityMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Button_SaveCityMap.Location = new System.Drawing.Point(70, 350);
			this.Button_SaveCityMap.Name = "Button_SaveCityMap";
			this.Button_SaveCityMap.Size = new System.Drawing.Size(250, 60);
			this.Button_SaveCityMap.TabIndex = 3;
			this.Button_SaveCityMap.Text = "Сохранить карту";
			this.Button_SaveCityMap.UseVisualStyleBackColor = true;
			this.Button_SaveCityMap.Click += new System.EventHandler(this.Button_SaveCityMap_Click);
			// 
			// CityMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(372, 463);
			this.Controls.Add(this.Button_SaveCityMap);
			this.Controls.Add(this.Button_LoadCityMap);
			this.Controls.Add(this.Button_CityEditor);
			this.Controls.Add(this.Button_CityViewer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CityMap";
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Карта города";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button_CityViewer;
		private System.Windows.Forms.Button Button_CityEditor;
		private System.Windows.Forms.Button Button_LoadCityMap;
		private System.Windows.Forms.Button Button_SaveCityMap;
	}
}

