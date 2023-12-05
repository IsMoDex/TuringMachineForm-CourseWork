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
    public partial class MTForm : Form
    {
        static private TuringMachine machine = new TuringMachine();
        static uint StartStage = 0;
        public MTForm()
        {
            InitializeComponent();

            LenaDataGridView.Rows.Add();
            LenaDataGridView.Rows[0].Height = LenaDataGridView.Height;
            LenaDataGridView.Rows[0].ReadOnly = true;

            for (int i = 0; i < 21; i++)
            {
                //LenaOneDataGridView.Rows[0].Cells[i].Value = i+1;//Убрать
                LenaDataGridView.Columns[i].MinimumWidth = LenaDataGridView.Width / 21;
                LenaDataGridView.Columns[i].Width = LenaDataGridView.Width / 21;

            }
            LenaDataGridView.Rows[0].Cells[10].Style.BackColor = System.Drawing.Color.LightGreen;

            LenaDataGridView.ClearSelection();

            MTForm_SizeChanged(new object(), new EventArgs());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //machine.setNewWord("HELLO")

            //machine.setAlphabet("01c!");

            //for (int i = 0; i <= 23; ++i)
            //    machine.addNewCondition();

            //machine.setAction(0, '1', '1', TuringMachine.Shift.R, 1);
            //machine.setAction(0, '0', '0', TuringMachine.Shift.R, 1);
            //machine.setAction(0, 'c', 'c', TuringMachine.Shift.R, 2);
            //machine.setAction(0, 'λ', 'λ', TuringMachine.Shift.L, 21);

            //machine.setAction(1, '1', '1', TuringMachine.Shift.R, 0);
            //machine.setAction(1, '0', '0', TuringMachine.Shift.R, 0);
            //machine.setAction(1, 'c', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(1, 'λ', 'λ', TuringMachine.Shift.L, 21);

            //machine.setAction(2, '1', '1', TuringMachine.Shift.R, 3);
            //machine.setAction(2, '0', '0', TuringMachine.Shift.R, 3);
            //machine.setAction(2, 'c', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(2, 'λ', 'λ', TuringMachine.Shift.L, 4);

            //machine.setAction(3, '1', '1', TuringMachine.Shift.R, 2);
            //machine.setAction(3, '0', '0', TuringMachine.Shift.R, 2);
            //machine.setAction(3, 'c', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(3, 'λ', 'λ', TuringMachine.Shift.L, 21);

            //machine.setAction(4, '1', 'λ', TuringMachine.Shift.L, 6);
            //machine.setAction(4, '0', 'λ', TuringMachine.Shift.L, 11);
            //machine.setAction(4, 'c', 'λ', TuringMachine.Shift.L, 5);

            //machine.setAction(5, 'λ', '0', TuringMachine.Shift.N, -1);
            //machine.setAction(5, '1', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(5, '0', 'λ', TuringMachine.Shift.L, 23);

            //machine.setAction(6, '1', '1', TuringMachine.Shift.L, 6);
            //machine.setAction(6, '0', '0', TuringMachine.Shift.L, 6);
            //machine.setAction(6, 'c', 'c', TuringMachine.Shift.L, 7);

            //machine.setAction(7, '!', '!', TuringMachine.Shift.L, 7);
            //machine.setAction(7, '1', '!', TuringMachine.Shift.L, 8);
            //machine.setAction(7, '0', '!', TuringMachine.Shift.L, 17);
            //machine.setAction(7, 'λ', 'λ', TuringMachine.Shift.R, 18);

            //machine.setAction(8, '1', 'λ', TuringMachine.Shift.R, 9);
            //machine.setAction(8, '0', 'λ', TuringMachine.Shift.R, 9);
            //machine.setAction(8, 'λ', 'λ', TuringMachine.Shift.R, 16);

            //machine.setAction(9, '!', '!', TuringMachine.Shift.R, 9);
            //machine.setAction(9, 'c', 'c', TuringMachine.Shift.R, 9);
            //machine.setAction(9, 'λ', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(9, '1', '1', TuringMachine.Shift.R, 10);
            //machine.setAction(9, '0', '0', TuringMachine.Shift.R, 10);

            //machine.setAction(10, '1', '1', TuringMachine.Shift.R, 10);
            //machine.setAction(10, '0', '0', TuringMachine.Shift.R, 10);
            //machine.setAction(10, 'λ', 'λ', TuringMachine.Shift.L, 4);

            //machine.setAction(11, '1', '1', TuringMachine.Shift.L, 11);
            //machine.setAction(11, '0', '0', TuringMachine.Shift.L, 11);
            //machine.setAction(11, 'c', 'c', TuringMachine.Shift.L, 12);

            //machine.setAction(12, '!', '!', TuringMachine.Shift.L, 12);
            //machine.setAction(12, '1', '!', TuringMachine.Shift.L, 17);
            //machine.setAction(12, '0', '!', TuringMachine.Shift.L, 13);
            //machine.setAction(12, 'λ', 'λ', TuringMachine.Shift.R, 18);

            //machine.setAction(13, '1', '1', TuringMachine.Shift.R, 9);
            //machine.setAction(13, '0', '0', TuringMachine.Shift.R, 14);
            //machine.setAction(13, 'λ', 'λ', TuringMachine.Shift.R, 16);

            //machine.setAction(14, '!', '!', TuringMachine.Shift.R, 14);
            //machine.setAction(14, 'c', 'c', TuringMachine.Shift.R, 14);
            //machine.setAction(14, '1', '1', TuringMachine.Shift.R, 15);
            //machine.setAction(14, '0', '0', TuringMachine.Shift.R, 15);
            //machine.setAction(14, 'λ', 'λ', TuringMachine.Shift.L, 23);

            //machine.setAction(15, '1', '1', TuringMachine.Shift.R, 15);
            //machine.setAction(15, '0', '0', TuringMachine.Shift.R, 15);
            //machine.setAction(15, 'λ', 'λ', TuringMachine.Shift.L, 4);

            //machine.setAction(16, '!', '!', TuringMachine.Shift.R, 16);
            //machine.setAction(16, 'c', 'c', TuringMachine.Shift.R, 16);
            //machine.setAction(16, 'λ', 'λ', TuringMachine.Shift.L, 21);
            //machine.setAction(16, '1', '!', TuringMachine.Shift.R, 22);
            //machine.setAction(16, '0', '!', TuringMachine.Shift.R, 22);

            //machine.setAction(17, '1', '!', TuringMachine.Shift.L, 17);
            //machine.setAction(17, '0', '!', TuringMachine.Shift.L, 17);
            //machine.setAction(17, 'λ', 'λ', TuringMachine.Shift.R, 18);

            //machine.setAction(18, '1', 'λ', TuringMachine.Shift.R, 18);
            //machine.setAction(18, '0', 'λ', TuringMachine.Shift.R, 18);
            //machine.setAction(18, 'c', 'λ', TuringMachine.Shift.R, 18);
            //machine.setAction(18, '!', 'λ', TuringMachine.Shift.R, 18);
            //machine.setAction(18, 'λ', '1', TuringMachine.Shift.N, -1);

            //machine.setAction(19, '1', 'λ', TuringMachine.Shift.R, 19);
            //machine.setAction(19, '0', 'λ', TuringMachine.Shift.R, 19);
            //machine.setAction(19, 'c', 'λ', TuringMachine.Shift.R, 19);
            //machine.setAction(19, '!', 'λ', TuringMachine.Shift.R, 19);
            //machine.setAction(19, 'λ', '0', TuringMachine.Shift.N, -1);

            //machine.setAction(20, '1', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(20, '0', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(20, 'c', '!', TuringMachine.Shift.R, 20);
            //machine.setAction(20, 'λ', 'λ', TuringMachine.Shift.L, 21);

            //machine.setAction(21, '1', 'λ', TuringMachine.Shift.L, 21);
            //machine.setAction(21, '0', 'λ', TuringMachine.Shift.L, 21);
            //machine.setAction(21, 'c', 'λ', TuringMachine.Shift.L, 21);
            //machine.setAction(21, '!', 'λ', TuringMachine.Shift.L, 21);
            //machine.setAction(21, 'λ', '0', TuringMachine.Shift.N, -1);

            //machine.setAction(22, '1', '!', TuringMachine.Shift.R, 22);
            //machine.setAction(22, '0', '!', TuringMachine.Shift.R, 22);
            //machine.setAction(22, 'λ', 'λ', TuringMachine.Shift.L, 23);

            //machine.setAction(23, '1', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(23, '0', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(23, 'c', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(23, '!', 'λ', TuringMachine.Shift.L, 23);
            //machine.setAction(23, 'λ', '1', TuringMachine.Shift.N, -1);
            //ShowLena();

            //ShowStatesTable();
        }

        private void LenaRightButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(TuringMachine.Shift.L);
            ShowLena();
        }

        private void LenaLeftButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(TuringMachine.Shift.R);
            ShowLena();
        }

        protected void ShowLena()
        {
            List<char> Word = machine.getWord();

            for (int i = 0; i < 21; ++i)
                LenaDataGridView.Rows[0].Cells[i].Value = "";

            if (Word.Count == 0) return;

            for (int i = 10 - machine.getCurrent_Position(), j = 0; i < 21; ++i)
            {
                try
                {
                    if (j < Word.Count)
                        LenaDataGridView.Rows[0].Cells[i].Value += "" + Word[j++];
                    else break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    j++;
                    continue;
                }


            }
        }

        private void PlaceWordButton_Click(object sender, EventArgs e)
        {
            if (WordTextBox.Text.Length == 0) return;
            if(!machine.setNewWord(WordTextBox.Text))
            {
                MessageBox.Show(
        "Слово не пренадлежит алфавиту или пустое!",
        "Уведомление!",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.RightAlign);
                WordTextBox.Clear();
                return;
            }
            ShowLena();
        }

        private void ClearLeanButton_Click(object sender, EventArgs e)
        {
            machine.setNewWord("");
            ShowLena();
        }

        private void ShowStatesTable()
        {
            List<char> Alphabet = machine.getAlphabet();

            StatesTable.Columns.Clear();

            int Width = StatesTable.Width / (Alphabet.Count + 2) - 1; //Устанавливаем ширину относительно размера таблицы // -1 для того что-бы убрать Scroll Bar
            int Height = 30;
            Font FontWisible = new Font("Times New Roman", 16);

            StatesTable.Columns.Add("States", "Состояние");
            StatesTable.Columns["States"].Width = Width;
            StatesTable.Columns["States"].ReadOnly = true;
            StatesTable.ColumnHeadersDefaultCellStyle.Font = FontWisible;

            foreach (char c in Alphabet)
            {
                StatesTable.Columns.Add(c.GetHashCode().ToString(), c.ToString()); //Добавляем колонку
                StatesTable.Columns[c.GetHashCode().ToString()].DefaultCellStyle.Font = FontWisible; // Высталяем стиль
                StatesTable.Columns[c.GetHashCode().ToString()].Width = Width; //Выставляем размер на заполение
            }

            char Lambda = 'λ'; //Добавляем лямбду в таблицу
            StatesTable.Columns.Add(Lambda.GetHashCode().ToString(), Lambda.ToString());
            StatesTable.Columns[Lambda.GetHashCode().ToString()].DefaultCellStyle.Font = FontWisible;
            StatesTable.Columns[Lambda.GetHashCode().ToString()].Width = Width; //Выставляем размер на заполение

            for (int i = 0; i < machine.getCuntConditions(); ++i)
            {
                StatesTable.Rows.Add("q"+i);
                StatesTable.Rows[i].Height = Height;
                StatesTable.Rows[i].DefaultCellStyle.Font = FontWisible;

                foreach (char c in Alphabet)
                {
                    StatesTable.Rows[i].Cells[c.GetHashCode().ToString()].Value = machine.getReaction(i, c);
                }

                StatesTable.Rows[i].Cells[Lambda.GetHashCode().ToString()].Value = machine.getReaction(i, Lambda); //Добавляем состояния лямбды

            }
            
        }

        private void PlaceAlphabetButton_Click(object sender, EventArgs e)
        {
            if (AlphabetTextField.Text.Length == 0) return;
            machine.setAlphabet(AlphabetTextField.Text);

            ShowStatesTable();
        }

        private void StatesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }
            String ValueCell = StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (ValueCell.Length < 5)
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            //List<char> Alphabet = machine.getAlphabet();

            

            char Symbol = '-';
            char Lambda = 'λ';
            TuringMachine.Shift shift = TuringMachine.Shift.N;
            int NextCondition = 0;

            bool TooAccept = true;

            if(machine.CheckForAlphabet(ValueCell.ElementAt(0)))
                Symbol = ValueCell.ElementAt(0);
            else
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            shift = getShiftByChar(ValueCell.ElementAt(2));
            if(shift == TuringMachine.Shift.Null)
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            if (ValueCell.ElementAt(4) == '!')
            {
                NextCondition = -1;
            }
            else if (ValueCell.ElementAt(4) == 'q' || ValueCell.ElementAt(4) == 'Q')
            {
                String str = "";
                for (int i = 5; i < ValueCell.Length; i++)
                {
                    str += ValueCell.ElementAt(i);
                }
                if (str.Length > 0)
                {
                    try
                    {
                        NextCondition = Convert.ToInt32(str);
                        if (NextCondition < -1 || NextCondition >= machine.getCuntConditions())
                            TooAccept = false;
                    }
                    catch (FormatException ex) { TooAccept = false; }

                }
                else TooAccept = false;
            }
            else TooAccept = false;
            

            if (TooAccept)
            {
                if(e.ColumnIndex == StatesTable.Columns.Count-1)
                    machine.setAction((uint)e.RowIndex, Lambda, Symbol, shift, NextCondition);
                
                else machine.setAction((uint)e.RowIndex, machine.getAlphabet().ElementAt(e.ColumnIndex-1), Symbol, shift, NextCondition);
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;
                return;
            }
            else
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

        }//Ввод состояний
        private TuringMachine.Shift getShiftByChar(char s)
        {
            if (s == 'R' || s == 'r') return TuringMachine.Shift.R;
            if (s == 'L' || s == 'l') return TuringMachine.Shift.L;
            if (s == 'N' || s == 'n') return TuringMachine.Shift.N;
            return TuringMachine.Shift.Null;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            TuringMachine.Shift shift = machine.Next_step();

            if (shift == TuringMachine.Shift.Null) return;

            ShowStage();
            ShowLena();
        }

        DataGridViewCell PrevCell;
        private void ShowStage()
        {
            //List<char> Word = machine.getWord();
            //if(PrevCell != null)
            //    PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;
            //try
            //{
            //    PrevCell = StatesTable.Rows[machine.getCurrect_Action()].Cells[Word[machine.getCurrent_Position()].GetHashCode().ToString()];
            //    PrevCell.Style.BackColor = System.Drawing.Color.LightGreen;
            //} catch(ArgumentOutOfRangeException ex) { }

            if (PrevCell != null)
                PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;

            if (machine.getCurrect_Action() == -1)
            {
                if (PrevCell != null)
                    PrevCell.Style.BackColor = Color.Red;
                return;
            }
            //List<char> Word = machine.getWord();

            char s;
            try
            {
                s = machine.getWord()[machine.getCurrent_Position()];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                if (PrevCell != null)
                    PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;
                return;
            }
            for (int i = 0; i < StatesTable.Columns.Count; ++i)
            {
                if (StatesTable.Columns[i].HeaderText.Equals(s.ToString()))
                {
                    PrevCell = StatesTable.Rows[machine.getCurrect_Action()].Cells[i];
                    break;
                }
            }
            PrevCell.Style.BackColor = System.Drawing.Color.LightGreen;

        }

        private void ResetStagesButton_Click(object sender, EventArgs e)
        {
            if (PrevCell != null)
                PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;

            machine.setCurent_ConditionAndReset(StartStage);
            ShowLena();
        }

        private void StartMachineButton_Click(object sender, EventArgs e)
        {
            if (!machine.StartMachine())
                MessageBox.Show(
        "Количество интераций машины привысело 1000!\nМашина была экстренно приостановлена!",
        "Ошибка!",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.RightAlign);

            ShowLena();
        }

        private void DeleteLastCondition_Click(object sender, EventArgs e)
        {
            machine.deleteLastCondition();
            ShowStatesTable();
        }

        private void AddnewStateButton_Click(object sender, EventArgs e)
        {
            machine.addNewCondition();
            ShowStatesTable();
        }

        private void ShowLogsMachine_Click(object sender, EventArgs e)
        {
            Form LogsFormMessage = new LogsForm(machine.getLogsStages());
            LogsFormMessage.Show();
        }

        private void WordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                PlaceWordButton_Click(sender, e);
                e.Handled = true;
                return;
            }

            if (Convert.ToChar(e.KeyChar) == Convert.ToChar(Keys.Back) || machine.CheckForAlphabet(Convert.ToChar(e.KeyChar)))
                return;

            if (e.KeyChar == '\u0016') //Если данные вставляют из буфера
            {
                String str = Clipboard.GetText();

                for (int i = 0; i < str.Length; i++)
                    if (machine.CheckForAlphabet(str[i]))
                    {
                        WordTextBox.Text += str[i];
                    }
            }

            e.Handled = true;
        }

        private void AlphabetTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                PlaceAlphabetButton_Click(sender, e);
                e.Handled = true;
                return;
            }
        }

        private void LenaOneDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LenaDataGridView.ClearSelection();
        }

        private void SaveInFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory());
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = "Stage";
            saveFileDialog.Title = "Сохранить состояние";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                machine.SaveStagesInFile(saveFileDialog.FileName);
            }
        }

        private void LoadInFileBytton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory()); //, "..\\..\\SaveStages"
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Открыть состояние";
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
                    return;
                }
            }

            ShowStatesTable();
            List<char> Alphabet = machine.getAlphabet();

            AlphabetTextField.Clear();
            foreach (char c in Alphabet)
                AlphabetTextField.Text += c;
        }

        private void MTForm_SizeChanged(object sender, EventArgs e)
        {
            StatesTable.Width = this.Width - 34;
            StatesTable.Height = this.Height - StatesTable.Location.Y - 50;
             ShowStatesTable(); //Не уверен что оно тут надо
        }
    }
}
