namespace TuringMachineForm
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.StartOneMTButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartOneMTChartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StartTwoMTButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartTwoMTChartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartOneMTButton
            // 
            this.StartOneMTButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartOneMTButton.Location = new System.Drawing.Point(12, 41);
            this.StartOneMTButton.Name = "StartOneMTButton";
            this.StartOneMTButton.Size = new System.Drawing.Size(225, 100);
            this.StartOneMTButton.TabIndex = 0;
            this.StartOneMTButton.Text = "Одноленточная Машина Тьюринга";
            this.StartOneMTButton.UseVisualStyleBackColor = true;
            this.StartOneMTButton.Click += new System.EventHandler(this.StartOneMTButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "МТ";
            // 
            // StartOneMTChartButton
            // 
            this.StartOneMTChartButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartOneMTChartButton.Location = new System.Drawing.Point(12, 144);
            this.StartOneMTChartButton.Name = "StartOneMTChartButton";
            this.StartOneMTChartButton.Size = new System.Drawing.Size(225, 100);
            this.StartOneMTChartButton.TabIndex = 2;
            this.StartOneMTChartButton.Text = "График МТ";
            this.StartOneMTChartButton.UseVisualStyleBackColor = true;
            this.StartOneMTChartButton.Click += new System.EventHandler(this.StartOneMTChartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ММТ";
            // 
            // StartTwoMTButton
            // 
            this.StartTwoMTButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTwoMTButton.Location = new System.Drawing.Point(259, 41);
            this.StartTwoMTButton.Name = "StartTwoMTButton";
            this.StartTwoMTButton.Size = new System.Drawing.Size(225, 100);
            this.StartTwoMTButton.TabIndex = 4;
            this.StartTwoMTButton.Text = "Двуленточная Машина Тьюринга";
            this.StartTwoMTButton.UseVisualStyleBackColor = true;
            this.StartTwoMTButton.Click += new System.EventHandler(this.StartTwoMTButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(243, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 200);
            this.panel1.TabIndex = 5;
            // 
            // StartTwoMTChartButton
            // 
            this.StartTwoMTChartButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTwoMTChartButton.Location = new System.Drawing.Point(259, 141);
            this.StartTwoMTChartButton.Name = "StartTwoMTChartButton";
            this.StartTwoMTChartButton.Size = new System.Drawing.Size(225, 100);
            this.StartTwoMTChartButton.TabIndex = 6;
            this.StartTwoMTChartButton.Text = "График ММТ";
            this.StartTwoMTChartButton.UseVisualStyleBackColor = true;
            this.StartTwoMTChartButton.Click += new System.EventHandler(this.StartTwoMTChartButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 260);
            this.Controls.Add(this.StartTwoMTChartButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StartTwoMTButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartOneMTChartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartOneMTButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Главное меню К-Р. Панков Пи-21Б";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartOneMTButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartOneMTChartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartTwoMTButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartTwoMTChartButton;
    }
}