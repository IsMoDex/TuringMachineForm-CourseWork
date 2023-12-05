namespace TuringMachineForm
{
    partial class MTForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTForm));
            this.LenaRightButton = new System.Windows.Forms.Button();
            this.LenaLeftButton = new System.Windows.Forms.Button();
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlphabetTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlaceWordButton = new System.Windows.Forms.Button();
            this.PlaceAlphabetButton = new System.Windows.Forms.Button();
            this.ClearLeanButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartMachineButton = new System.Windows.Forms.Button();
            this.NextStepButton = new System.Windows.Forms.Button();
            this.ResetStagesButton = new System.Windows.Forms.Button();
            this.SaveInFileButton = new System.Windows.Forms.Button();
            this.LoadInFileBytton = new System.Windows.Forms.Button();
            this.StatesTable = new System.Windows.Forms.DataGridView();
            this.StateColumnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteLastCondition = new System.Windows.Forms.Button();
            this.ShowLogsMachine = new System.Windows.Forms.Button();
            this.AddnewStateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LenaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StatesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LenaRightButton
            // 
            this.LenaRightButton.Location = new System.Drawing.Point(1262, 12);
            this.LenaRightButton.Name = "LenaRightButton";
            this.LenaRightButton.Size = new System.Drawing.Size(60, 50);
            this.LenaRightButton.TabIndex = 1;
            this.LenaRightButton.Text = ">";
            this.LenaRightButton.UseVisualStyleBackColor = true;
            this.LenaRightButton.Click += new System.EventHandler(this.LenaRightButton_Click);
            // 
            // LenaLeftButton
            // 
            this.LenaLeftButton.Location = new System.Drawing.Point(12, 12);
            this.LenaLeftButton.Name = "LenaLeftButton";
            this.LenaLeftButton.Size = new System.Drawing.Size(60, 50);
            this.LenaLeftButton.TabIndex = 2;
            this.LenaLeftButton.Text = "<";
            this.LenaLeftButton.UseVisualStyleBackColor = true;
            this.LenaLeftButton.Click += new System.EventHandler(this.LenaLeftButton_Click);
            // 
            // WordTextBox
            // 
            this.WordTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextBox.Location = new System.Drawing.Point(95, 78);
            this.WordTextBox.Multiline = true;
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(225, 35);
            this.WordTextBox.TabIndex = 3;
            this.WordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WordTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Слово:";
            // 
            // AlphabetTextField
            // 
            this.AlphabetTextField.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetTextField.Location = new System.Drawing.Point(120, 119);
            this.AlphabetTextField.Multiline = true;
            this.AlphabetTextField.Name = "AlphabetTextField";
            this.AlphabetTextField.Size = new System.Drawing.Size(200, 35);
            this.AlphabetTextField.TabIndex = 5;
            this.AlphabetTextField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphabetTextField_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Алфавит:";
            // 
            // PlaceWordButton
            // 
            this.PlaceWordButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceWordButton.Location = new System.Drawing.Point(326, 78);
            this.PlaceWordButton.Name = "PlaceWordButton";
            this.PlaceWordButton.Size = new System.Drawing.Size(144, 35);
            this.PlaceWordButton.TabIndex = 7;
            this.PlaceWordButton.Text = "Поместить";
            this.PlaceWordButton.UseVisualStyleBackColor = true;
            this.PlaceWordButton.Click += new System.EventHandler(this.PlaceWordButton_Click);
            // 
            // PlaceAlphabetButton
            // 
            this.PlaceAlphabetButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceAlphabetButton.Location = new System.Drawing.Point(326, 122);
            this.PlaceAlphabetButton.Name = "PlaceAlphabetButton";
            this.PlaceAlphabetButton.Size = new System.Drawing.Size(144, 35);
            this.PlaceAlphabetButton.TabIndex = 8;
            this.PlaceAlphabetButton.Text = "Задать";
            this.PlaceAlphabetButton.UseVisualStyleBackColor = true;
            this.PlaceAlphabetButton.Click += new System.EventHandler(this.PlaceAlphabetButton_Click);
            // 
            // ClearLeanButton
            // 
            this.ClearLeanButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearLeanButton.Location = new System.Drawing.Point(476, 77);
            this.ClearLeanButton.Name = "ClearLeanButton";
            this.ClearLeanButton.Size = new System.Drawing.Size(204, 35);
            this.ClearLeanButton.TabIndex = 9;
            this.ClearLeanButton.Text = "Очистить ленту";
            this.ClearLeanButton.UseVisualStyleBackColor = true;
            this.ClearLeanButton.Click += new System.EventHandler(this.ClearLeanButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Начальное состояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Машина:";
            // 
            // StartMachineButton
            // 
            this.StartMachineButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMachineButton.Location = new System.Drawing.Point(112, 200);
            this.StartMachineButton.Name = "StartMachineButton";
            this.StartMachineButton.Size = new System.Drawing.Size(144, 35);
            this.StartMachineButton.TabIndex = 12;
            this.StartMachineButton.Text = "Запустить";
            this.StartMachineButton.UseVisualStyleBackColor = true;
            this.StartMachineButton.Click += new System.EventHandler(this.StartMachineButton_Click);
            // 
            // NextStepButton
            // 
            this.NextStepButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextStepButton.Location = new System.Drawing.Point(262, 200);
            this.NextStepButton.Name = "NextStepButton";
            this.NextStepButton.Size = new System.Drawing.Size(168, 35);
            this.NextStepButton.TabIndex = 13;
            this.NextStepButton.Text = "Сделать шаг";
            this.NextStepButton.UseVisualStyleBackColor = true;
            this.NextStepButton.Click += new System.EventHandler(this.NextStepButton_Click);
            // 
            // ResetStagesButton
            // 
            this.ResetStagesButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetStagesButton.Location = new System.Drawing.Point(436, 200);
            this.ResetStagesButton.Name = "ResetStagesButton";
            this.ResetStagesButton.Size = new System.Drawing.Size(144, 35);
            this.ResetStagesButton.TabIndex = 14;
            this.ResetStagesButton.Text = "Сброс";
            this.ResetStagesButton.UseVisualStyleBackColor = true;
            this.ResetStagesButton.Click += new System.EventHandler(this.ResetStagesButton_Click);
            // 
            // SaveInFileButton
            // 
            this.SaveInFileButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveInFileButton.Location = new System.Drawing.Point(586, 200);
            this.SaveInFileButton.Name = "SaveInFileButton";
            this.SaveInFileButton.Size = new System.Drawing.Size(144, 35);
            this.SaveInFileButton.TabIndex = 15;
            this.SaveInFileButton.Text = "Сохранить";
            this.SaveInFileButton.UseVisualStyleBackColor = true;
            this.SaveInFileButton.Click += new System.EventHandler(this.SaveInFileButton_Click);
            // 
            // LoadInFileBytton
            // 
            this.LoadInFileBytton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadInFileBytton.Location = new System.Drawing.Point(736, 200);
            this.LoadInFileBytton.Name = "LoadInFileBytton";
            this.LoadInFileBytton.Size = new System.Drawing.Size(144, 35);
            this.LoadInFileBytton.TabIndex = 16;
            this.LoadInFileBytton.Text = "Загрузить";
            this.LoadInFileBytton.UseVisualStyleBackColor = true;
            this.LoadInFileBytton.Click += new System.EventHandler(this.LoadInFileBytton_Click);
            // 
            // StatesTable
            // 
            this.StatesTable.AllowUserToAddRows = false;
            this.StatesTable.AllowUserToDeleteRows = false;
            this.StatesTable.AllowUserToResizeColumns = false;
            this.StatesTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StatesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StateColumnt});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatesTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatesTable.EnableHeadersVisualStyles = false;
            this.StatesTable.Location = new System.Drawing.Point(12, 270);
            this.StatesTable.Name = "StatesTable";
            this.StatesTable.RowHeadersVisible = false;
            this.StatesTable.RowHeadersWidth = 51;
            this.StatesTable.RowTemplate.Height = 24;
            this.StatesTable.Size = new System.Drawing.Size(1310, 320);
            this.StatesTable.TabIndex = 17;
            this.StatesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatesTable_CellEndEdit);
            // 
            // StateColumnt
            // 
            this.StateColumnt.HeaderText = "Состояние";
            this.StateColumnt.MinimumWidth = 6;
            this.StateColumnt.Name = "StateColumnt";
            this.StateColumnt.Width = 125;
            // 
            // DeleteLastCondition
            // 
            this.DeleteLastCondition.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLastCondition.Location = new System.Drawing.Point(961, 200);
            this.DeleteLastCondition.Name = "DeleteLastCondition";
            this.DeleteLastCondition.Size = new System.Drawing.Size(69, 35);
            this.DeleteLastCondition.TabIndex = 39;
            this.DeleteLastCondition.Text = "-";
            this.DeleteLastCondition.UseVisualStyleBackColor = true;
            this.DeleteLastCondition.Click += new System.EventHandler(this.DeleteLastCondition_Click);
            // 
            // ShowLogsMachine
            // 
            this.ShowLogsMachine.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowLogsMachine.Location = new System.Drawing.Point(1036, 200);
            this.ShowLogsMachine.Name = "ShowLogsMachine";
            this.ShowLogsMachine.Size = new System.Drawing.Size(88, 35);
            this.ShowLogsMachine.TabIndex = 40;
            this.ShowLogsMachine.Text = "Шаги";
            this.ShowLogsMachine.UseVisualStyleBackColor = true;
            this.ShowLogsMachine.Click += new System.EventHandler(this.ShowLogsMachine_Click);
            // 
            // AddnewStateButton
            // 
            this.AddnewStateButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddnewStateButton.Location = new System.Drawing.Point(886, 200);
            this.AddnewStateButton.Name = "AddnewStateButton";
            this.AddnewStateButton.Size = new System.Drawing.Size(69, 35);
            this.AddnewStateButton.TabIndex = 41;
            this.AddnewStateButton.Text = "+";
            this.AddnewStateButton.UseVisualStyleBackColor = true;
            this.AddnewStateButton.Click += new System.EventHandler(this.AddnewStateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(909, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Состояния";
            // 
            // LenaDataGridView
            // 
            this.LenaDataGridView.AllowDrop = true;
            this.LenaDataGridView.AllowUserToAddRows = false;
            this.LenaDataGridView.AllowUserToDeleteRows = false;
            this.LenaDataGridView.AllowUserToResizeColumns = false;
            this.LenaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LenaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.LenaDataGridView.ColumnHeadersHeight = 50;
            this.LenaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LenaDataGridView.ColumnHeadersVisible = false;
            this.LenaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LenaDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.LenaDataGridView.Location = new System.Drawing.Point(78, 12);
            this.LenaDataGridView.Name = "LenaDataGridView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LenaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.LenaDataGridView.RowHeadersVisible = false;
            this.LenaDataGridView.RowHeadersWidth = 51;
            this.LenaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LenaDataGridView.RowTemplate.Height = 24;
            this.LenaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LenaDataGridView.Size = new System.Drawing.Size(1178, 50);
            this.LenaDataGridView.TabIndex = 87;
            this.LenaDataGridView.SelectionChanged += new System.EventHandler(this.LenaOneDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 51F;
            this.dataGridViewTextBoxColumn1.HeaderText = "LenaBox1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "LenaBox2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 44;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "LenaBox3";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 44;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "LenaBox4";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 44;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "LenaBox5";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 44;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "LenaBox6";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 44;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "LenaBox7";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 44;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "LenaBox8";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 44;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 44;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "LenaBox9";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 46;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "LenaBox10";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 46;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "LenaBox11";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 46;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "LenaBox12";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 46;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "LenaBox13";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 46;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "LenaBox14";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 46;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "LenaBox15";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 46;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "LenaBox16";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 46;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "LenaBox17";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 46;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "LenaBox18";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 46;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "LenaBox19";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 46;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "LenaBox20";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 46;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "LenaBox21";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 46;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 46;
            // 
            // MTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 599);
            this.Controls.Add(this.LenaDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddnewStateButton);
            this.Controls.Add(this.ShowLogsMachine);
            this.Controls.Add(this.DeleteLastCondition);
            this.Controls.Add(this.StatesTable);
            this.Controls.Add(this.LoadInFileBytton);
            this.Controls.Add(this.SaveInFileButton);
            this.Controls.Add(this.ResetStagesButton);
            this.Controls.Add(this.NextStepButton);
            this.Controls.Add(this.StartMachineButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearLeanButton);
            this.Controls.Add(this.PlaceAlphabetButton);
            this.Controls.Add(this.PlaceWordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlphabetTextField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.LenaLeftButton);
            this.Controls.Add(this.LenaRightButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MTForm";
            this.Text = "Одноленточная Машина Тьюринга ПИ-21Б Панков Е.А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MTForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.StatesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LenaRightButton;
        private System.Windows.Forms.Button LenaLeftButton;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlphabetTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PlaceWordButton;
        private System.Windows.Forms.Button PlaceAlphabetButton;
        private System.Windows.Forms.Button ClearLeanButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartMachineButton;
        private System.Windows.Forms.Button NextStepButton;
        private System.Windows.Forms.Button ResetStagesButton;
        private System.Windows.Forms.Button SaveInFileButton;
        private System.Windows.Forms.Button LoadInFileBytton;
        private System.Windows.Forms.DataGridView StatesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateColumnt;
        private System.Windows.Forms.Button DeleteLastCondition;
        private System.Windows.Forms.Button ShowLogsMachine;
        private System.Windows.Forms.Button AddnewStateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView LenaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    }
}

