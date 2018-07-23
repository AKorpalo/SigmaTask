using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTasks
{
    class Chapter_9
    {
        public static void Task_9_41(string name)
        {
            Console.WriteLine("Task 9.41: ");
            Console.WriteLine($"Слово {name} стовпцем:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"\t\t\t{name[i]}");
            }
        }
        public static void Task_9_42(string name)
        {
            Console.WriteLine("Task 9.42: ");
            Console.Write($"Слово {name} починаючи з останьої букви: ");
            Console.Write($"{name[name.Length - 1]}");
            for (int i = 0; i < name.Length - 1; i++)
            {
                Console.Write($"{name[i]}");
            }
            Console.Write("\n");
        }
        public static void Task_9_43(string name)
        {
            Console.WriteLine("Task 9.43: ");
            Console.Write($"Слово {name} тiльки з непарних букв: ");
            for (int i = 0; i < name.Length; i += 2)
            {
                Console.Write($"{name[i]}");
            }
            Console.Write("\n");
        }
        public static void Task_9_44(string name)
        {
            Console.WriteLine("Task 9.44: ");
            Console.Write($"Слово {name} з права на лiво: ");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write($"{name[i]}");
            }
            Console.Write("\n");
        }
        public static void Task_9_45()
        {
            Console.WriteLine("Task 9.45: ");
            Console.Write($"5 зiрочок: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"*");
            }
            Console.Write("\n");
        }
        public static void Task_9_46()
        {
            Console.WriteLine("Task 9.46: ");
            Console.Write($"8 _: ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"_");
            }
            Console.Write("\n");
        }
        public static void Task_9_47(int number, char symbol)
        {
            Console.WriteLine("Task 9.47: ");
            Console.Write($"Символ {symbol} {number} раз: ");
            char[] arr = new char[number];
            for (int i = 0; i < number; i++)
            {
                arr[i] = symbol;
            }
            string d = new string(arr);
            Console.Write(d);
            Console.Write("\n");
        }
        public static void Task_9_48(string word)
        {
            Console.WriteLine("Task 9.48: ");
            Console.Write($"Слово {word} з + i -: ");
            char[] arr = new char[word.Length + 9];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 4)
                    arr[i] = '+';
                else if (i < 4 + word.Length)
                    arr[i] = word[i - 4];
                else arr[i] = '-';
            }
            string s = new string(arr);
            Console.Write(s);
            Console.Write("\n");
        }
        public static void Task_9_49(string word)
        {
            Console.WriteLine("Task 9.48: ");
            Console.Write($"Слово {word} з *: ");
            char[] arr = new char[word.Length * 3];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < word.Length)
                    arr[i] = '*';
                else if (i < word.Length * 2)
                    arr[i] = word[i - word.Length];
                else arr[i] = '*';
            }
            string s = new string(arr);
            Console.Write(s);
            Console.Write("\n");
        }
        public static void Task_9_50(string word1, string word2)
        {
            Console.WriteLine("Task 9.50: ");
            Console.Write($"Перше слово: {word1}, друге слово: {word2} з *: ");
            char[] arr = new char[word2.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = word1[i];
            }
            string s = new string(arr);
            Console.Write(s);
            Console.Write("\n");
        }
        public static void Task_9_51(string word)
        {
            Console.WriteLine("Task 9.51: ");
            Console.Write($"Всi букви \'и\' речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'и')
                    Console.Write(word[i]);
            }
            Console.Write("\n");
        }
        public static void Task_9_52(string word, char symbol)
        {
            Console.WriteLine("Task 9.52: ");
            Console.WriteLine($"Всi символи \'{symbol}\' речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                    Console.WriteLine(word[i]);
            }
        }
        public static void Task_9_53(string word)
        {
            Console.WriteLine("Task 9.53: ");
            Console.WriteLine($"Речення \"{word}\": ");
            for (int i = 2; i < word.Length; i += 3)
            {
                Console.WriteLine(word[i]);
            }
        }
        public static void Task_9_54(string word)
        {
            Console.WriteLine("Task 9.54: ");
            Console.Write($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'н' || word[i] == 'м')
                    Console.Write(word[i]);
            }
            Console.Write("\n");
        }
        public static void Task_9_55(string word, char symbol1, char symbol2)
        {
            Console.WriteLine("Task 9.55: ");
            Console.Write($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol1 || word[i] == symbol2)
                    Console.Write(word[i]);
            }
            Console.Write("\n");
        }
        public static void Task_9_56(string word)
        {
            Console.WriteLine("Task 9.56: ");
            Console.Write($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'н' && word[i + 1] == 'н')
                    Console.Write("{0}{1}", word[i], word[i + 1]);
            }
            Console.Write("\n");
        }
        public static void Task_9_57(string word)
        {
            Console.WriteLine("Task 9.57: ");
            Console.WriteLine($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'и' && (i + 1) % 2 == 0)
                    Console.WriteLine(word[i]);
            }
        }
        public static void Task_9_58(string word)
        {
            Console.WriteLine("Task 9.58: ");
            Console.WriteLine($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i += 4)
            {
                Console.WriteLine(word[i]);
                if (i + 1 < word.Length)
                    Console.WriteLine(word[i + 1]);
            }
        }
        public static void Task_9_59to9_61(string word, char symbol)
        {
            Console.WriteLine("Task 9.59-9.61: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int o = 0;
            int prob = 0;
            int symbol1 = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'о')
                    o++;
                if (word[i] == ' ')
                    prob++;
                if (word[i] == symbol)
                    symbol1++;
            }
            Console.WriteLine($"Кiлькiсть букв о = {o}");
            Console.WriteLine($"Кiлькiсть пробiлiв = {prob}");
            Console.WriteLine($"Кiлькiсть символiв {symbol} = {symbol1}");
        }
        public static void Task_9_62(string word)
        {
            Console.WriteLine("Task 9.62: ");
            Console.WriteLine($"Речення \"{word}\": ");
            double a = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'а')
                    a++;
            }
            Console.WriteLine($"Кiлькiсть букв а у % = {(a * 100) / word.Length}%");
        }
        public static void Task_9_63(string word)
        {
            Console.WriteLine("Task 9.63: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int o = 0;
            int prob = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '+')
                    o++;
                if (word[i] == '-')
                    prob++;

            }
            Console.WriteLine($"Кiлькiсть + = {o}");
            Console.WriteLine($"Кiлькiсть - = {prob}");
        }
        public static void Task_9_64(string word)
        {
            Console.WriteLine("Task 9.64: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1] && char.IsLetter(word[i]))
                    if (i - 1 >= 0 && word[i - 1] != word[i])
                        count++;
            }
            Console.WriteLine($"Однакових пiдряд букв = {count}");
        }
        public static void Task_9_65(string word, string s2, string s)
        {
            Console.WriteLine("Task 9.65: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == 'р' && word[i + 1] == 'о')
                    count1++;
                if (word[i] == s2[0] && word[i + 1] == s2[1])
                    count2++;
                if (word[i] == s[0])
                    for (int j = i; j < i + s.Length; j++)
                    {
                        if (j < word.Length)
                            if (word[j] != s[j - i])
                                break;
                            else
                            {
                                if (j == i + s.Length - 1)
                                    count3++;
                            }
                        else break;
                    }

            }
            Console.WriteLine($"Кiлькiсть буквосполучення ро = {count1}");
            Console.WriteLine($"Кiлькiсть буквосполучення {s2} = {count2}");
            Console.WriteLine($"Кiлькiсть буквосполучення {s} = {count3}");
        }
        public static void Task_9_66(string word)
        {
            Console.WriteLine("Task 9.66: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                    count++;
            }
            Console.WriteLine($"Кiлькiсть слiв = {count}");
        }
        public static void Task_9_67(string word)
        {
            Console.WriteLine("Task 9.67: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (i + 1 == word.Length)
                        count++;
                    else if (!char.IsLetter(word[i + 1]))
                        count++;
                }
            }
            Console.WriteLine($"Кiлькiсть слiв = {count}");
        }
        public static void Task_9_68(string word)
        {
            Console.WriteLine("Task 9.68: ");
            Console.WriteLine($"Текст \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '+' || word[i] == '-')
                {
                    count++;
                }
            }
            Console.WriteLine($"Кiлькiсть + i - = {count}");
        }
        public static void Task_9_69(string word)
        {
            Console.WriteLine("Task 9.69: ");
            Console.WriteLine($"Текст \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '.' || word[i] == '!' || word[i] == '?')
                {
                    count++;
                }
            }
            Console.WriteLine($"Кiлькiсть речень = {count}");
        }
        public static void Task_9_70(string word)
        {
            Console.WriteLine("Task 9.70: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'а': count++; break;
                    case 'о': count++; break;
                    case 'у': count++; break;
                    case 'і': count++; break;
                    case 'и': count++; break;
                    case 'е': count++; break;
                    case 'я': count++; break;
                    case 'ю': count++; break;
                    case 'є': count++; break;
                    case 'ї': count++; break;
                }
            }
            Console.WriteLine($"Кiлькiсть голосних букв = {count}");
        }
        public static void Task_9_71(string word)
        {
            Console.WriteLine("Task 9.71: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'м': count++; break;
                    case 'н': count1++; break;
                }
            }
            if (count > count1)
                Console.WriteLine($"Букв м бiльше нiж букв н.");
            else Console.WriteLine($"Букв н бiльше нiж букв м.");
        }
        public static void Task_9_72(string word)
        {
            Console.WriteLine("Task 9.72: ");
            Console.WriteLine($"Речення \"{word}\": ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    if (i + 1 == word.Length)
                        count++;
                    else if (!char.IsLetter(word[i + 1]))
                        count++;
                }
            }
            if (count > 3)
                Console.WriteLine($"Кiлькiсть слiв бiльше 3");
            else Console.WriteLine($"Кiлькiсть слiв менше або дорiвнює 3");
        }
        public static void Task_9_73(string word)
        {
            Console.WriteLine("Task 9.73: ");
            Console.WriteLine($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {

            }
            Console.WriteLine($"Кiлькiсть слiв менше або дорiвнює 3");
        }
        public static void Task_9_74(string word)
        {
            Console.WriteLine("Task 9.74: ");
            Console.WriteLine($"Речення \"{word}\": ");
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (j + i < word.Length)
                    {
                        if (word[j+i] != word[i])
                            break;
                        else
                        {
                            if (j == 4)
                            {
                                Console.WriteLine("Так у реченi є символ який зустрiчається 5 разiв пiдряд.");
                                i = word.Length + 1;
                                break;
                            }
                        }
                    }
                }
                if(i == word.Length-1)
                    Console.WriteLine("Нi у реченi немає символа який зустрiчається 5 разiв пiдряд.");
            }
        }
        public static void Task_9_75(string word)
        {
            Console.WriteLine("Task 9.75: ");
            Console.Write($"Речення \"{word}\", всi символи до першої коми: ");
            if(word.IndexOf(',') == -1)
                Console.Write("Коми в реченi немає.");
            else
                for (int i = 0; i < word.IndexOf(','); i++)
                {
                    Console.Write(word[i]);
                }
            Console.Write("\n");
        }
        public static void Task_9_76(string word)
        {
            Console.WriteLine("Task 9.76: ");
            Console.WriteLine($"Речення \"{word}\",: ");
            if (word.IndexOf('е') != -1)
                Console.WriteLine($"Номер першого входження букви е = {word.IndexOf('е')}");
            else Console.WriteLine("Букви е в речені немає.");
            if (word.LastIndexOf('е') != -1)
                Console.WriteLine($"Номер останього входження букви е = {word.LastIndexOf('е')}");
        }
        public static void Task_9_77(string word)
        {
            Console.WriteLine("Task 9.77: ");
            Console.WriteLine($"Речення \"{word}\",: ");
            if (word.IndexOf('а') != -1)
                Console.WriteLine($"Номер першого входження букви а = {word.IndexOf('а')}");
            else Console.WriteLine("Букви а в речені немає.");
        }
        public static void Task_9_78(string w)
        {
            Console.WriteLine("Task 9.78: ");
            Console.Write($"Слово \"{w}\",: ");
            string word = w.ToLower();
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length - (i + 1)])
                {
                    Console.WriteLine("Слово не палiндром.");
                    i = word.Length + 1;
                    break;
                }
                if(i == word.Length / 2-1)
                    Console.WriteLine("Слово палiндром.");
            }
        }
        public static void Task_9_90to9_91(string w)
        {
            Console.WriteLine("Task 9.90: ");
            Console.WriteLine($"Слово \"{w}\", букви е замiнити на букви и: {w.Replace('е','и')}");
            Console.WriteLine("Task 9.90: ");
            Console.WriteLine($"Слово \"{w}\", символи \' \' замiнити на символи \'_\': {w.Replace(' ', '_')}");
        }
        public static void Task_9_92(string w)
        {
            Console.WriteLine("Task 9.92: ");
            Console.Write($"Речення \"{w}\",: ");
            char[] arr = w.ToCharArray();
            for (int i = 1; i < w.Length; i+=2)
            {
                arr[i] = 'ы';
            }
            string s = new string(arr);
            Console.WriteLine($"Змiнене речення: {s}");
        }
        public static void Task_9_93(string w)
        {
            Console.WriteLine("Task 9.93: ");
            Console.Write($"Речення \"{w}\",: ");
            char[] arr = w.ToCharArray();
            for (int i = 2; i < w.Length; i += 3)
            {
                arr[i] = 'а';
            }
            string s = new string(arr);
            Console.WriteLine($"Змiнене речення: {s}");
        }
        public static void Task_9_94(string w)
        {
            Console.WriteLine("Task 9.94: ");
            Console.WriteLine($"Речення \"{w}\", змiнене: {w.Replace("ах","ух")}");
        }
        public static void Task_9_95t09_98(string w,string s1,string s2)
        {
            Console.WriteLine("Task 9.95: ");
            Console.WriteLine($"Речення \"{w}\", замiнене: {w.Replace("да", "не")}");
            Console.WriteLine("Task 9.96: ");
            Console.WriteLine($"Речення \"{w}\", замiнене: {w.Replace("про", "нет")}");
            Console.WriteLine("Task 9.97: ");
            Console.WriteLine($"Речення \"{w}\", замiнене: {w.Replace("бит", "рог")}");
            Console.WriteLine("Task 9.98: ");
            Console.WriteLine($"Речення \"{w}\", замiнене: {w.Replace(s1, s2)}");
        }
        public static void Task_9_99(string w)
        {
            Console.WriteLine("Task 9.99: ");
            char[] s = w.ToCharArray();
            s[1] = 'п';
            s[3] = 'ч';
            string str = new string(s);
            Console.WriteLine($"Слово \"{w}\", замiнене: {str}");
        }
        public static void Task_9_100to9_102(string w,int first,int last)
        {
            Console.WriteLine("Task 9.100: ");
            char[] s = w.ToCharArray();
            char temp;
            string str;
            if (w.Length > 4)
            {
                temp = s[1];
                s[1] = s[4];
                s[4] = temp;
                str = new string(s);
                Console.WriteLine($"Слово \"{w}\", замiнене: {str}");
            }
            else Console.WriteLine("Слово замале");

            Console.WriteLine("Task 9.101: ");
            s = w.ToCharArray();
            if (w.Length > 3)
            {
                temp = s[2];
                s[2] = s[s.Length - 1];
                s[s.Length - 1] = temp;
                str = new string(s);
                Console.WriteLine($"Слово \"{w}\", замiнене: {str}");
            }
            else Console.WriteLine("Слово замале");

            Console.WriteLine("Task 9.102: ");
            s = w.ToCharArray();
            if (first > 0 && first < w.Length - 1 && last > 0 && last < w.Length - 1)
            {
                temp = s[first + 1];
                s[first + 1] = s[last + 1];
                s[last + 1] = temp;
                str = new string(s);
                Console.WriteLine($"Слово \"{w}\", замiнене: {str}");
            }
            else Console.WriteLine("Індекси не підходять");
        }
        public static void Task_9_103(string w)
        {
            Console.WriteLine("Task 9.103: ");
            char[] s = w.ToCharArray();
            char temp;
            for (int i = 0; i < s.Length-1; i+= 2)
            {
                temp = s[i];
                s[i] = s[i+1];
                s[i+1] = temp;
            }
            string str = new string(s);
            Console.WriteLine($"Слово \"{w}\", замiнене: {str}");
        }
        public static void Task_9_104(string word)
        {
            Console.WriteLine("Task 9.104: ");
            char[] s = word.ToCharArray();
            char temp;
            for (int i = 0; i < word.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - (i + 1)];
                s[s.Length - (i + 1)] = temp;
            }
            string str = new string(s);
            Console.WriteLine($"Слово \"{word}\" замiнене: {str}");
        }
        public static void Task_9_138(char word)
        {
            Console.WriteLine("Task 9.138: ");
            if(char.IsNumber(word))
            Console.WriteLine($"Символ {word} є цифрою.");
            else Console.WriteLine($"Символ {word} не є цифрою.");
        }
        public static void Task_9_139(string word)
        {
            Console.WriteLine("Task 9.139: ");
            Console.Write($"Речення {word} має такi цифри: ");
            for (int i = 0; i < word.Length; i++)
            {
                if(Char.IsNumber(word[i]))
                    Console.Write($"{word[i]}");
            }
            Console.Write("\n");
        }
        public static void Task_9_140(string word)
        {
            Console.WriteLine("Task 9.140: ");
            Console.Write($"Речення {word} має стiльки цифр: ");
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsNumber(word[i]))
                    count++;
            }
            Console.Write($"{count}\n");
        }
        public static void Task_9_141(string word)
        {
            Console.WriteLine("Task 9.141: ");
            Console.Write($"Сума цифр в речення {word}: ");
            double count = 0;
            int max = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (Char.IsNumber(word[i]))
                {
                    count += char.GetNumericValue(word[i]);
                    if (char.GetNumericValue(word[max]) < Char.GetNumericValue(word[i]))
                        max = i;
                }
            }
            Console.Write($"{count}\n");
            Console.WriteLine($"Максимальне число = {char.GetNumericValue(word[max])}");
        }
        public static void Task_9_142(string word)
        {
            Console.WriteLine("Task 9.142: ");
            Console.Write($"Речення {word}: ");
            int max = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    if (char.GetNumericValue(word[max]) < Char.GetNumericValue(word[i]))
                        max = i;
                }
            }
            Console.WriteLine($"Номер максимального числа = {max}");
        }
        public static void Task_9_143(string word)
        {
            Console.WriteLine("Task 9.143: ");
            Console.Write($"Слово {word} є правильним десятичним записом цiлого числа?  ");
            if (!Char.IsNumber(word[0]))
            {
                Console.WriteLine("Нi");
            }
            else if (word[word.Length - 1] == '0' && word[word.Length - 2] == '.')
            {
                Console.WriteLine("Так");
            }
            else
            {
                Console.WriteLine("Нi");
            }
        }
        public static void Task_9_152to9_153(string word)
        {
            Console.WriteLine("Task 9.152 - 9.153: ");
            int count = 0;
            int temp = 1;
            for (int i = 0; i < word.Length-1; i++)
            {
                count = 0;
                while (word[i] == word[i + count] && i+count < word.Length )
                {
                    count++;
                }
                if (temp < count)
                {
                    temp = count;
                    i += count - 1;
                }
                else
                {
                    i += count - 1;
                }
            }
            Console.WriteLine($"У реченi {word} повторюється пiдряд символи максимум {temp} разiв. ");
        }
        public static void Task_9_154(string w)
        {
            Console.WriteLine("Task 9.154: ");
            string word = w.ToLower();
            List<char> list = new List<char>();
            bool flag = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (word[i] == list[j])
                            flag = false;
                    }
                    if (flag)
                    {
                        list.Add(word[i]);
                    }
                    flag = true;
                }
            }
            Console.WriteLine($"Рiзних букв у слов {w} = {list.Count}.");
        }
        public static void Task_9_155(string w)
        {
            Console.WriteLine("Task 9.155: ");
            string word = w.ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i+1; j < word.Length; j++)
                {
                    if (char.IsLetter(word[i]))
                    {
                        if (word[i] == word[j])
                        {
                            Console.WriteLine($"Двi перші однаковi букви у словi це \'{word[i]}\' на позицiї \'{i + 1}\' i \'{word[j]}\' на позицiї \'{j+1}\'.");
                            i = word.Length;
                            break;
                        }
                    }
                }
            }
        }
    }
}
