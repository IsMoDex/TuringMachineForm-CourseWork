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
    public partial class MainMenu : Form
    {
        private Form OneMT;
        private Form OneChartMT;

        private Form TwoMT;
        private Form TwoChartMT;


        public MainMenu()
        {
            InitializeComponent();
            //ResetColor = StartOneMTButton.BackColor;
        }
        //private Color ResetColor;
        //private Color Green = Color.LightGreen;

        private void StartOneMTButton_Click(object sender, EventArgs e)
        {
            if (OneMT != null)
                OneMT.Close();
            OneMT = new MTForm();
            OneMT.Show();
            //OneMT.ShowDialog();
        }

        private void StartOneMTChartButton_Click(object sender, EventArgs e)
        {
            //StartOneMTChartButton.BackColor = Green;
            if (OneChartMT != null)
                OneChartMT.Close();
            OneChartMT = new ChartMT();
            OneChartMT.Show();
            //StartOneMTChartButton.BackColor = ResetColor;
        }

        private void StartTwoMTButton_Click(object sender, EventArgs e)
        {
            if (TwoMT != null)
                TwoMT.Close();
            TwoMT = new MMTForm();
            TwoMT.Show();
            //TwoLentStart = !TwoLentStart;
        }

        private void StartTwoMTChartButton_Click(object sender, EventArgs e)
        {
            //StartTwoMTChartButton.BackColor = Green;
            if (TwoChartMT != null)
                TwoChartMT.Close();
            TwoChartMT = new ChartMMT();
         
            TwoChartMT.Show();
            //StartTwoMTChartButton.BackColor = ResetColor;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TwoMT != null)
                TwoMT.Close();

            if (TwoChartMT != null)
                TwoChartMT.Close();


            if (OneChartMT != null)
                OneChartMT.Close();

            if (OneMT != null)
                OneMT.Close();
            //Environment.Exit(0);
        }
    }
}
