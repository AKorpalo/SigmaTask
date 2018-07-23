using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTasks
{
    class Chapter_1to4
    {
        public static void Task_1_24(int x)
        {
            Console.WriteLine("Task 1.24:");
            Console.WriteLine($"x = {Math.Sqrt((2*x + Math.Sin(3*x))/(3.56))}");
            Console.WriteLine($"y = {Math.Sin((3.2 + Math.Sqrt(1+x))/(Math.Abs(5*x)))}");
        }
        public static void Task_2_12(int x)
        {
            if (x < 99 || x > 999)
                Console.WriteLine("Введiть трьохзначне число!");
            else
            {
                Console.WriteLine("Task 2.12:");
                Console.WriteLine($"Число одиниць в числi {x} = {x/1}");
                Console.WriteLine($"Число десяткiв в числi {x} = {x/10}");
                Console.WriteLine($"Сума цифер в числi {x} = {(int)Char.GetNumericValue(x.ToString()[0]) + (int)Char.GetNumericValue(x.ToString()[1]) + (int)Char.GetNumericValue(x.ToString()[2])}");
                Console.WriteLine($"Добуток цифер в числi {x} = {(int)Char.GetNumericValue(x.ToString()[0]) * (int)Char.GetNumericValue(x.ToString()[1]) * (int)Char.GetNumericValue(x.ToString()[2])}");
            }
        }
        public static int Task_2_13(int x)
        {
            if (x < 99 || x > 999)
            {
                Console.WriteLine("Введiть трьохзначне число!");
                return 0;
            }
            else
            {
                char[] c = x.ToString().ToCharArray();
                Array.Reverse(c);
                string s = new string(c);
                return Convert.ToInt32(s);
            }
            
        }
        public static int Task_2_14(int x)
        {
            if (x < 99 || x > 999)
            {
                Console.WriteLine("Введiть трьохзначне число!");
                return 0;
            }
            else
            {
                char[] c = new char[3] {x.ToString()[1], x.ToString()[2], x.ToString()[0] };
                string s = new string(c);
                return Convert.ToInt32(s);
            }
        }
        public static int Task_2_15(int x)
        {
            if (x < 99 || x > 999)
            {
                Console.WriteLine("Введiть трьохзначне число!");
                return 0;
            }
            else
            {
                char[] c = new char[3] { x.ToString()[2], x.ToString()[0], x.ToString()[1] };
                string s = new string(c);
                return Convert.ToInt32(s);
            }
        }
        public static int Task_2_16(int x)
        {
            if (x < 99 || x > 999)
            {
                Console.WriteLine("Введiть трьохзначне число!");
                return 0;
            }
            else
            {
                char[] c = new char[3] { x.ToString()[1], x.ToString()[0], x.ToString()[2] };
                string s = new string(c);
                return Convert.ToInt32(s);
            }
        }
        public static int Task_2_17(int x)
        {
            if (x < 99 || x > 999)
            {
                Console.WriteLine("Введiть трьохзначне число!");
                return 0;
            }
            else
            {
                char[] c = new char[3] { x.ToString()[0], x.ToString()[2], x.ToString()[1] };
                string s = new string(c);
                return Convert.ToInt32(s);
            }
        }
        public static void Task_2_18(int x)
        {
            Console.WriteLine($"Task 2.18:");
            Console.WriteLine($"Перше = {x}");
            Console.WriteLine($"Друге = {Task_2_13(x)}");
            Console.WriteLine($"Третє = {Task_2_14(x)}");
            Console.WriteLine($"Четверте = {Task_2_15(x)}");
            Console.WriteLine($"П'яте = {Task_2_16(x)}");
            Console.WriteLine($"Шосте = {Task_2_17(x)}");
        }
        public static void Task_2_19(int x)
        {
            if (x < 999 || x > 9999)
            {
                Console.WriteLine("Введiть чотирьохзначне число!");
            }
            else
            {
                Console.WriteLine("Task 2.19: ");
                int x1 = x / 1000;
                int x2 = (x - x1 * 1000) / 100;
                int x3 = (x - (x1 * 1000 + x2 * 100)) / 10;
                int x4 = (x - (x1 * 1000 + x2 * 100 + x3 * 10)) / 1;
                Console.WriteLine($"Сума цифер числа {x} = {x1 + x2+x3+x4}");
                Console.WriteLine($"Добуток цифер числа {x} = {x1 * x2 * x3 * x4}");
            }
        }
        public static void Task_2_20(int x)
        {
            if (x < 999 || x > 9999)
            {
                Console.WriteLine("Введiть чотирьохзначне число!");
            }
            else
            {
                Console.WriteLine("Task 2.20: ");
                int x1 = x / 1000;
                int x2 = (x - x1 * 1000) / 100;
                int x3 = (x - (x1 * 1000 + x2 * 100)) / 10;
                int x4 = (x - (x1 * 1000 + x2 * 100 + x3 * 10)) / 1;
                Console.WriteLine($"a) Реверсоване число {x} = {x4* 1000 + x3 * 100 + x2 * 10 + x1}");
                Console.WriteLine($"б) {x} = {x2 * 1000 + x1 * 100 + x4 * 10 + x3}");
                Console.WriteLine($"в) {x} = {x1 * 1000 + x3 * 100 + x2 * 10 + x4}");
                Console.WriteLine($"г.1) {x} = {x3 * 1000 + x4 * 100 + x1 * 10 + x2}");
                Console.WriteLine($"г.2) {x} = {((x - (x/100*100))*100)+x/100}");
            }
        }
        public static void Task_2_21to2_23(int x)
        {
            if (x < 999 || x > 9999)
            {
                Console.WriteLine("Введiть чотирьохзначне число!");
            }
            else
            {
                Console.WriteLine("Tasks 2.21-2.23");
                Console.WriteLine($"В числi {x} = Одиниць {x}, десяткiв {x / 10}, сотень {x / 100}, тисяч {x / 1000}");
            }
        }
        public static void Task_3_32(double x, double y)
        {
            Console.WriteLine("Task 3.32: ");
            if (x <= -2 && y >= 1)
            {
                Console.WriteLine($"а) Точка (х = {x}; y = {y}) попадає в область!");
            } else Console.WriteLine($"а) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= 1.5 && y >= -2)
            {
                Console.WriteLine($"б) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"б) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= 4 && x >= 1 && x <= 2)
            {
                Console.WriteLine($"в) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"в) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= 4 && y >= 2 && x >= 1)
            {
                Console.WriteLine($"г) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"г) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((x >= 2 && y >= 0) || (y <= -1 && x >= 1))
            {
                Console.WriteLine($"д) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"д) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((x >= 2) && (y <= -1.5 || y >= 1))
            {
                Console.WriteLine($"е) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"е) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= -1 && y >= -2 && x >= 1 && x <= 3)
            {
                Console.WriteLine($"ж) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"ж) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((x >= 2) || (x < 2 && y >= 0.5 && y <= 1.5))
            {
                Console.WriteLine($"з) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"з) Точка (х = {x}; y = {y})  не попадає в область!");
        }
        public static void Task_3_33(double x, double y)
        {
            Console.WriteLine("Task 3.33: ");
            if (x <= -1 && y <= -2)
            {
                Console.WriteLine($"а) Точка (х = {x}; y = {y}) попадає в область!");
            }
            else Console.WriteLine($"а) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= -3 && y >= 1)
            {
                Console.WriteLine($"б) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"б) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((y <= -3 && x >= -4) && y >= 1)
            {
                Console.WriteLine($"в) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"в) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y >= -0.5 && y <= 1.5 && x <= 1.5 && x >= -1)
            {
                Console.WriteLine($"г) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"г) Точка (х = {x}; y = {y})  не попадає в область!");

            if (x >= 1 && x <= 4 && y >= 2 && y <= 4)
            {
                Console.WriteLine($"д) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"д) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((y >= 1) && (x <= -1 || x >= 2))
            {
                Console.WriteLine($"е) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"е) Точка (х = {x}; y = {y})  не попадає в область!");

            if (y <= 1 && y >= -3 && x >= 1 && x <= 3)
            {
                Console.WriteLine($"ж) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"ж) Точка (х = {x}; y = {y})  не попадає в область!");

            if ((y >= 1.5) || (y <= 1.5 && y >= -2 && x >= 1 && x <= 2.5))
            {
                Console.WriteLine($"з) Точка (х = {x}; y = {y})  попадає в область!");
            }
            else Console.WriteLine($"з) Точка (х = {x}; y = {y})  не попадає в область!");
        }
        public static void Task_4_1to4_2(double x)
        {
            Console.Write("Task 4.1: ");
            if(x > 0)
                Console.WriteLine($"y = sin2x = {Math.Sin(x)* Math.Sin(x)}");
            else Console.WriteLine($"y = 1 - 2sinx2 = {1 - 2*(Math.Sin(x*x))}");
            Console.Write("Task 4.2: ");
            if (x > 0)
                Console.WriteLine($"y = sin2x = {Math.Sin(x*x)}");
            else Console.WriteLine($"y = 1 + 2sinx2 = {1 + 2 * (Math.Sin(x) * Math.Sin(x))}");
        }
        public static void Task_4_3to4_4(double x, double y)
        {
            Console.Write("Task 4.3: ");
            if (x == 4)
                Console.WriteLine($"Точка (x = {x};y = {y}) на межi.");
            else
            {
                if (x < 4)
                {
                    Console.WriteLine($"Точка (x = {x};y = {y}) на I половинi.");
                }
                else Console.WriteLine($"Точка (x = {x};y = {y}) на II половинi.");
            }
            Console.Write("Task 4.3: ");
            if (y == 3)
                Console.WriteLine($"Точка (x = {x};y = {y}) на межi.");
            else
            {
                if (x > 3)
                {
                    Console.WriteLine($"Точка (x = {x};y = {y}) на I половинi.");
                }
                else Console.WriteLine($"Точка (x = {x};y = {y}) на II половинi.");
            }
        }
        public static void Task_4_5(double x)
        {
            Console.WriteLine("Task 4.5: ");
            if (x < 2)
                Console.WriteLine($"\tа) Якщо x = {x} то y = {x}");
            else
                Console.WriteLine($"\tа) Якщо x = {x} то y = {2}");



            if (x < 3)
                Console.WriteLine($"\tб) Якщо x = {x} то y = {-x}");
            else 
                Console.WriteLine($"\tб) Якщо x = {x} то y = {-3}");
        }
        public static void Task_4_37(double x)
        {
            Console.Write("Task 4.37: ");
            if(x > -5 && x < 3)
                Console.WriteLine($"Число {x} належить iнтервалу (-5;3).");
            else Console.WriteLine($"Число {x} не належить iнтервалу (-5;3).");
        }
        public static void Task_4_38to4_39(double x, double y)
        {
            Console.WriteLine("Task 3.38: ");
            if(x > 3 && y > 2)
                Console.WriteLine($"\tа)Точка ({x};{y}) попадає в область I.");
            else Console.WriteLine($"\tа)Точка ({x};{y}) не попадає в область I.");

            if (x < -2 && y < -4)
                Console.WriteLine($"\tб)Точка ({x};{y}) попадає в область I.");
            else Console.WriteLine($"\tб)Точка ({x};{y}) не попадає в область I.");

            Console.WriteLine("Task 3.39: ");
            if (x == -1 || x == 5)
                Console.WriteLine($"\tа)Точка ({x};{y}) попадає на межу областi.");
            else
            {
                if (x < -1)
                    Console.WriteLine($"\tТочка ({x};{y}) попадає в область III.");
                else if(x > -1 && x < 5 )
                    Console.WriteLine($"\tТочка ({x};{y}) попадає в область II.");
                else if(x > 5)
                    Console.WriteLine($"\tТочка ({x};{y}) попадає в область I.");
            }
        }
        public static void Task_4_40to4_41(double x)
        {
            Console.WriteLine("Task 4.40:");
            if(x >= -2.4 && x <= 5.7)
                Console.WriteLine($"\ty = x2 = {x*x}.");
            else Console.WriteLine($"\ty = 4.");

            Console.WriteLine("Task 4.41:");
            if (x >= 0.2 && x <= 0.9)
                Console.WriteLine($"\ty = sin x = {Math.Sin(x)}.");
            else Console.WriteLine($"\ty = 1.");
        }
        public static void Task_4_42(double a, double b, double c)
        {
            Console.WriteLine("Task 4.42:");
            if(a < b && b < c)
                Console.WriteLine($"\tа)Нерiвнiсть a<b<c, якщо a = {a}, b = {b}, c = {c} - виконується");
            else Console.WriteLine($"\tа)Нерiвнiсть a<b<c, якщо a = {a}, b = {b}, c = {c} - не виконується");

            if (b < a && a > c)
                Console.WriteLine($"\tа)Нерiвнiсть b>a>c, якщо a = {a}, b = {b}, c = {c} - виконується");
            else Console.WriteLine($"\tа)Нерiвнiсть b>a>c, якщо a = {a}, b = {b}, c = {c} - не виконується");
        }
        public static void Task_4_68(double a, double v, double P, double R, double H)
        {
            Console.WriteLine("Task 4.68:");
            double t = R / v;
            double x = v * t * Math.Cos(a / 57.2958);
            double y = (v * t * Math.Sin(a / 57.2958)) - ((9.8 * t*t) / 2); 
            if(y > H && y < H+R)
                Console.WriteLine($"\tСнаряд вразить цiль, яка знаходиться на вiдстанi {R} i на висотi {P + H}");
            else Console.WriteLine($"\tСнаряд не вразить цiль, яка знаходиться на вiдстанi {R} i на висотi {P + H}");

        }
        public static void Task_4_85to88(double x)
        {
            Console.WriteLine("Task 4.85:");
            if(x < -1)
                Console.WriteLine($"\ty = {-1}");
            else if(x > -1)
                Console.WriteLine($"\ty = {x}");
            else Console.WriteLine($"\ty = {1}");

            Console.WriteLine("Task 4.86:");
            if (x> 0)
                Console.WriteLine($"\tz = {1}");
            else if (x < 0)
                Console.WriteLine($"\tz = {-1}");
            else Console.WriteLine($"\tz = {0}");

            Console.WriteLine("Task 4.87:");
            if (x <= 0)
                Console.WriteLine($"\tf = {0}");
            else if (x > 0 && x <= 1)
                Console.WriteLine($"\tf = {x}");
            else Console.WriteLine($"\tf = {x*x}");

            Console.WriteLine("Task 4.88:");
            if (x > 2)
                Console.WriteLine($"\tf = {2}");
            else if (x > 0 && x <= 2)
                Console.WriteLine($"\tf = {0}");
            else Console.WriteLine($"\tf = {-3 * x}");
        }
        public static void Task_4_89to4_90(double x)
        {
            Console.WriteLine("Task 4.89:");
            double k = Math.Sin(x) < 0 ? x*x : Math.Abs(x);
            if(k < x)
                Console.WriteLine($"\tf = {k*x}");
            else Console.WriteLine($"\tf = {k + x}");

            Console.WriteLine("Task 4.90:");
            k = Math.Sin(x) < 0 ? Math.Abs(x) : x*x;
            if (x < k)
                Console.WriteLine($"\tf = {Math.Abs(x)}");
            else Console.WriteLine($"\tf = {k * x}");
        }
        public static void Task_4_91(double x)
        {
            Console.WriteLine("Task 4.91:");
            if(x <= -1)
                Console.WriteLine($"\tа) Якщо х = {x}, то y = {0}");
            else if (x > -1 && x <= 0 )
                Console.WriteLine($"\tа) Якщо х = {x}, то y = {x}");
            else Console.WriteLine($"\tа) Якщо х = {x}, то y = {1}");

            if (x <= -1)
                Console.WriteLine($"\tб) Якщо х = {x}, то y = {1}");
            else if (x > -1 && x <= 1)
                Console.WriteLine($"\tб) Якщо х = {x}, то y = {-x}");
            else Console.WriteLine($"\tб) Якщо х = {x}, то y = {-1}");

            if (x <= -1 || x > 1)
                Console.WriteLine($"\tв) Якщо х = {x}, то y = {1}");
            else if (x > -1 && x <= 0)
                Console.WriteLine($"\tв) Якщо х = {x}, то y = {-x / 2 + 0.5}");
            else if (x > 0 && x <= 1)
                Console.WriteLine($"\tв) Якщо х = {x}, то y = {x / 2 + 0.5}");
        }
        public static void Task_4_92to4_93(double x, double y)
        {

            Console.WriteLine("Task 4.92:");
            if (x == 1 || y == 5)
                Console.WriteLine($"\tТочка ({x};{y}) знаходиться на межi областi.");
            else
            {
                if (x < 1)
                    Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi I.");
                else if (x > 1 && x < 5)
                    Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi II.");
                else Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi III.");
            }

            Console.WriteLine("Task 4.93:");
            if (y == 2.5 || y == 5)
                Console.WriteLine($"\tТочка ({x};{y}) знаходиться на межi областi.");
            else
            {
                if(y < 2.5)
                    Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi III.");
                else if(y > 2.5 && y < 5)
                    Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi II.");
                else Console.WriteLine($"\tТочка ({x};{y}) знаходиться на областi I.");
            }
        }
        public static void Task_4_104(double x)
        {
            Console.WriteLine("Task 4.104:");
            if(x > 1 && x <= 7)
            Console.WriteLine($"\tЧисло {x} позначає {(DayOfWeek)x}");
            else Console.WriteLine("Введено не вірне число.");
        }
        enum Month
        {
            Сiчень = 1,
            Лютий,
            Березень,
            Квітень,
            Травень,
            Червень,
            Липень,
            Серпень,
            Вересень,
            Жовтень,
            Листопад,
            Грудень

        }
        public static void Task_4_105(double x)
        {
            Console.WriteLine("Task 4.105:");
            if (x > 1 && x <= 12)
                Console.WriteLine($"\tЧисло {x} позначає {(Month)x}");
            else Console.WriteLine("Введено не вірне число.");
        }
        enum Season
        {
            Зима = 1,
            Весна = 2,
            Лiто = 3,
            Осiнь = 4
        }
        public static void Task_4_106(double x)
        {
            Console.WriteLine("Task 4.106:");
            if (x > 1 && x <= 12)
            {
                if (x >= 3 && x <= 5)
                    Console.WriteLine($"\tЧисло {x} позначає {(Season)2}");
                else if (x >= 6 && x <= 8)
                    Console.WriteLine($"\tЧисло {x} позначає {(Season)3}");
                else if (x >= 9 && x <= 11)
                    Console.WriteLine($"\tЧисло {x} позначає {(Season)4}");
                else Console.WriteLine($"\tЧисло {x} позначає {(Season)1}");
            }
            else Console.WriteLine("Введено не вірне число.");
        }
        public static void Task_4_107(double x, double year)
        {
            Console.WriteLine("Task 4.107:");
            if (x > 1 && x <= 12)
            {
                if (x == 2)
                    if (year % 100 != 0 && year % 4 == 0)
                        Console.WriteLine($"\tМiсяць {(Month)x} у {year} роцi має {29} днiв.");
                    else if (year % 400 == 0)
                        Console.WriteLine($"\tМiсяць {(Month)x} у {year} роцi має {29} днiв.");
                    else Console.WriteLine($"\tМiсяць {(Month)x} у {year} роцi має {28} днiв.");
                else if ((x < 8 && x % 2 == 1) || (x >= 8 && x % 2 == 0))
                    Console.WriteLine($"\tМiсяць {(Month)x} має {31} днiв.");
                else Console.WriteLine($"\tМiсяць {(Month)x} має {30} днiв.");
            }
            else Console.WriteLine("Введено не вірне число.");
        }
    }
}
