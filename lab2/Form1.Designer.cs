namespace lab2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDollar = new System.Windows.Forms.NumericUpDown();
            this.inputEuro = new System.Windows.Forms.NumericUpDown();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Location = new System.Drawing.Point(75, 46);
            this.DollarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(59, 17);
            this.DollarLabel.TabIndex = 0;
            this.DollarLabel.Text = "Доллар";
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Location = new System.Drawing.Point(93, 81);
            this.EuroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(40, 17);
            this.EuroLabel.TabIndex = 1;
            this.EuroLabel.Text = "Евро";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена валют(в рублях):";
            // 
            // inputDollar
            // 
            this.inputDollar.DecimalPlaces = 2;
            this.inputDollar.Location = new System.Drawing.Point(144, 46);
            this.inputDollar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputDollar.Name = "inputDollar";
            this.inputDollar.Size = new System.Drawing.Size(160, 22);
            this.inputDollar.TabIndex = 3;
            this.inputDollar.Value = new decimal(new int[] {
            9075,
            0,
            0,
            131072});
            // 
            // inputEuro
            // 
            this.inputEuro.DecimalPlaces = 2;
            this.inputEuro.Location = new System.Drawing.Point(144, 81);
            this.inputEuro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputEuro.Name = "inputEuro";
            this.inputEuro.Size = new System.Drawing.Size(160, 22);
            this.inputEuro.TabIndex = 4;
            this.inputEuro.Value = new decimal(new int[] {
            9888,
            0,
            0,
            131072});
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(328, 46);
            this.StartStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(175, 60);
            this.StartStopButton.TabIndex = 5;
            this.StartStopButton.Text = "Старт/Стоп";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(47, 133);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Доллар";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Евро";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(961, 369);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.inputEuro);
            this.Controls.Add(this.inputDollar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.DollarLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Exchange Rates";
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputDollar;
        private System.Windows.Forms.NumericUpDown inputEuro;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
    }
}

