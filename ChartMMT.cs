using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuringMachineForm
{
    public partial class ChartMMT : Form
    {
        MMTuringMachine machine = new MMTuringMachine();
        public ChartMMT()
        {
            InitializeComponent();

            this.chart1.Series[0].Points.Clear();
        }

        private void ChartMMT_Load(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();

            ChartMMT_SizeChanged(new object(), new EventArgs());
            ResetColor = StartOrStopButton.BackColor;

            while (!SetConditions());
            if (!CONT) return;

            List<char> list = machine.getAlphabet(); //Устанавливаем афлавит
            foreach (char c in list)
                Alphabet += c;

            UseAlphabet = (string)Alphabet.Clone();

            MMTThread = new Thread(DrawChart);
            MMTThread.Start();

            if (notification_errors) оповещятьОбОшибкахToolStripMenuItem.BackColor = Color.LightGreen;
            else оповещятьОбОшибкахToolStripMenuItem.BackColor = ResetColor;

        }

        private bool SetConditions()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory()); //, "..\\..\\SaveStages"
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.Title = "Загрузить состояние ММТ";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!machine.ReadStagesInFile(openFileDialog.FileName))
                {
                    MessageBox.Show(
                "Не корректные данные файла!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
                    return false;
                }
            }
            else this.Close();

            return true;
        }

        private Thread MMTThread; //Поток вычислений и отрисовки

        private void setFormClosing(object sender, EventArgs e)
        {
            CONT = false;
        }

        private volatile bool CONT = true, Suspend = true;

        Color ResetColor = new Color(); //Базовый цвет кнопки

        private bool notification_errors = true; //Оповещение об ошибках при работе с алгоритмом

        private void StartOrStopButton_Click(object sender, EventArgs e)
        {
            Suspend = !Suspend;
            if (!Suspend)
            {
                StartOrStopButton.Text = "Stop";
                StartOrStopButton.BackColor = Color.Red;
            }
            else
            {
                StartOrStopButton.Text = "Start";
                StartOrStopButton.BackColor = ResetColor;
            }

            startStopToolStripMenuItem.Text = StartOrStopButton.Text;
            startStopToolStripMenuItem.BackColor = StartOrStopButton.BackColor;

        }

        private void ChartMMT_SizeChanged(object sender, EventArgs e)
        {
            chart1.Width = this.Width - 35;
            chart1.Height = this.Height - menuStrip1.Height - 50;
            StartOrStopButton.Location = new Point(this.Width - StartOrStopButton.Width - 30, StartOrStopButton.Location.Y);
        }

        private void DrawChart()
        {

            try
            {
                while (CONT)
                {
                    while (Suspend)
                    {
                        Thread.Sleep(1000);
                        if (!CONT) return;
                    }

                    Dive("", 0);
                    chart1.Invoke(new ThreadStart(DrawGraph));
                }
            }
            catch (InvalidAsynchronousStateException ex)
            {
                return;
            }
            catch (InvalidOperationException ex)
            {
                return;
            }

        }

        private void Dive(string prefix, int level)
        {
            if (!CONT || Suspend) return; //В случае закрытия програмы останавливается рекурсия

            level++;
            foreach (char c in UseAlphabet)
            {
                if (!CONT || Suspend) return;  //В случае закрытия програмы останавливается рекурсия

                if (level == SizeWord)
                {
                    int CountInteration = getCountInterationByWord(prefix + c);

                    if (MaxCountInteration < CountInteration)
                        MaxCountInteration = CountInteration;

                    if (notification_errors)
                    {
                        String ErrorResult = "";
                        bool Errors_found = false;

                        
                        if (CountInteration > 1999)
                        {
                            ErrorResult += ("\nВышло за пределы!"
                                + "\nКоличетсво интераций : " + CountInteration);
                            Errors_found = true;
                        }

                        ///Проверка пустоты второй ленты
                        List<char> TwoLent = machine.getWord_TwoLent();
                        if (TwoLent.Count > 1 || TwoLent[0] != 'λ')
                        {
                            ErrorResult += ("\nВторая лента небыла очищена!");
                            Errors_found = true;
                        }

                        String WordOne = "";
                        foreach (char ch in machine.getWord_OneLent())
                            WordOne += ch;

                        if(((prefix + c).IndexOf('λ') == -1 || ((prefix + c).Length == 1 && (prefix + c).Equals("λ"))) && WordOne.Length > 1)
                        {
                            ErrorResult += "\nНа первой ленте больше одного символа!";
                            Errors_found = true;
                        }

                        if(Errors_found)
                        {
                            MessageBox.Show(ErrorResult = "Слово {" + prefix + c + "}, вызвало ошибки:" + ErrorResult);
                        }

                    }
                    
                }

                if (level < SizeWord)
                {
                    Dive(prefix + c, level);
                }
            }

        }

        private uint CurrentPosition = 0;
        private string UseAlphabet;
        private string Alphabet;
        private volatile int SizeWord = 1;
        private volatile int MaxCountInteration = 0;
        public void DrawGraph()
        {
            this.chart1.Series[0].Points.AddXY(SizeWord, MaxCountInteration);
            MaxCountInteration = 0;
            SizeWord++;
        }

        private void редактироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangeAlphabet_in_Chart change = new ChangeAlphabet_in_Chart((string)Alphabet.Clone(), (string)UseAlphabet.Clone());
            change.ShowDialog();
            if (change.DialogResult())
            {
                UseAlphabet = change.getAlphabetResult();
            }

            change.Close();
            change = null;
        }

        private void startStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartOrStopButton_Click(new object(), new EventArgs());
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Suspend)
            {
                StartOrStopButton_Click(new object(), new EventArgs());
            }

            this.chart1.Series[0].Points.Clear();
            SizeWord = 0;
            MaxCountInteration = 0;
        }

        private void оповещятьОбОшибкахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notification_errors = !notification_errors;

            if (notification_errors) оповещятьОбОшибкахToolStripMenuItem.BackColor = Color.LightGreen;
            else оповещятьОбОшибкахToolStripMenuItem.BackColor = ResetColor;
        }

        public int getCountInterationByWord(String Word)
        {
            machine.setNewWord(Word);
            machine.setCurent_ConditionAndReset(CurrentPosition);
            machine.StartMachine();
            return machine.getCountInteration();
        }
    }
}
