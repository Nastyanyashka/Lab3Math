﻿namespace Lab3Math
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.EquationPow4 = new System.Windows.Forms.RadioButton();
            this.xPow1 = new System.Windows.Forms.TextBox();
            this.xPow3 = new System.Windows.Forms.TextBox();
            this.xPow0 = new System.Windows.Forms.TextBox();
            this.xPow2 = new System.Windows.Forms.TextBox();
            this.xPow4 = new System.Windows.Forms.TextBox();
            this.powTextBox = new System.Windows.Forms.TextBox();
            this.leastSquaresButton = new System.Windows.Forms.RadioButton();
            this.newtonButton = new System.Windows.Forms.RadioButton();
            this.lagrangeButton = new System.Windows.Forms.RadioButton();
            this.SplineButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(659, 425);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(707, 125);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.SplineButton);
            this.groupbox1.Controls.Add(this.EquationPow4);
            this.groupbox1.Controls.Add(this.xPow1);
            this.groupbox1.Controls.Add(this.xPow3);
            this.groupbox1.Controls.Add(this.xPow0);
            this.groupbox1.Controls.Add(this.xPow2);
            this.groupbox1.Controls.Add(this.xPow4);
            this.groupbox1.Controls.Add(this.powTextBox);
            this.groupbox1.Controls.Add(this.leastSquaresButton);
            this.groupbox1.Controls.Add(this.newtonButton);
            this.groupbox1.Controls.Add(this.lagrangeButton);
            this.groupbox1.Location = new System.Drawing.Point(698, 25);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(310, 219);
            this.groupbox1.TabIndex = 2;
            this.groupbox1.TabStop = false;
            // 
            // EquationPow4
            // 
            this.EquationPow4.AutoSize = true;
            this.EquationPow4.Location = new System.Drawing.Point(6, 129);
            this.EquationPow4.Name = "EquationPow4";
            this.EquationPow4.Size = new System.Drawing.Size(275, 17);
            this.EquationPow4.TabIndex = 11;
            this.EquationPow4.TabStop = true;
            this.EquationPow4.Text = "График по произвольному многочлену 4 степени";
            this.EquationPow4.UseVisualStyleBackColor = true;
            // 
            // xPow1
            // 
            this.xPow1.Location = new System.Drawing.Point(174, 161);
            this.xPow1.Name = "xPow1";
            this.xPow1.Size = new System.Drawing.Size(50, 20);
            this.xPow1.TabIndex = 10;
            this.xPow1.Text = "x^1";
            // 
            // xPow3
            // 
            this.xPow3.Location = new System.Drawing.Point(62, 161);
            this.xPow3.Name = "xPow3";
            this.xPow3.Size = new System.Drawing.Size(50, 20);
            this.xPow3.TabIndex = 9;
            this.xPow3.Text = "x^3";
            // 
            // xPow0
            // 
            this.xPow0.Location = new System.Drawing.Point(230, 161);
            this.xPow0.Name = "xPow0";
            this.xPow0.Size = new System.Drawing.Size(50, 20);
            this.xPow0.TabIndex = 8;
            this.xPow0.Text = "x^0";
            // 
            // xPow2
            // 
            this.xPow2.Location = new System.Drawing.Point(118, 161);
            this.xPow2.Name = "xPow2";
            this.xPow2.Size = new System.Drawing.Size(50, 20);
            this.xPow2.TabIndex = 7;
            this.xPow2.Text = "x^2";
            // 
            // xPow4
            // 
            this.xPow4.Location = new System.Drawing.Point(6, 161);
            this.xPow4.Name = "xPow4";
            this.xPow4.Size = new System.Drawing.Size(50, 20);
            this.xPow4.TabIndex = 6;
            this.xPow4.Text = "x^4";
            // 
            // powTextBox
            // 
            this.powTextBox.Location = new System.Drawing.Point(6, 103);
            this.powTextBox.Multiline = true;
            this.powTextBox.Name = "powTextBox";
            this.powTextBox.Size = new System.Drawing.Size(100, 20);
            this.powTextBox.TabIndex = 5;
            this.powTextBox.Text = "Степень";
            // 
            // leastSquaresButton
            // 
            this.leastSquaresButton.AutoSize = true;
            this.leastSquaresButton.Location = new System.Drawing.Point(7, 67);
            this.leastSquaresButton.Name = "leastSquaresButton";
            this.leastSquaresButton.Size = new System.Drawing.Size(251, 30);
            this.leastSquaresButton.TabIndex = 4;
            this.leastSquaresButton.TabStop = true;
            this.leastSquaresButton.Text = "График многочлена n-ой степени по методу \r\nнаименьших квадратов";
            this.leastSquaresButton.UseVisualStyleBackColor = true;
            // 
            // newtonButton
            // 
            this.newtonButton.AutoSize = true;
            this.newtonButton.Location = new System.Drawing.Point(7, 44);
            this.newtonButton.Name = "newtonButton";
            this.newtonButton.Size = new System.Drawing.Size(172, 17);
            this.newtonButton.TabIndex = 1;
            this.newtonButton.TabStop = true;
            this.newtonButton.Text = "График по формуле ньютона";
            this.newtonButton.UseVisualStyleBackColor = true;
            // 
            // lagrangeButton
            // 
            this.lagrangeButton.AutoSize = true;
            this.lagrangeButton.Location = new System.Drawing.Point(7, 20);
            this.lagrangeButton.Name = "lagrangeButton";
            this.lagrangeButton.Size = new System.Drawing.Size(178, 17);
            this.lagrangeButton.TabIndex = 0;
            this.lagrangeButton.TabStop = true;
            this.lagrangeButton.Text = "График по формуле лагранжа";
            this.lagrangeButton.UseVisualStyleBackColor = true;
            // 
            // SplineButton
            // 
            this.SplineButton.AutoSize = true;
            this.SplineButton.Location = new System.Drawing.Point(7, 187);
            this.SplineButton.Name = "SplineButton";
            this.SplineButton.Size = new System.Drawing.Size(190, 17);
            this.SplineButton.TabIndex = 12;
            this.SplineButton.TabStop = true;
            this.SplineButton.Text = "График по кубическому сплайну";
            this.SplineButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 608);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.RadioButton newtonButton;
        private System.Windows.Forms.RadioButton lagrangeButton;
        private System.Windows.Forms.RadioButton EquationPow4;
        private System.Windows.Forms.TextBox xPow1;
        private System.Windows.Forms.TextBox xPow3;
        private System.Windows.Forms.TextBox xPow0;
        private System.Windows.Forms.TextBox xPow2;
        private System.Windows.Forms.TextBox xPow4;
        private System.Windows.Forms.TextBox powTextBox;
        private System.Windows.Forms.RadioButton leastSquaresButton;
        private System.Windows.Forms.RadioButton SplineButton;
    }
}

