using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachineForm
{
    class TuringMachine
    {

        public enum Shift
        {
            L,
            R,
            N,
            Null
        }

        private class Condition //Состояния
        {
            uint numberCondition;
            Hashtable hashTable;

            private class Reaction //Реакция на символ слова
            {
                public char Symbol;
                public Shift shift = Shift.N;
                public int NextCondition;
            }

            public Condition(uint CountCondition, List<char> word) //Добавляем реации на символы слова при создании
            {
                numberCondition = CountCondition;
                hashTable = new Hashtable();

                foreach (char c in word)
                    hashTable.Add(c, new Reaction());
                hashTable.Add('λ', new Reaction());
            }

            public int getName()
            {
                return (int)numberCondition;
            }

            public String getReactionText(char a)
            {
                if (!hashTable.ContainsKey(a)) return null;
                return ((Reaction)hashTable[a]).Symbol + " " + ((Reaction)hashTable[a]).shift + " " + (((Reaction)hashTable[a]).NextCondition == -1 ? "!" : "q" + ((Reaction)hashTable[a]).NextCondition);
            }

            public char getReactionSymbol(char a)
            {
                if (!hashTable.ContainsKey(a)) return '\0';
                return ((Reaction)hashTable[a]).Symbol;
            }
            public Shift getReactionShift(char a)
            {
                if (!hashTable.ContainsKey(a)) return Shift.Null;
                return ((Reaction)hashTable[a]).shift;
            }
            public int getReactionNextCondition(char a)
            {
                if (!hashTable.ContainsKey(a)) return (int)this.numberCondition;
                return ((Reaction)hashTable[a]).NextCondition;
            }

            public void setReaction(char ThisReaction, char s, Shift shift, int nextcond)
            {
                ((Reaction)hashTable[ThisReaction]).Symbol = s;
                ((Reaction)hashTable[ThisReaction]).shift = shift;
                ((Reaction)hashTable[ThisReaction]).NextCondition = nextcond;
            }


        }

        List<Condition> Conditions = new List<Condition>();
        public int getCuntConditions()
        {
            return Conditions.Count;
        }

        List<char> Word = new List<char>();
        List<char> Alphabet = new List<char>();

        int Current_Condition = 0;
        int Current_Position = 0;
        int Count_Interation = 0;

        List<String> LogsStages = new List<string>();
        public int getCurrect_Action()
        {
            return Current_Condition;
        }

        public void setAlphabet(String strAlphabet)
        {
            if (strAlphabet == null) return;

            Alphabet.Clear();
            Conditions.Clear();
            bool cont = true;
            foreach (char c in strAlphabet) //Записываем алфавит убирая повторения
            {
                foreach (char s in Alphabet)
                {
                    if (c == s)
                    {
                        cont = false;
                        break;
                    }
                    
                }
                if(cont)
                Alphabet.Add(c);
                cont = true;
            }
                
                
        }

        public bool setNewWord(String newWord)
        {
            if (newWord == null) return false;

            foreach (char c in newWord)
                if (!CheckForAlphabet(c)) return false;

            Word.Clear();
            this.Current_Position = 0;
            foreach (char c in newWord)
                Word.Add(c);
            return true;
        }

        public bool CheckForAlphabet(char s) //Проверяем наличие символа в алфавите
        {
            foreach (char c in Alphabet)
            {
                if (c == s || s == 'λ') return true;
            }
            return false;
        }

        public void setCurent_ConditionAndReset(uint CurCond) 
        {
            Count_Interation = 0;
            Current_Condition = (int)CurCond;
            Current_Position = 0;
            LogsStages.Clear();
        }

        public void addNewCondition()
        {
            Conditions.Add(new Condition((uint)Conditions.Count, Alphabet));
        }

        public void deleteLastCondition()
        {
            if (Conditions.Count == 0) return;
            Conditions.RemoveAt(Conditions.Count-1);
        }

        public void setAction(uint conditionNumber, char ForSymbolReaction, char Symbol, Shift shift, int nextCondition)
        {
            if (Conditions.Count < conditionNumber) return;
            if (nextCondition < -1) return;

            if (!CheckForAlphabet(ForSymbolReaction)) return;
            if (!CheckForAlphabet(Symbol)) return;

            if (shift != Shift.L && shift != Shift.R && shift != Shift.N) return; //Если не корректно выставлен shift

            Conditions.ElementAt((int)conditionNumber).setReaction(ForSymbolReaction, Symbol, shift, nextCondition);
        }

        public Shift Next_step()
        {
            if (Conditions.Count == 0 || Word.Count == 0 || Alphabet.Count == 0 || Current_Condition == -1) return Shift.Null;

            char Symbol = '\0';
            
            Shift shift = Shift.Null;
            
            int ForNextAction = -1;
            
            if (Current_Condition < Conditions.Count)
            {
                Symbol = Conditions.ElementAt(Current_Condition).getReactionSymbol(Word[Current_Position]);
                shift = Conditions.ElementAt(Current_Condition).getReactionShift(Word[Current_Position]);
                ForNextAction = (int)Conditions.ElementAt(Current_Condition).getReactionNextCondition(Word[Current_Position]);
            }

            printThisInteration();

            if (Symbol == '\0' || shift == Shift.Null)
            {
                this.Count_Interation++;
                return shift;
            }

            this.Word[Current_Position] = Symbol;

            this.setCurrent_Position(shift);

            this.Current_Condition = ForNextAction;

            this.Count_Interation++;

            return shift;
        }

        public bool StartMachine()
        {
            if (Conditions.Count == 0 || Word.Count == 0 || Alphabet.Count == 0)
            {
                Console.WriteLine("Не корректный ввод данных!");
                return false;
            }

            this.printStarting_Values();

            while (Current_Condition != -1 && Count_Interation <= 2000)
                Next_step();
            
            this.printThisInteration();
            this.Count_Interation++;

            if (Count_Interation >= 2000)
            {
                Console.WriteLine("Количество интераций привысило 2000!");
                Console.WriteLine("Машина была эксртренно приостановлена!");

                return false;
            }

            Console.WriteLine("Алгоритм завершил свою работу!");

            String str = "";

            foreach (char e in Word)
                str += e;
            Console.WriteLine("Результат: " + str);

            return true;
        }

        public List<char> getWord()
        {
            return Word;
        }
        public List<char> getAlphabet()
        {
            return Alphabet;
        }

        public int getCurrent_Position()
        {
            return Current_Position;
        }
        public String getReaction(int i, char a)
        {
            return Conditions.ElementAt(i).getReactionText(a);
        }
        public int getCountInteration()
        {
            return Count_Interation;
        }

        public List<string> getLogsStages()
        {
            return LogsStages;
        }
        public void setCurrent_Position(Shift shift)
        {
            if (Word.Count == 0) return;
            if (shift == Shift.L)
            {
                
                if (Word[Word.Count - 1] == 'λ')
                    Word.RemoveAt(Word.Count - 1);
                //else
                    Current_Position--;


            }
                
            else if (shift == Shift.R)
            {
                if (Word[0] == 'λ')
                    Word.RemoveAt(0);
                else
                Current_Position++;

            }
                

            if (Current_Position >= Word.Count)
            {

                Word.Add('λ');
            }
                
            if (Current_Position < 0)
            {
                Word.Insert(0, 'λ');
                Current_Position = 0;
            }
        }

        public void printThisInteration()
        {
            String str = "";

            for (int i = 0; i < Word.Count; i++)
            {
                if (i == Current_Position)
                    str += "q" + Convert_to_Subscript(Current_Condition.ToString());
                str += Word[i];
            }
            LogsStages.Add(str);
            //Console.WriteLine(str);
        }

        private String Convert_to_Subscript(String str)
        {
            String Result = "";
            foreach(char c in str)
            {
                if (c == '0') Result += '\x2080';
                if (c == '1') Result += '\x2081';
                if (c == '2') Result += '\x2082';
                if (c == '3') Result += '\x2083';
                if (c == '4') Result += '\x2084';
                if (c == '5') Result += '\x2085';
                if (c == '6') Result += '\x2086';
                if (c == '7') Result += '\x2087';
                if (c == '8') Result += '\x2088';
                if (c == '9') Result += '\x2089';
            }

            return Result;
        }

        public void printStarting_Values()
        {
            String str = "";

            foreach (char e in Word)
                str += e;

            Console.WriteLine("Текущее слово: " + str);

            str = "";

            foreach (char e in Alphabet)
                str += e;
            Console.WriteLine("Текущий алфавит: " + str);
        }

        public void SaveStagesInFile(String path)
        {
            //String path = @"C:\Users\1\source\repos\TuringMachineForm\File.txt";
            //using (System.IO.FileStream fileStream = new System.IO.FileStream(path, System.IO.FileMode.Append))
            using (System.IO.StreamWriter streamW = new System.IO.StreamWriter(path, false))
            {
                streamW.Write("Alphabet:");
                foreach (char c in Alphabet)
                {
                    streamW.Write(c.ToString());
                }

                streamW.Write("\nConditions:");

                foreach (char Keys in Alphabet)
                {
                    if (Keys == 'λ') continue;
                    streamW.Write('\t' + Keys.ToString());
                }

                streamW.WriteLine("\tλ");

                foreach (Condition cond in Conditions)
                {
                    streamW.Write(cond.getName());

                    foreach (char Keys in Alphabet)
                    {
                        if (Keys == 'λ') continue;
                        streamW.Write('\t' + cond.getReactionText(Keys).ToString());
                    }
                    streamW.WriteLine('\t' + cond.getReactionText('λ').ToString());
                }

            }
        }

        public bool ReadStagesInFile(String path)
        {
            //String path = @"C:\Users\1\source\repos\TuringMachineForm\File.txt";

            String SetAlphabet = "";
            List<String> SetKeysForConditions = new List<String>();
            List<List<String>> SetConditionsReactions = new List<List<String>>();

            try
            {

                using (System.IO.StreamReader streamR = new System.IO.StreamReader(path, false))
                {
                    String AlphabetForFile = streamR.ReadLine();
                    String KeysConditionsForFile = streamR.ReadLine();


                    String str = "";

                    foreach (char c in AlphabetForFile)
                    {
                        if (!str.Equals("Alphabet:"))
                            str += c;
                        else
                        {
                            SetAlphabet += c;
                        }
                    }

                    String[] SplitStringForKeys = KeysConditionsForFile.Split('\t');

                    foreach (String key in SplitStringForKeys)
                    {
                        if (key.Equals("Conditions:")) continue;
                        SetKeysForConditions.Add(key);
                    }

                    str = "";
                    while ((str = streamR.ReadLine()) != null)
                    {
                        String[] SplitString = str.Split('\t');

                        List<String> ReactionsOnCondition = new List<string>();

                        for (int i = 1; i < SplitString.Length; ++i)
                        {
                            ReactionsOnCondition.Add(SplitString[i]);
                        }
                        //foreach (String s in SplitString)
                        //{
                        //    if (s.Length == 1) continue;
                        //    ReactionsOnCondition.Add(s);
                        //}

                        SetConditionsReactions.Add(ReactionsOnCondition);
                    }

                }

            } catch(NullReferenceException ex) { return false; }

            

            foreach (String Key in SetKeysForConditions)
            {
                if (Key.Length != 1) return false;
                foreach (char k in Key)
                    if (!EqualsForChars(k, SetAlphabet)) return false;
            }

            foreach (List<String> Reactions in SetConditionsReactions)
                if (Reactions.Count != SetKeysForConditions.Count) return false;

            foreach (List<String> Reactions in SetConditionsReactions)
            {
                foreach (String reaction in Reactions)
                {
                    if (reaction.Length < 5) return false;
                    if (!EqualsForChars(reaction[0], SetAlphabet)) return false;

                    if (reaction[2] != 'L' && reaction[2] != 'R' && reaction[2] != 'N') return false;

                    if (reaction[4] == '!' && reaction.Length != 5) return false;
                    else if (reaction[4] == 'q')
                    {
                        if (reaction.Length < 6) return false;

                        String NumberNextCondition = "";
                        for (int n = 5; n < reaction.Length; ++n)
                            NumberNextCondition += reaction[n];
                        try
                        {
                            if (Convert.ToInt32(NumberNextCondition) < 0) return false;
                        }
                        catch (FormatException ex)
                        {
                            return false;
                        }
                    }

                }
            }

            setAlphabet(SetAlphabet);

            for (int i = 0; i < SetConditionsReactions.Count; ++i)
                addNewCondition();

            //for (int i = SetKeysForConditions.Count - 1; i >= 0; --i) //Пришлось развернуть для нормальной записи
            //    addNewReaction(SetKeysForConditions[i]);
            
            //foreach (String key in SetKeysForConditions)
            //    addNewReaction(key);


            for (int i = 0; i < SetConditionsReactions.Count; ++i)
            {
                int j = 0;
                foreach (String reaction in SetConditionsReactions[i])
                {
                    if (reaction[0] == '\0')
                    {
                        j++;
                        continue;
                    }

                    int ConditionNumber = i;
                    char ForOnReaction = SetKeysForConditions[j++][0];
                    char Symbol = reaction[0];

                    Shift shif = getShiftForChar(reaction[2]);

                    int NextCondition = -1;

                    if (reaction[4] == '!')
                        NextCondition = -1;
                    else if (reaction[4] == 'q')
                    {
                        String NumberNextCondition = "";
                        for (int n = 5; n < reaction.Length; ++n)
                            NumberNextCondition += reaction[n];

                        NextCondition = Convert.ToInt32(NumberNextCondition);
                    }

                    setAction((uint)ConditionNumber, ForOnReaction, Symbol, shif, NextCondition);
                }
            }

            return true;
        }

        private bool EqualsForChars(char key, String Alphabet)
        {
            foreach (char c in Alphabet)
                if (c == key || c == 'λ' || c == '\0') return true;
            return true;
        }

        private Shift getShiftForChar(char s)
        {
            if (s == 'L' || s == 'l') return Shift.L;
            if (s == 'R' || s == 'r') return Shift.R;
            if (s == 'N' || s == 'n') return Shift.N;
            return Shift.Null;
        }

    }
}
