using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachineForm
{
    public partial class ChangeAlphabet_in_Chart : Form
    {
        private string Alphabet;
        public ChangeAlphabet_in_Chart(string alphabet, string useAlphabet)
        {
            InitializeComponent();

            if (alphabet.IndexOf('λ') == -1)
                alphabet += 'λ';

            label1.Text = "Доступный: " + alphabet;
            label2.Text = "Используемый: " + useAlphabet;

            SetAlphabetTextBox.Text = useAlphabet;
            Alphabet= alphabet;
        }

        private void ChangeAlphabet_in_Chart_Load(object sender, EventArgs e)
        {
            
        }

        public string getAlphabetResult()
        {
            return SetAlphabetTextBox.Text;
        }

        public bool DialogResult()
        {
            return Accept;
        }

        private bool Accept = false;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Accept = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Accept= false;
            this.Close();
        }

        private void SetAlphabetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;

            string Text = SetAlphabetTextBox.Text;

            if (e.KeyChar == '\u0016' && Clipboard.GetText().Equals("λ")) //Если данные вставляют из буфера
            {
                e.KeyChar = 'λ';
            }

            foreach (char s in Text)
                if(s == e.KeyChar)
                {
                    e.Handled = true;
                    return;
                }

            foreach(char s in Alphabet)
                if(e.KeyChar == s || e.KeyChar == 'λ')
                {
                    return;
                }

            

                e.Handled = true;
            return;

        }
    }
}
