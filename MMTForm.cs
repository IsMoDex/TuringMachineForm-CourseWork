using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace TuringMachineForm
{
    public partial class MMTForm : Form
    {
        MMTuringMachine machine = new MMTuringMachine();
        Font FontWisibleStatesTable = new Font("Times New Roman", 12);
        uint StartStage = 0;
        public MMTForm()
        {
            InitializeComponent();
            LenaOneDataGridView.Rows.Add();
            LenaOneDataGridView.Rows[0].Height = LenaOneDataGridView.Height;
            LenaOneDataGridView.Rows[0].ReadOnly = true;

            LenaTwoDataGridView.Rows.Add();
            LenaTwoDataGridView.Rows[0].Height = LenaTwoDataGridView.Height;
            LenaTwoDataGridView.Rows[0].ReadOnly = true;
            for (int i = 0; i < 21; i++)
            {
                //LenaOneDataGridView.Rows[0].Cells[i].Value = i+1;//Убрать
                LenaOneDataGridView.Columns[i].MinimumWidth = LenaOneDataGridView.Width / 21;
                LenaOneDataGridView.Columns[i].Width = LenaOneDataGridView.Width / 21;

                //LenaTwoDataGridView.Rows[0].Cells[i].Value = i + 1;//Убрать
                LenaTwoDataGridView.Columns[i].MinimumWidth = LenaTwoDataGridView.Width / 21;
                LenaTwoDataGridView.Columns[i].Width = LenaTwoDataGridView.Width / 21;
            }
            LenaOneDataGridView.Rows[0].Cells[10].Style.BackColor = System.Drawing.Color.LightGreen;
            LenaTwoDataGridView.Rows[0].Cells[10].Style.BackColor = System.Drawing.Color.LightGreen;

            LenaOneDataGridView.ClearSelection();
            LenaTwoDataGridView.ClearSelection();

            MMTForm_ClientSizeChanged(new object(), new EventArgs());//Корректировка размера
            //Базовые параметры, удалить    

            //machine.setAlphabet("01");
            //machine.setNewWord("10001");

            //machine.addNewCondition();
            //machine.addNewCondition();

            //machine.setAction(0, "1λ", "11", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 0);
            //machine.setAction(0, "0λ", "0λ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.N, 1);
            //machine.setAction(1, "0λ", "00", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 0);
            //machine.setAction(0, "λλ", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.N, -1);


            ShowLenas();
            ShowStatesTable();
        }
        private void MMTForm_Load(object sender, EventArgs e)
        {
            //machine.setAlphabet("01c");

            //for (int i = 0; i <= 8; ++i)
            //    machine.addNewCondition();

            //machine.addNewReaction("11");
            //machine.addNewReaction("10");
            //machine.addNewReaction("1c");
            //machine.addNewReaction("1λ");
            //machine.addNewReaction("01");
            //machine.addNewReaction("00");
            //machine.addNewReaction("0c");
            //machine.addNewReaction("0λ");
            //machine.addNewReaction("c1");
            //machine.addNewReaction("c0");
            //machine.addNewReaction("cc");
            //machine.addNewReaction("cλ");
            //machine.addNewReaction("λ1");
            //machine.addNewReaction("λ0");
            //machine.addNewReaction("λc");
            //machine.addNewReaction("λλ");
                
            //machine.setAction(0, "1λ", "λ1", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 1);
            //machine.setAction(0, "0λ", "λ0", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 1);
            //machine.setAction(0, "cλ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 2);
            //machine.setAction(0, "λλ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 6);

            //machine.setAction(1, "1λ", "λ1", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 0);
            //machine.setAction(1, "0λ", "λ0", MMTuringMachine.Shift.R, MMTuringMachine.Shift.R, 0);
            //machine.setAction(1, "cλ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(1, "λλ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);

            //machine.setAction(2, "1λ", "1λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 3);
            //machine.setAction(2, "0λ", "0λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 3);
            //machine.setAction(2, "cλ", "cλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(2, "λλ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 4);

            //machine.setAction(3, "1λ", "1λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 2);
            //machine.setAction(3, "0λ", "0λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 2);
            //machine.setAction(3, "cλ", "cλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(3, "λλ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);

            //machine.setAction(4, "10", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(4, "01", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(4, "λ0", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 5);
            //machine.setAction(4, "λ1", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 5);
            //machine.setAction(4, "1λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 5);
            //machine.setAction(4, "0λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 5);
            //machine.setAction(4, "11", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 4);
            //machine.setAction(4, "00", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 4);
            //machine.setAction(4, "λλ", "0λ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, -1);

            //machine.setAction(5, "11", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "00", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "10", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "01", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "λ0", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "λ1", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 5);
            //machine.setAction(5, "1λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 5);
            //machine.setAction(5, "0λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 5);
            //machine.setAction(5, "λλ", "1λ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.N, -1);

            //machine.setAction(6, "11", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "00", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "10", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "c0", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "01", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "c1", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "1λ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 6);
            //machine.setAction(6, "0λ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 6);
            //machine.setAction(6, "cλ", "λλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 6);
            //machine.setAction(6, "λ1", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "λ0", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 6);
            //machine.setAction(6, "λλ", "0λ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.N, -1);

            //machine.setAction(7, "11", "1λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "00", "0λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "10", "1λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "c0", "cλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "01", "0λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "c1", "cλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.L, 7);
            //machine.setAction(7, "1λ", "1λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 7);
            //machine.setAction(7, "0λ", "0λ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 7);
            //machine.setAction(7, "cλ", "cλ", MMTuringMachine.Shift.R, MMTuringMachine.Shift.N, 7);
            //machine.setAction(7, "λ1", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(7, "λ0", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(7, "λλ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 8);

            //machine.setAction(8, "11", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "00", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "10", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "01", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "c1", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "c0", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "1λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 8);
            //machine.setAction(8, "0λ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 8);
            //machine.setAction(8, "cλ", "λλ", MMTuringMachine.Shift.L, MMTuringMachine.Shift.N, 8);
            //machine.setAction(8, "λ1", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "λ0", "λλ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.L, 8);
            //machine.setAction(8, "λλ", "0λ", MMTuringMachine.Shift.N, MMTuringMachine.Shift.N, -1);


            //ShowLenas();
            //ShowStatesTable();
        }

        protected void ShowLenas()
        {
            List<char> WordOneLean = machine.getWord_OneLent();
            List<char> WordTwoLean = machine.getWord_TwoLent();

            //if (Word.Count == 0) return;

            for (int i = 0; i < 21; ++i)
                LenaOneDataGridView.Rows[0].Cells[i].Value = "";

            for (int i = 0; i < 21; ++i)
                LenaTwoDataGridView.Rows[0].Cells[i].Value = "";

            if (WordOneLean.Count == 0) return;

            for (int i = 10 - machine.getCurrent_Position_OneLent(), j = 0; i < 21; ++i)
            {
                try
                {
                    if (j < WordOneLean.Count)
                        LenaOneDataGridView.Rows[0].Cells[i].Value += "" + WordOneLean[j++];
                    else break;
                } catch (ArgumentOutOfRangeException ex) {
                    j++;
                    continue;
                }


            }

            if (WordTwoLean.Count == 0) return;
            if (WordTwoLean.Count == 1 && WordTwoLean[0] == 'λ') return;

            for (int i = 10 - machine.getCurrent_Position_TwoLent(), j = 0; i < 21; ++i) //Косяк какой-то
            {
                try
                {
                    if (j < WordTwoLean.Count)
                        LenaTwoDataGridView.Rows[0].Cells[i].Value += "" + WordTwoLean[j++];
                    else break;
                } catch (ArgumentOutOfRangeException ex) {
                    j++;
                    continue;
                }

            }


        }

        //Изменение состояний ленты//
        private void LenaOneLeftButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(MMTuringMachine.Shift.R, MMTuringMachine.Shift.N);
            ShowLenas();
        }
        private void LenaOneRightButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(MMTuringMachine.Shift.L, MMTuringMachine.Shift.N);
            ShowLenas();
        }

        private void LenaTwoLeftButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(MMTuringMachine.Shift.N, MMTuringMachine.Shift.R);
            ShowLenas();
        }
        private void LenaTwoRightButton_Click(object sender, EventArgs e)
        {
            machine.setCurrent_Position(MMTuringMachine.Shift.N, MMTuringMachine.Shift.L);
            ShowLenas();
        }
        //--------------------------------------------------------------------------------//

        private void PlaceWordButton_Click(object sender, EventArgs e)
        {
            if (WordTextBox.Text.Length == 0) return;
            if (!machine.setNewWord(WordTextBox.Text))
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
            ShowLenas();
        }

        private void ClearLeanButton_Click(object sender, EventArgs e)
        {
            machine.setNewWord("");
            ShowLenas();
        }

        private void PlaceAlphabetButton_Click(object sender, EventArgs e)
        {
            if (AlphabetTextField.Text.Length == 0) return;
            machine.setAlphabet(AlphabetTextField.Text);

            if (machine.getCuntConditions() == 0) machine.addNewCondition();

            ShowStatesTable();
            ShowLenas();
        }

        private void WordTextBox_KeyPress(object sender, KeyPressEventArgs e) //Фильтр ввода слова
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

        private void ShowStatesTable()
        {
            StatesTable.Columns.Clear();
            List<List<String>> KeysConditions = machine.getAllConditionsKeys();
            
            if (KeysConditions.Count == 0) return;

            

            int Width = StatesTable.Width / (KeysConditions[0].Count + 1); //Устанавливаем ширину относительно размера таблицы // -1 для того что-бы убрать Scroll Bar
            int Height = 30;
            //Font FontWisibleStatesTable = new Font("Times New Roman", 16);
            String Lambdas = "λλ"; //Добавляем лямбду в таблицу

            StatesTable.Columns.Add("States", "Состояние");
            StatesTable.Columns["States"].Width = Width;
            StatesTable.Columns["States"].ReadOnly = true; //Отключаем редактирование
            StatesTable.ColumnHeadersDefaultCellStyle.Font = FontWisibleStatesTable;

            for(int i = 0; i < KeysConditions[0].Count; ++i)
            {
                if (KeysConditions[0][i].Equals(Lambdas)) continue;
                StatesTable.Columns.Add(KeysConditions[0][i], KeysConditions[0][i]); //Добавляем колонку
                StatesTable.Columns[KeysConditions[0][i]].DefaultCellStyle.Font = FontWisibleStatesTable; // Высталяем стиль
                StatesTable.Columns[KeysConditions[0][i]].Width = Width; //Выставляем размер на заполение
            }

            
            StatesTable.Columns.Add(Lambdas.GetHashCode().ToString(), Lambdas.ToString());
            StatesTable.Columns[Lambdas.GetHashCode().ToString()].DefaultCellStyle.Font = FontWisibleStatesTable;
            StatesTable.Columns[Lambdas.GetHashCode().ToString()].Width = Width; //Выставляем размер на заполение

            for (int i = 0; i < machine.getCuntConditions(); ++i)
            {
                StatesTable.Rows.Add("q" + i);
                StatesTable.Rows[i].Height = Height;
                StatesTable.Rows[i].DefaultCellStyle.Font = FontWisibleStatesTable;

                for (int j = 0; j < KeysConditions[0].Count; ++j) 
                {
                    if (KeysConditions[0][j].Equals(Lambdas)) continue;
                    StatesTable.Rows[i].Cells[KeysConditions[0][j]].Value = machine.getReaction(i, KeysConditions[0][j]);
                }

                StatesTable.Rows[i].Cells[Lambdas.GetHashCode().ToString()].Value = machine.getReaction(i, Lambdas); //Добавляем состояния лямбды

            }

        }

        private void StatesTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String ValueCell = "";
            if (StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            ValueCell = StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (ValueCell.Length < 7)
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            List<char> Alphabet = machine.getAlphabet();



            String Symbols = "";
            String Lambdas = "λλ";
            MMTuringMachine.Shift[] shifts = {MMTuringMachine.Shift.Null, MMTuringMachine.Shift.Null};
            int NextCondition = 0;

            if (!machine.CheckForAlphabet(ValueCell.ElementAt(0)) || !machine.CheckForAlphabet(ValueCell.ElementAt(1)))
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            Symbols += ValueCell.ElementAt(0).ToString() + ValueCell.ElementAt(1).ToString();

            shifts[0] = getShiftByChar(ValueCell.ElementAt(3));
            shifts[1] = getShiftByChar(ValueCell.ElementAt(4));

            if (shifts[0] == MMTuringMachine.Shift.Null || shifts[1] == MMTuringMachine.Shift.Null)
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            if (ValueCell.ElementAt(6) == '!')
            {
                NextCondition = -1;
            }
            else if (ValueCell.ElementAt(6) == 'q' || ValueCell.ElementAt(6) == 'Q')
            {
                String str = "";
                for (int i = 7; i < ValueCell.Length; i++)
                {
                    str += ValueCell.ElementAt(i);
                }
                if (str.Length > 0)
                {
                    try
                    {
                        NextCondition = Convert.ToInt32(str);
                        if (NextCondition < -1 || NextCondition >= machine.getCuntConditions())
                        {
                            StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                            return;
                        }
                    }
                    catch (FormatException ex)
                    {
                        StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                        return;
                    }

                }
                else
                {
                    StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                    return;
                }
            }
            else
            {
                StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = System.Drawing.Color.Red;
                return;
            }

            if (e.ColumnIndex == StatesTable.Columns.Count - 1)
                machine.setAction((uint)e.RowIndex, Lambdas, Symbols, shifts[0], shifts[1], NextCondition);

            else machine.setAction((uint)e.RowIndex, StatesTable.Columns[e.ColumnIndex].Name, Symbols, shifts[0], shifts[1], NextCondition);
            StatesTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;
            return;
        }

        private MMTuringMachine.Shift getShiftByChar(char s)
        {
            if (s == 'R' || s == 'r') return MMTuringMachine.Shift.R;
            if (s == 'L' || s == 'l') return MMTuringMachine.Shift.L;
            if (s == 'N' || s == 'n') return MMTuringMachine.Shift.N;
            return MMTuringMachine.Shift.Null;
        }

        private void AddReactionButton_Click(object sender, EventArgs e)
        {
            if (AddReaactionTextField.Text.Length != 2) return;

            if (machine.getCuntConditions() == 0) machine.addNewCondition();

            machine.addNewReaction(AddReaactionTextField.Text);
            ShowStatesTable();
        }
        private void DeleteReactionButton(object sender, EventArgs e)
        {
            if (AddReaactionTextField.Text.Length != 2) return;
            //if (machine.getCuntConditions() == 0) machine.addNewCondition();
            machine.deleteReactions(AddReaactionTextField.Text);
            ShowStatesTable();
        }
        private void AddReaactionTextField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;

            if (AddReaactionTextField.Text.Length >= 2)
                e.Handled = true;

            if (Convert.ToChar(e.KeyChar) == Convert.ToChar(Keys.Enter))
            {
                AddReactionButton_Click(sender, e);
                e.Handled = true;
                return;
            }
                

            if (machine.CheckForAlphabet(Convert.ToChar(e.KeyChar)))
                return;

            if (e.KeyChar == '\u0016') //Если данные вставляют из буфера
            {
                String str = Clipboard.GetText();

                for(int i = 0; i < str.Length && i < 2; i++)
                    if (machine.CheckForAlphabet(str[i]) && AddReaactionTextField.Text.Length < 2)
                    {
                        AddReaactionTextField.Text += str[i];
                    }
            }

            e.Handled = true;
        }

        private void NextStepButton_Click(object sender, EventArgs e)
        {
            MMTuringMachine.Shift[] shifts = machine.Next_step();
            ShowStage();
            ShowLenas();
        }

        DataGridViewCell PrevCell;
        private void ShowStage()
        {
            if (PrevCell != null)
                PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;

            if(machine.getCurrect_Condition() == -1)
            {
                if (PrevCell != null)
                    PrevCell.Style.BackColor = Color.Red;
                return;
            }
            List<char> TwoLentWord = machine.getWord_TwoLent();

            String str;
            try
            {
            str = "" + machine.getWord_OneLent().ElementAt(machine.getCurrent_Position_OneLent()) + machine.getWord_TwoLent().ElementAt(machine.getCurrent_Position_TwoLent());
            } catch(ArgumentOutOfRangeException ex) {
                if (PrevCell != null)
                    PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;
                return; 
            }
            for (int i = 0; i < StatesTable.Columns.Count; ++i)
            {
                if (StatesTable.Columns[i].HeaderText.Equals(str))
                {
                    try
                    {
                        PrevCell = StatesTable.Rows[machine.getCurrect_Condition()].Cells[i];
                    }
                    catch (ArgumentOutOfRangeException ex) { return; } //В случае если было удалено состояние
                    
                    break;
                }
            }
            if(PrevCell != null)
            PrevCell.Style.BackColor = System.Drawing.Color.LightGreen;
        }

        private void LenaOneDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LenaOneDataGridView.ClearSelection();
        }
        private void LenaTwoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LenaTwoDataGridView.ClearSelection();
        }

        private void AddnewStateButton_Click(object sender, EventArgs e)
        {
            machine.addNewCondition();
            ShowStatesTable();
        }

        private void DeleteLastCondition_Click(object sender, EventArgs e)
        {
            machine.deleteLastCondition();
            ShowStatesTable();
        }

        private void StartMachineButton_Click(object sender, EventArgs e)
        {
            if (!machine.StartMachine())
                if (machine.getCountInteration() >= 2000)
                {
                    MessageBox.Show(
            "Количество интераций машины превысело 2000!\nМашина была экстренно приостановлена!",
            "Ошибка!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);

                }
                else return;

            ShowLenas();
            ShowStatesTable();
            ShowStage();
        }

        private void ResetStagesButton_Click(object sender, EventArgs e)
        {
            if (PrevCell != null)
                PrevCell.Style.BackColor = StatesTable.Rows[0].Cells[0].Style.BackColor;

            machine.setCurent_ConditionAndReset(StartStage);
            ShowLenas();
        }

        private void ShowLogsMachine_Click(object sender, EventArgs e)
        {
            Form LogsFormMessage = new LogsForm(machine.getLogsStages());
            LogsFormMessage.Show();
        }

        private void SaveInFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory()); //, "..\\..\\SaveStages"
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
            //openFileDialog.InitialDirectory = "C:\\Users\\1\\source\\repos\\TuringMachineForm\\SaveStages";
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

            ShowLenas();

            ShowStatesTable();
            List<char> Alphabet = machine.getAlphabet();

            AlphabetTextField.Clear();
            foreach (char c in Alphabet)
                AlphabetTextField.Text += c;
        }

        private void MMTForm_ClientSizeChanged(object sender, EventArgs e) //Корректирование при измеении размера
        {
            StatesTable.Width = this.Width - 34;
            StatesTable.Height = this.Height - StatesTable.Location.Y - 50;
            ShowStatesTable(); //Не уверен что оно тут надо
        }

        private void AddAllReactionButton_Click(object sender, EventArgs e)
        {
            List<String> Combinations = generateAllReaction();

            if (Combinations == null) return;

            if (machine.getCuntConditions() == 0) machine.addNewCondition();

            foreach (String c in Combinations)
                machine.addNewReaction(c);
            ShowStatesTable();
        }

        private List<String> generateAllReaction()
        {
            List<char> Alphabet = machine.getAlphabet();

            if (Alphabet == null || Alphabet.Count == null) return null;

            List<String> Combinations = new List<string>();

            Alphabet.Add('λ');
            Dive("", 0, in Alphabet, ref Combinations);

            if(Combinations.Count == 0) return null;
            return Combinations;
        }

        private void Dive(string prefix, int level, in List<char> Alphabet, ref List<String> Combinations)
        {

            level++;
            foreach (char c in Alphabet)
            {
                if (level == 2)
                {
                    Combinations.Add(prefix + c);
                }

                if (level < 2)
                {
                    Dive(prefix + c, level, in Alphabet, ref Combinations);
                }
            }

        }

    }
}
