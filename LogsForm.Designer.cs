namespace TuringMachineForm
{
    partial class LogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsForm));
            this.BigTextBox = new System.Windows.Forms.TextBox();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BigTextBox
            // 
            this.BigTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigTextBox.Location = new System.Drawing.Point(12, 12);
            this.BigTextBox.Multiline = true;
            this.BigTextBox.Name = "BigTextBox";
            this.BigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BigTextBox.Size = new System.Drawing.Size(778, 429);
            this.BigTextBox.TabIndex = 0;
            this.BigTextBox.WordWrap = false;
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Location = new System.Drawing.Point(685, 16);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveInFileButton.TabIndex = 1;
            this.SaveInFileButton.Text = "В файл";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            this.SaveInFileButton.Click += new System.EventHandler(this.SaveInFileButton_Click);
            // 
            // LogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.SaveInFileButton);
            this.Controls.Add(this.BigTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogsForm";
            this.Text = "LogsForm";
            this.ClientSizeChanged += new System.EventHandler(this.LogsForm_ClientSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BigTextBox;
        private System.Windows.Forms.Button SaveInFileButton;
    }
}