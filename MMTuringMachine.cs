using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachineForm
{
    class MMTuringMachine
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
                public char SymbolOne;
                public char SymbolTwo;

                public Shift shiftOne = Shift.N;
                public Shift shiftTwo = Shift.N;

                public int NextCondition;
            }

            //public Condition(uint CountCondition, List<char> Alphabet) //Добавляем реации на символы слова при создании(одна лента)
            //{
            //    numberCondition = CountCondition;
            //    hashTable = new Hashtable();

            //    foreach (char c in Alphabet)
            //        hashTable.Add(c, new Reaction());
            //    hashTable.Add('λ', new Reaction());
            //}

            public Condition(uint CountCondition) //Добавляем реации на символы слова при создании(две ленты)
            {
                numberCondition = CountCondition;
                hashTable = new Hashtable();
                hashTable.Add("λλ", new Reaction());
            }

            public bool addNewReaction(String Option, List<char> Alphpabet)
            {
                foreach (char c in Option)
                    if (!CheckEqualsForAlphabet(c, Alphpabet)) return false;

                if (hashTable.ContainsKey(Option)) return false;
                hashTable.Add(Option, new Reaction());

                return true;
            }

            public bool dellReaction(String Option)
            {
                if (!hashTable.ContainsKey(Option)) return false;

                hashTable.Remove(Option);

                return true;
            }

            private bool CheckEqualsForAlphabet(char s, List<char> Alphabet)
            {
                foreach (char c in Alphabet)
                    if (s == c || s == 'λ') return true;
                return false;
            }

            public int getName()
            {
                return (int)numberCondition;
            }

            public String getReactionText(String aa) //Добавить возврат состояний
            {
                if (!hashTable.ContainsKey(aa)) return null;
                return ((Reaction)hashTable[aa]).SymbolOne.ToString() + ((Reaction)hashTable[aa]).SymbolTwo.ToString() + " " + ((Reaction)hashTable[aa]).shiftOne + ((Reaction)hashTable[aa]).shiftTwo + " " + (((Reaction)hashTable[aa]).NextCondition == -1 ? "!" : "q" + ((Reaction)hashTable[aa]).NextCondition);
            }

            public List<String> getAllReactionText()
            {
                if(hashTable.Values.Count == 0) return null; //Подправить

                List<String> list = new List<String>();

                foreach (DictionaryEntry entry in hashTable)
                {
                    list.Add(
                        ((Reaction)hashTable[entry.Key]).SymbolOne.ToString() + 
                        ((Reaction)hashTable[entry.Key]).SymbolTwo.ToString() + " " + 
                        ((Reaction)hashTable[entry.Key]).shiftOne + 
                        ((Reaction)hashTable[entry.Key]).shiftTwo + " " + 
                        (((Reaction)hashTable[entry.Key]).NextCondition == -1 ? "!" : "q" + ((Reaction)hashTable[entry.Key]).NextCondition));
                }
                return list;
            }

            public List<String> getAllKeysReactions()
            {
                List<String> list = new List<String>();
                foreach (DictionaryEntry entry in hashTable)
                    list.Add(entry.Key.ToString());
                return list;
            }

            public char getReactionSymbolOne(String aa) //Символы на замену
            {
                if (!hashTable.ContainsKey(aa)) return '\0';
                return ((Reaction)hashTable[aa]).SymbolOne;
            }
            public char getReactionSymbolTwo(String aa)
            {
                if (!hashTable.ContainsKey(aa)) return '\0';
                return ((Reaction)hashTable[aa]).SymbolTwo;
            }

            public Shift getReactionShiftOne(String aa) //Действия лент
            {
                if (!hashTable.ContainsKey(aa)) return Shift.Null;
                return ((Reaction)hashTable[aa]).shiftOne;
            }
            public Shift getReactionShiftTwo(String aa)
            {
                if (!hashTable.ContainsKey(aa)) return Shift.Null;
                return ((Reaction)hashTable[aa]).shiftTwo;
            }

            public int getReactionNextCondition(String aa) //Следующее состояние
            {
                if (!hashTable.ContainsKey(aa)) return (int)this.numberCondition;
                return ((Reaction)hashTable[aa]).NextCondition;
            }

            public bool set_Reaction(List<char> Alphabet, String ThisReaction, char s1, char s2, Shift shift1, Shift shift2, int nextcond) 
            {
                if (hashTable.ContainsKey(ThisReaction) == false) return false;

                ((Reaction)hashTable[ThisReaction]).SymbolOne = s1;
                ((Reaction)hashTable[ThisReaction]).SymbolTwo = s2;

                ((Reaction)hashTable[ThisReaction]).shiftOne = shift1;
                ((Reaction)hashTable[ThisReaction]).shiftTwo = shift2;

                ((Reaction)hashTable[ThisReaction]).NextCondition = nextcond;

                return true;
            }


        }

        List<Condition> Conditions = new List<Condition>();
        public int getCuntConditions()
        {
            return Conditions.Count;
        }

        List<char> WordLentOne = new List<char>();
        List<char> WordLentTwo = new List<char>();

        List<char> Alphabet = new List<char>();

        int Count_Interation = 0;

        int Current_Condition = 0;
        int Current_Position_OneLent = 0;
        int Current_Position_TwoLent = 0;

        List<String> LogsStages = new List<string>(); //Произведенные действия машины

        public void setAlphabet(String strAlphabet)
        {
            if (strAlphabet == null) return;

            Alphabet.Clear();
            Conditions.Clear();
            WordLentOne.Clear();
            WordLentTwo.Clear();
            LogsStages.Clear();

            Current_Condition = 0;
            Current_Position_OneLent = 0;
            Current_Position_TwoLent = 0;
            Count_Interation = 0;

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
                if (cont)
                    Alphabet.Add(c);
                cont = true;
            }


        }

        public bool setNewWord(String newWord)
        {
            if (newWord == null) return false;

            WordLentOne.Clear();
            WordLentTwo.Clear();

            this.Current_Position_OneLent = 0;
            this.Current_Position_TwoLent = 0;

            foreach (char s in newWord)
                if (!CheckForAlphabet(s)) return false;

            foreach (char c in newWord)
                WordLentOne.Add(c);
            WordLentTwo.Add('λ');

            return true;
        }

        public void setCurent_ConditionAndReset(uint CurCond)
        {
            Count_Interation = 0;
            Current_Condition = (int)CurCond;
            Current_Position_OneLent = 0;
            Current_Position_TwoLent = 0;
            LogsStages.Clear();
        }

        public void addNewCondition()
        {
            if(Conditions.Count == 0)
            {
                Conditions.Add(new Condition((uint)Conditions.Count));
                return;
            }

            Condition condition = new Condition((uint)Conditions.Count);
            List<List<String>> KeysConditions = getAllConditionsKeys();
            
            foreach (String str in KeysConditions[0])
                condition.addNewReaction(str, Alphabet);
            
            Conditions.Add(condition);
        }

        public void deleteLastCondition()
        {
            if (Conditions.Count == 0) return;
            Conditions.RemoveAt(Conditions.Count - 1);
        }

        public bool addNewReaction(String Reaction)
        {
            if (Reaction.Equals("λλ") || Reaction.Length != 2) return false;

            foreach (Condition con in Conditions)
                if (!con.addNewReaction(Reaction, Alphabet)) return false;

            return true;
        }

        public void deleteReactions(String Reaction)
        {
            if (Reaction.Equals("λλ") || Reaction.Length != 2) return;

            foreach(Condition con in Conditions)
                if (con.dellReaction(Reaction));
        }

        public bool setAction(uint conditionNumber, String ForOnReaction, String Symbols, Shift shift1, Shift shift2, int nextCondition)
        {
            if (Conditions.Count < conditionNumber) return false;
            if (nextCondition < -1 || nextCondition > Conditions.Count) return false;
            if (ForOnReaction.Length > Alphabet.Count || Symbols.Length > Alphabet.Count) return false;
            if (Alphabet.Count == 0) return false;

            foreach (char s in Symbols)
                if (!CheckForAlphabet(s)) return false; //Если заданных символов нету в алфавите отменяем добавлении реации

            foreach (char s in ForOnReaction)
                if (!CheckForAlphabet(s)) return false; //Если символы на которые реакция нету в алфавите возвращяем

            if (shift1 != Shift.L && shift1 != Shift.R && shift1 != Shift.N) return false; //Если не корректно выставлен shift1
            if (shift2 != Shift.L && shift2 != Shift.R && shift2 != Shift.N) return false; //Если не корректно выставлен shift2

            if(!Conditions.ElementAt((int)conditionNumber).set_Reaction(Alphabet, ForOnReaction, Symbols[0], Symbols[1], shift1, shift2, nextCondition))
            {
                foreach (Condition con in Conditions)
                    if (!con.addNewReaction(ForOnReaction, Alphabet)) return false;
                Conditions.ElementAt((int)conditionNumber).set_Reaction(Alphabet, ForOnReaction, Symbols[0], Symbols[1], shift1, shift2, nextCondition);
            }
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

        public Shift[] Next_step()
        {
            if (Conditions.Count == 0 || WordLentOne.Count == 0 || Alphabet.Count == 0 || Current_Condition == -1) return new Shift[] { Shift.Null };

            char Symbol1 = '\0';
            char Symbol2 = '\0';

            Shift shift1 = Shift.Null;
            Shift shift2 = Shift.Null;

            String ReactionString;

            int ForNextAction = -2;

            if (Current_Condition < Conditions.Count)
            {
                ReactionString = ConvertToString(WordLentOne[Current_Position_OneLent], WordLentTwo[Current_Position_TwoLent]);
                Symbol1 = Conditions.ElementAt(Current_Condition).getReactionSymbolOne(ReactionString); //Замена символа для первой ленты
                Symbol2 = Conditions.ElementAt(Current_Condition).getReactionSymbolTwo(ReactionString); //Замена символа для второй ленты

                shift1 = Conditions.ElementAt(Current_Condition).getReactionShiftOne(ReactionString); //Сдвиг первой ленты
                shift2 = Conditions.ElementAt(Current_Condition).getReactionShiftTwo(ReactionString); //Сдвиг второй ленты

                ForNextAction = (int)Conditions.ElementAt(Current_Condition).getReactionNextCondition(ReactionString); //Следующее состояние
            }


            printThisInteration();

            if (Symbol1 == '\0' || shift1 == Shift.Null || Symbol2 == '\0' || shift2 == Shift.Null)
            {
                this.Count_Interation++;
                return new Shift[] { shift1, shift2 };
            }

            //if (Current_Position_OneLent >= WordLentOne.Count) WordLentOne.Add('λ');
            //if (Current_Position_TwoLent >= WordLentTwo.Count) WordLentTwo.Add('λ');

            this.WordLentOne[Current_Position_OneLent] = Symbol1; //Выставляем символ состояния для первой ленты
            this.WordLentTwo[Current_Position_TwoLent] = Symbol2; //Выставляем символ состояния для второй ленты

            this.setCurrent_Position(shift1, shift2);

            this.Current_Condition = ForNextAction;

            this.Count_Interation++;

            return new Shift[] { shift1, shift2 };
        }

        private String ConvertToString(char s1, char s2)
        {
            return "" + s1 + s2;
        }

        public void setCurrent_Position(Shift shift1, Shift shift2)
        {
            if (WordLentOne.Count == 0) return;
            if (shift1 == Shift.L) //Сдвигаем слово первой ленты в лево
            {
                if (WordLentOne[WordLentOne.Count - 1] == 'λ')
                    WordLentOne.RemoveAt(WordLentOne.Count - 1);
                //else
                Current_Position_OneLent--;
            }
            if (shift2 == Shift.L) //Сдвигаем слово второй ленты в лево
            {
                if (WordLentTwo[WordLentTwo.Count - 1] == 'λ')
                    WordLentTwo.RemoveAt(WordLentTwo.Count - 1);
                //else
                Current_Position_TwoLent--;
            }

            if (shift1 == Shift.R) //Сдвигаем слово второй ленты в право
            {
                if (WordLentOne[0] == 'λ')
                    WordLentOne.RemoveAt(0);
                else
                    Current_Position_OneLent++;
            }
            if (shift2 == Shift.R) //Сдвигаем слово второй ленты в право
            {
                if (WordLentTwo[0] == 'λ')
                    WordLentTwo.RemoveAt(0);
                else
                    Current_Position_TwoLent++;
            }


            if (Current_Position_OneLent >= WordLentOne.Count) //Если дошли до правого края слова первой ленты добавляем лямбду
            {
                WordLentOne.Add('λ');
            }
            if (Current_Position_TwoLent >= WordLentTwo.Count) //Если дошли до правого края слова второй ленты добавляем лямбду
            {
                WordLentTwo.Add('λ');
            }

            if (Current_Position_OneLent < 0) //Если дошли до левого края слова первой ленты добавляем лямбду
            {
                WordLentOne.Insert(0, 'λ');
                Current_Position_OneLent = 0;
            }
            if (Current_Position_TwoLent < 0) //Если дошли до левого края слова второй ленты добавляем лямбду
            {
                WordLentTwo.Insert(0, 'λ');
                Current_Position_TwoLent = 0;
            }
        }

        public bool StartMachine()
        {
            int LimitInteration = 2000;
            if (Conditions.Count == 0 || WordLentOne.Count == 0 || Alphabet.Count == 0)
            {
                Console.WriteLine("Не корректный ввод данных!");
                return false;
            }

            this.printStarting_Values();

            while (Current_Condition != -1 && Count_Interation <= LimitInteration)
                Next_step();
            
            this.printThisInteration();
            this.Count_Interation++;

            if (Count_Interation >= LimitInteration)
            {
                Console.WriteLine($"Количество интераций привысило {LimitInteration}!");
                Console.WriteLine("Машина была эксртренно приостановлена!");

                return false;
            }

            Console.WriteLine("Алгоритм завершил свою работу!");

            String str = "";

            foreach (char e in WordLentOne)
                str += e;
            Console.WriteLine("Результат первой ленты: " + str);

            str = "";

            foreach (char e in WordLentTwo)
                str += e;
            Console.WriteLine("Результат второй ленты: " + str);

            return true;
        }

        public List<char> getAlphabet()
        {
            return Alphabet;
        }

        public int getCurrect_Condition()
        {
            return Current_Condition;
        }

        public List<char> getWord_OneLent()
        {
            return WordLentOne;
        }
        public List<char> getWord_TwoLent()
        {
            return WordLentTwo;
        }

        public int getCurrent_Position_OneLent()
        {
            return Current_Position_OneLent;
        }
        public int getCurrent_Position_TwoLent()
        {
            return Current_Position_TwoLent;
        }

        public String getReaction(int i, String aa) //Отредктировать
        {
            return Conditions.ElementAt(i).getReactionText(aa);
        }

        public List<List<String>> getAllConditionsText()
        {
            List<List<String>> list = new List<List<String>>();
            foreach(Condition con in Conditions)
                list.Add(con.getAllReactionText());
            

            return list;
        }

        public List<List<String>> getAllConditionsKeys()
        {
            List<List<String>> list = new List<List<String>>();
            foreach (Condition con in Conditions)
                list.Add(con.getAllKeysReactions());

            return list;
        }

        public int getCountInteration()
        {
            return Count_Interation;
        }

        public List<string> getLogsStages()
        {
            return LogsStages;
        }

        public void printThisInteration()
        {
            String str = "";

            for (int i = 0; i < WordLentOne.Count; i++)
            {
                if (i == Current_Position_OneLent)
                    str += "q" + Convert_to_Subscript(Current_Condition.ToString()); //Conditions.ElementAt(Current_Condition).getName()
                str += WordLentOne[i];
            }

            str += '\t';

            for (int i = 0; i < WordLentTwo.Count; i++)
            {
                if (i == Current_Position_TwoLent)
                    str += "q" + Convert_to_Subscript(Current_Condition.ToString());
                str += WordLentTwo[i];
            }
            LogsStages.Add(str);

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

            foreach (char e in WordLentOne)
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
                    streamW.Write(c);
                }

                streamW.Write("\nConditions:");

                List<List<String>> ConditionsKeys = getAllConditionsKeys();

                foreach (String Keys in ConditionsKeys[0])
                {
                    if (Keys.Equals("λλ")) continue;
                    streamW.Write('\t' + Keys);
                }

                streamW.WriteLine('\t' + "λλ");

                foreach (Condition cond in Conditions)
                {
                    streamW.Write(cond.getName());

                    foreach (String Keys in ConditionsKeys[0])
                    {
                        if (Keys.Equals("λλ")) continue;
                        streamW.Write('\t' + cond.getReactionText(Keys));
                    }
                    streamW.WriteLine('\t' + cond.getReactionText("λλ"));
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

                        for (int i = 1; i < SplitString.Length; i++)
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

            } catch (NullReferenceException ex) { return false; }

            

            foreach (String Key in SetKeysForConditions)
            {
                if (Key.Length != 2) return false;
                foreach (char k in Key)
                    if (!EqualsForChars(k, SetAlphabet)) return false;
            }

            foreach (List<String> Reactions in SetConditionsReactions)
                if (Reactions.Count != SetKeysForConditions.Count) return false;

            foreach(List<String> Reactions in SetConditionsReactions)
            {
                foreach(String reaction in Reactions)
                {
                    if(reaction.Length < 7) return false;
                    if (!EqualsForChars(reaction[0], SetAlphabet)) return false;
                    if (!EqualsForChars(reaction[1], SetAlphabet)) return false;

                    if (reaction[3] != 'L' && reaction[3] != 'R' && reaction[3] != 'N') return false;
                    if (reaction[4] != 'L' && reaction[4] != 'R' && reaction[4] != 'N') return false;

                    if (reaction[6] == '!' && reaction.Length != 7) return false;
                    else if (reaction[6] == 'q')
                    {
                        if (reaction.Length < 8) return false;
                        
                        String NumberNextCondition = "";
                        for (int n = 7; n < reaction.Length; ++n)
                            NumberNextCondition += reaction[n];
                        try
                        {
                            if(Convert.ToInt32(NumberNextCondition) < 0) return false;
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

            for(int i = SetKeysForConditions.Count-1; i >= 0; --i) //Пришлось развернуть для нормальной записи
                addNewReaction(SetKeysForConditions[i]);
            //foreach (String key in SetKeysForConditions)
            //    addNewReaction(key);
                

            for(int i = 0; i < SetConditionsReactions.Count; ++i)
            {
                int j = 0;
                foreach (String reaction in SetConditionsReactions[i])
                {
                    if (reaction[0] == '\0' || reaction[1] == '\0')
                    {
                        j++;
                        continue;
                    }
                    
                    int ConditionNumber = i;
                    String ForOnReaction = SetKeysForConditions[j++];
                    String Symbols = "" + reaction[0] + reaction[1];

                    Shift shif1 = getShiftForChar(reaction[3]);
                    Shift shift2 = getShiftForChar(reaction[4]);

                    int NextCondition = -1;

                    if (reaction[6] == '!')
                        NextCondition = -1;
                    else if (reaction[6] == 'q')
                    {
                        String NumberNextCondition = "";
                        for (int n = 7; n < reaction.Length; ++n)
                            NumberNextCondition += reaction[n];

                        NextCondition = Convert.ToInt32(NumberNextCondition);
                    }

                    setAction((uint)ConditionNumber, ForOnReaction, Symbols, shif1, shift2, NextCondition);
                }
            }

            return true;
        }

        private bool EqualsForChars(char key, String Alphabet)
        {
            foreach(char c in Alphabet)
                if(c == key || c == 'λ' || c == '\0') return true;
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
