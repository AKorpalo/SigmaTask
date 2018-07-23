using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTasks
{
    class Chapter_5to8
    {
        public static void Task_5_13to5_15(int n)
        {
            Console.WriteLine("Task 5.15: ");
            if(n >= 1 && n <= 9)
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\t{i} x {n} = {i*n}");
            }
            else Console.WriteLine("Число n введено невiрно.");
        }
        public static void Task_5_27(int n, int b)
        {
            Console.WriteLine("Task 5.27: ");
            int sum = 0;
            for (int i = 100; i <= 500; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\ta)Сума усiх чiлиx чисел вiд 100 до 500 = {sum}.");

            sum = 0;
            for (int i = n; i <= 500; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\tб)Сума усiх чiлиx чисел вiд {n} до 500 = {sum}.");

            sum = 0;
            for (int i = -10; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\tв)Сума усiх чiлиx чисел вiд -10 до {b} = {sum}.");
            if (b >= n)
            {
                sum = 0;
                for (int i = n; i <= b; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"\tг)Сума усiх чiлиx чисел вiд {n} до {b} = {sum}.");
            }
            else Console.WriteLine("\tг)a > b.");
        }
        public static void Task_5_28(int n, int b)
        {
            Console.WriteLine("Task 5.28: ");
            long sum = 1;
            for (int i = 8; i <= 15; i++)
            {
                sum *= i;
            }
            Console.WriteLine($"\ta)Добуток усiх чiлиx чисел вiд 8 до 15 = {sum}.");

            if (n >= 1 && n <= 20)
            {
                sum = 1;
                for (int i = n; i <= 20; i++)
                {
                    sum *= i;
                }
                Console.WriteLine($"\tб)Добуток усiх чiлиx чисел вiд {n} до 20 = {sum}.");
            }
            else Console.WriteLine($"б) a > 20 або a < 1");

            if (b >= 1 && b <= 20)
            {
                sum = 1;
                for (int i = 1; i <= b; i++)
                {
                    sum *= i;
                }
                Console.WriteLine($"\tв)Добуток усiх чiлиx чисел вiд 1 до {b} = {sum}.");
            }
            else Console.WriteLine("в) b > 20 або b < 1");
            if (b >= n)
            {
                sum = 1;
                for (int i = n; i <= b; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"\tг)Добуток усiх чiлиx чисел вiд {n} до {b} = {sum}.");
            }
            else Console.WriteLine("\t a > b.");
        }
        public static void Task_5_29(int n, int b)
        {
            Console.WriteLine("Task 5.29: ");
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\ta)Cереднє арифметичне усiх чiлиx чисел вiд 1 до 1000 = {sum/1000}.");

            sum = 0;
            for (int i = 100; i <= b; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\tб)Cереднє арифметичне усiх чiлиx чисел вiд 100 до {b} = {sum/(b-100)}.");

            sum = 0;
            for (int i = n; i <= 200; i++)
            {
                sum += i;
            }
            Console.WriteLine($"\tв)Cереднє арифметичне усiх чiлиx чисел вiд {n} до 200 = {sum/(200-n)}.");
            if (b >= n)
            {
                sum = 0;
                for (int i = n; i <= b; i++)
                {
                    sum += i;
                }
                Console.WriteLine("\tг)Cереднє арифметичне усiх чiлиx чисел вiд {0} до {1} = {2}.",n,b, b == n ? sum : sum / (b - n));
            }
            else Console.WriteLine("\tг)a > b.");
        }
        public static void Task_5_30(int n, int b)
        {
            Console.WriteLine("Task 5.30: ");
            long sum = 0;
            for (int i = 20; i <= 40; i++)
            {
                sum += i*i*i;
            }
            Console.WriteLine($"\ta)Сума кубiв усiх чiлиx чисел вiд 20 до 40 = {sum}.");

            sum = 0;
            for (int i = n; i <= 50; i++)
            {
                sum += i * i;
            }
            Console.WriteLine($"\tб)Сума квадратiв усiх чiлиx чисел вiд {n} до 50 = {sum}.");

            sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i ;
            }
            Console.WriteLine($"\tв)Сума квадратiв усiх чiлиx чисел вiд 1 до {n} = {sum}.");
            if (b >= n)
            {
                sum = 0;
                for (int i = n; i <= b; i++)
                {
                    sum += i * i * i;
                }
                Console.WriteLine($"\tг)Сума квадратiв усiх чiлиx чисел вiд {n} до {b} = {sum}.");
            }
            else Console.WriteLine("\tг)a > b.");
        }
        public static void Task_5_31(int n)
        {
            Console.WriteLine("Task 5.31:");
            long sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += (n + i) * (n + i);
            }
            Console.WriteLine($"\tСума ряду = {sum}.");
        }
        public static void Task_5_32to5_37(double n)
        {
            Console.WriteLine("Task 5.32:");
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");

            Console.WriteLine("Task 5.33:");
            sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                sum += i / i+1;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");

            Console.WriteLine("Task 5.34:");
            sum = 0;
            double step = 1;
            for (int i = 0; i <= 8; i++)
            {
                step = 1;
                for (int j = 0; j < i; j++)
                {
                    step *= 3;
                }
                sum += 1 / step;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");

            Console.WriteLine("Task 5.35:");
            sum = 0;
            step = -1;
            for (int i = 1; i <= n; i++)
            {
                step = -1;
                for (int j = 0; j < i; j++)
                {
                    step *= -1; 
                }
                sum += (1 / (Convert.ToDouble(i))) * step;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");

            Console.WriteLine("Task 5.36:");
            sum = 0;
            step = 2;
            for (int i = 1; i <= 11; i+=2)
            {
                step = 1;
                for (int j = 0; j < i; j++)
                {
                    step *= 2;
                }
                sum += step / i;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");

            Console.WriteLine("Task 5.37:");
            sum = 1;
            step = 1;
            for (int i = 2; i <= 11; i ++)
            {
                step = 1;
                for (int j = 0; j < i-1; j++)
                {
                    step *= -2;
                }
                sum += (Convert.ToDouble(i)/(i+1)) * step;
            }
            Console.WriteLine($"\tСума ряду = {sum}.");
        }
        public static void Task_5_40(params double[] n)
        {
            Console.WriteLine("Task 5.40:");
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            Console.WriteLine($"\tСума всiх дробних чисел = {sum}.");
        }
        public static void Task_5_41(params int[] n)
        {
            Console.WriteLine("Task 5.41:");
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            Console.WriteLine($"\tЗагальна маса = {sum}.");
        }
        public static void Task_5_66(int n)
        {
            Console.WriteLine("Task 5.66:");
            double[] arr = new double[n];
            arr[0] = 1;
            for (int i = 1; i < n; i++)
            {
                arr[i] = (i * arr[i - 1]) + (1 / Convert.ToDouble(i));
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[a{i} = {arr[i]}],");
            }
            Console.WriteLine();
        }
        public static void Task_5_67(int k, int n)
        {
            Console.WriteLine("Task 5.67:");
            Console.WriteLine($"\ta){k}-член послiдовностi фiбоначчi = {Fibonachi(k)}");
            Console.Write($"\tб)Першi {n} членiв послiдовностi фiбоначчi ");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Fibonachi(i)}, ");
                sum += Fibonachi(i);
            }
            Console.WriteLine();
            if(sum%2==0)
                Console.WriteLine($"\tв)Сума перших {n} членiв послiдовностi фiбоначчi парне число.");
            else Console.WriteLine($"\tв)Сума перших {n} членiв послiдовностi фiбоначчi не парне число.");
        }
        public static double Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else 
                return Fibonachi(n - 2) + Fibonachi(n - 1);
        }
        public static double Poslidovnist(int k)
        {
            if (k == 0)
                return 0;
            else return Fibonachi(k + 1) / Fibonachi(k);
        }
        public static void Task_5_68(int k, int n,int A)
        {
            Console.WriteLine("Task 5.67:");
            Console.WriteLine($"\ta){k}-член послiдовностi = {Poslidovnist(k)}");
            Console.Write($"\tб)Першi {n} членiв послiдовностi ");
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Poslidovnist(i)}, ");
                sum += Poslidovnist(i);
            }
            Console.WriteLine();
            if (sum > A)
                Console.WriteLine($"\tв)Сума перших {n} членiв послiдовностi бiльше числа {A}.");
            else Console.WriteLine($"\tв)Сума перших {n} членiв послiдовностi менше або дорiвнює  числу {A}.");
        }
        public static void Task_5_81(int x,int y)
        {
            Console.WriteLine("Task 5.81: ");
            int sum = 0;
            for (int i = 0; i < y; i++)
            {
                sum += x;
            }
            Console.WriteLine($"\tа) X*Y = {sum}.");
            sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += y;
            }
            Console.WriteLine($"\tб) Y*X = {sum}.");
        }
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            else return n * Factorial(n-1);
        }
        public static void Task_5_82(int n)
        {
            Console.WriteLine("Task 5.82: ");
            Console.WriteLine($"\tФакторiал числа {n} = {Factorial(n)}");
        }
        public static double Pow(double a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
                return a;
            else return a * Pow(a,n-1);
        }
        public static void Task_5_83(double a, int n)
        {
            Console.WriteLine("Task 5.83: ");
            Console.WriteLine($"\tСтепiнь {n} числа {a} = {Pow(a,n)}");
        }
        public static void Task_6_10(int n)
        {
            Console.WriteLine("Task 6.10: ");
            Console.Write($"\tа)Числа квадрат яких менше {n}: ");
            for (int i = 1; i < Math.Sqrt(n)+1; i++)
            {
                if (i * i < n)
                    Console.Write($"{i}, ");
                else if (i * i > n)
                {
                    Console.WriteLine();
                    Console.WriteLine($"\tб)Число {i}, найменше число квадрат якого бiльше чила {n}.");
                    break;
                }
            }
        }
        public static void Task_6_11(double n)
        {
            Console.WriteLine("Task 6.11: ");
            if (n <= 1 || n > 1.5)
                Console.WriteLine($"Число {n} не належить межі 1<{n}<1.5.");
            else
            {
                Console.Write($"\tЧисла якi не менше {n}: ");
                int i = 2;
                while (1 + (1 / Convert.ToDouble(i)) >= n)
                {
                    Console.Write($"{1 + (1 / Convert.ToDouble(i))}, ");
                    i++;
                }
            }
            Console.WriteLine();
        }
        public static void Task_6_12(double n)
        {
            Console.WriteLine("Task 6.12: ");
            if (n <= 1 || n > 1.5)
                Console.WriteLine($"Число {n} не належить межі 1<{n}<1.5.");
            else
            {
                Console.Write($"\tПерше число яке менше {n}: ");
                int i = 2;
                while (1 + (1 / Convert.ToDouble(i)) >= n)
                {
                    i++;
                }
                Console.Write($"{1 + (1 / Convert.ToDouble(i))}.");
            }
            Console.WriteLine();
        }
        public static void Task_6_33()
        {
            Console.WriteLine("Task 6.12: ");
            Console.Write($"\ta)Всi числа менше 100 якi кратнi 30: ");
            for (int i = 30; i < 100; i+= 30)
            {
                Console.Write($"{i},");
            }
            Console.WriteLine();

            Console.Write($"\tб)Всi числа менше 100 якi кратнi 30: ");
            for (int i = 30; i < 100; i += 30)
            {
                if(i%30==0)
                Console.Write($"{i},");
            }
            Console.WriteLine();
        }
        public static void Task_6_91(int n)
        {
            Console.WriteLine("Task 6.91: ");
            string number = n.ToString();
            Console.WriteLine($"\tа)Кiлькiсть цифер в числi {n} = {number.Length}");
            double[] arr = new double[number.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Char.GetNumericValue(number[i]);
            }
            double temp1 = 0;
            double temp2 = 1;
            double temp3 = 0;
            double temp4 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                temp1 += arr[i];
                temp2 *= arr[i];
                temp3 += arr[i] * arr[i];
                temp4 += arr[i] * arr[i] * arr[i];
            }
            Console.WriteLine($"\tб)Сума цифер в числi {n} = {temp1}");
            Console.WriteLine($"\tв)Добуток цифер в числi {n} = {temp2}");
            Console.WriteLine($"\tг)Середнє арифметичне цифер в числi {n} = {temp1/number.Length}");
            Console.WriteLine($"\tд)Сума квадратiв цифер в числi {n} = {temp3}");
            Console.WriteLine($"\tе)Сума кубiв цифер в числi {n} = {temp4}");
            Console.WriteLine($"\tж)Перша цифра в числi {n} = {arr[0]}");
            Console.WriteLine($"\tз)Сума першої i останьої цифри в числi {n} = {arr[0] + arr[number.Length-1]}");
        }
        public static void Task_8_1to8_8()
        {
            Console.WriteLine("Task 8.1: ");
            Console.WriteLine("\ta)");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(5 + " ");
                }
            }

            Console.WriteLine("\n\n\tб)");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(j+1 + " ");
                }
            }

            Console.WriteLine("\n\n\tв)");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(40 + i*10 + j + 1 + " ");
                }
            }

            Console.WriteLine("\nTask 8.2: ");
            Console.WriteLine("\ta)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(5 + " ");
                }
            }

            Console.WriteLine("\n\n\tб)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 5-i; j++)
                {
                    Console.Write(1 + " ");
                }
            }

            Console.WriteLine("\nTask 8.3: ");
            Console.WriteLine("\ta)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(i+1 + " ");
                }
            }

            Console.WriteLine("\n\n\tб)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(5+i + " ");
                }
            }

            Console.WriteLine("\n\n\tв)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((i + 1) * 10 + " ");
                }
            }

            Console.WriteLine("\n\n\tг)");
            for (int i = 1; i < 6; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 6-i; j++)
                {
                    Console.Write("\t" + 5 * i  + " ");
                }
            }

            Console.WriteLine("\nTask 8.4: ");
            Console.WriteLine("\ta)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(i - j + " ");
                }
            }

            Console.WriteLine("\n\n\tб)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(6 - i - j + " ");
                }
                Console.Write(2 + " ");
            }

            Console.WriteLine("\n\n\tв)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(30 - i + j + " ");
                }
            }

            Console.WriteLine("\n\n\tг)");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t");
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write(20 - i + j + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 8.5: ");
            Console.Write("\t");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{j}+{i}={i + j}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 8.6: ");
            Console.Write("\t");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}+{j}={i + j}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 8.7: ");
            Console.Write("\t");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{j}*{i}={i * j}\t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\nTask 8.8: ");
            Console.Write("\t");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i}*{j}={i * j}\t");
                }
            }
        }
        public static void Task_8_36()
        {
            Console.WriteLine("\nTask 8.36: ");
            int sum = 0;
            Console.Write("Всi досконалi числа до 100000: ");
            for (int i = 1; i < 100000; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if(i == sum)
                    Console.Write($"[{sum}], ");
            }
            Console.WriteLine();
        }
    }
}
