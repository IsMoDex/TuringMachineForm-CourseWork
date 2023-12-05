namespace TuringMachineForm
{
    partial class ChartMT
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartMT));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartOrStopButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.алфавитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алфавитToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оповещенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оповещятьОбОшибкаххToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 27);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.MarkerBorderWidth = 3;
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(808, 464);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // StartOrStopButton
            // 
            this.StartOrStopButton.AutoSize = true;
            this.StartOrStopButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartOrStopButton.Location = new System.Drawing.Point(685, 12);
            this.StartOrStopButton.Name = "StartOrStopButton";
            this.StartOrStopButton.Size = new System.Drawing.Size(135, 36);
            this.StartOrStopButton.TabIndex = 1;
            this.StartOrStopButton.Text = "Отрисовать";
            this.StartOrStopButton.UseVisualStyleBackColor = true;
            this.StartOrStopButton.Click += new System.EventHandler(this.StartOrStopButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алфавитToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // алфавитToolStripMenuItem
            // 
            this.алфавитToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алфавитToolStripMenuItem1,
            this.startStopToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.алфавитToolStripMenuItem.Name = "алфавитToolStripMenuItem";
            this.алфавитToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.алфавитToolStripMenuItem.Text = "График";
            // 
            // алфавитToolStripMenuItem1
            // 
            this.алфавитToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактироватьToolStripMenuItem});
            this.алфавитToolStripMenuItem1.Name = "алфавитToolStripMenuItem1";
            this.алфавитToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.алфавитToolStripMenuItem1.Text = "Алфавит";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // startStopToolStripMenuItem
            // 
            this.startStopToolStripMenuItem.Name = "startStopToolStripMenuItem";
            this.startStopToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.startStopToolStripMenuItem.Text = "Отрисовать";
            this.startStopToolStripMenuItem.Click += new System.EventHandler(this.startStopToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оповещенияToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // оповещенияToolStripMenuItem
            // 
            this.оповещенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оповещятьОбОшибкаххToolStripMenuItem});
            this.оповещенияToolStripMenuItem.Name = "оповещенияToolStripMenuItem";
            this.оповещенияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оповещенияToolStripMenuItem.Text = "Оповещения";
            // 
            // оповещятьОбОшибкаххToolStripMenuItem
            // 
            this.оповещятьОбОшибкаххToolStripMenuItem.Name = "оповещятьОбОшибкаххToolStripMenuItem";
            this.оповещятьОбОшибкаххToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.оповещятьОбОшибкаххToolStripMenuItem.Text = "Оповещять об ошибках";
            this.оповещятьОбОшибкаххToolStripMenuItem.Click += new System.EventHandler(this.оповещятьОбОшибкаххToolStripMenuItem_Click);
            // 
            // ChartMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.StartOrStopButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartMT";
            this.Text = "График одноленточной Машины Тьюринга";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.setFormClosing);
            this.Load += new System.EventHandler(this.ChartMT_Load);
            this.ClientSizeChanged += new System.EventHandler(this.ChartMT_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button StartOrStopButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem алфавитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алфавитToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оповещенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оповещятьОбОшибкаххToolStripMenuItem;
    }
}