using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachineForm
{
    public partial class LogsForm : Form
    {
        List<string> logs;
        
        public LogsForm(List<string> list)
        {
            InitializeComponent();

            logs = list;
            foreach (string item in logs)
                BigTextBox.Text += item + '\r' + '\n';

            LogsForm_ClientSizeChanged(new object(), new EventArgs());
            BigTextBox.MouseWheel += new MouseEventHandler(MouseWheelBigText);
        }

        int SizeText = 10;
        private void MouseWheelBigText(object sender, MouseEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control)
                if (e.Delta > 0)
                {
                    SizeText++;
                    BigTextBox.Font = new Font(BigTextBox.Font.Name, SizeText);
                }
                else
                {
                    if (SizeText - 1 <= 0) return;
                        SizeText--;
                        BigTextBox.Font = new Font(BigTextBox.Font.Name, SizeText);
                }

        }

        private void SaveInFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\SaveStages");
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "Logs";
            saveFileDialog.Title = "Сохранить логи";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using(System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName))
                {   
                    foreach (String item in logs)
                        sw.WriteLine(item);
                }
            }
        }

        private void LogsForm_ClientSizeChanged(object sender, EventArgs e)
        {
            int FormWidth = this.Width;
            BigTextBox.Width = FormWidth - BigTextBox.Location.X - 20;//+2
            BigTextBox.Height = this.Height - BigTextBox.Location.Y - 44;//+2
            
            SaveInFileButton.SetBounds(
                FormWidth - SaveInFileButton.Width - 40, 
                SaveInFileButton.Location.Y, 
                SaveInFileButton.Width, 
                SaveInFileButton.Height);
        }
    }
}
