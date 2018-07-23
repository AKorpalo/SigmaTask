using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaArrayTask
{
    static class ArrayTask
    {
        public static void ArrayShow(params int[] arr)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"[{arr[i]}] ");
                if (i.ToString()[i.ToString().Length - 1] == '9')
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static int[] Task1(params int[] arr)
        {
            int length = arr.Length;   
            for (int i = 0; i < length; i++)
            {
                int count = 1;
                for (int j = i+1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                        count++;
                }
                if (count > 2)
                {
                    int temp = arr[i];
                    for (int j = i; j < length; j++)
                    {
                        if (arr[j] == temp)
                        {
                            for (int n = j; n < length - 1; n++)
                            {
                                arr[n] = arr[n + 1];
                            }
                            length--;
                            j--;
                        }
                    }
                    i--;
                }
            }
            int[] arr2 = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr2[i] = arr[i];
            }
            return arr2;
        }
        public static int[] Task2(params int[] arr)
        {
            int length = arr.Length;
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    if (max == -1)
                        max = i;
                    else if (arr[max] < arr[i])
                        max = i;
                }
            }
            if (max != -1)
            {
                if (max != length - 2)
                    for (int i = 0; i < 3; i++)
                    {
                        arr = Task2Help(max + 1, length, "left", arr);
                    }
                if(max != 1)
                arr = Task2Help(0, max, "right", arr);
            }
            return arr;
        }
        static int[] Task2Help(int start, int finish, string side, params int[] arr)
        {
            if (start < finish)
            {
                if (side == "right")
                {
                    int temp = arr[finish - 1];
                    for (int i = finish - 1; i > start; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[start] = temp;
                }
                else if (side == "left")
                {
                    int temp = arr[start];
                    for (int i = start; i < finish - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[finish - 1] = temp;
                }
            }
            return arr;
        }
        public static int Task3(params int[] arr)
        {
            int length = arr.Length;
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0)
                    result += arr[i];
            }
            return result;
        }
        public static long Task4(params int[] arr)
        {
            int length = arr.Length;
            long result = 1;
            for (int i = 1; i < length; i+=2)
            {
                result *= arr[i];
            }
            return result;
        }
        public static int Task5(params int[] arr)
        {
            int length = arr.Length;
            int result = 0;
            byte flag = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0 && flag == 0)
                    flag = 1;
                else if (flag == 1 && arr[i] == 0)
                    flag = 2;

                if (flag == 1)
                    result += arr[i];
                else if (flag == 2)
                    return result;
            }
            return 0;
        }
        public static int Task6(params int[] arr)
        {
            int length = arr.Length;
            int result = arr[0];
            for (int i = 1; i < length; i++)
            {
                if (result < arr[i])
                    result = arr[i];
            }
            return result;
        }
        public static int Task7(params int[] arr)
        {
            int length = arr.Length;
            int result = arr[0];
            for (int i = 1; i < length; i++)
            {
                if (arr[i] % 2 == 0 && result > arr[i])
                    result = arr[i];
            }
            return result;
        }
        public static int[] Task8(params int[] arr)
        {
            int length = arr.Length;
            int[] array = new int[length];
            int index = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                    array[index++] = arr[i];
            }
            if (index > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (arr[i] != 0)
                        array[index++] = arr[i];
                }
                return arr = array;
            }
            else return arr;
        }
        public static int Task9(params int[] arr)
        {
            int length = arr.Length;
            int min = 0;
            int max = 0;
            for (int i = 1; i < length; i++)
            {
                if (arr[min] > arr[i])
                    min = i;
                if (arr[max] < arr[i])
                    max = i;
            }
            return min + max ;
        }
        public static void Task10(int sum, params int[] arr)
        {
            int length = arr.Length;
            int temp = 0;
            bool flag = false;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0)
                {
                    temp = 0;
                    for (int j = i; j < length; j++)
                    {
                        if (arr[j] != 0)
                            temp += arr[j];
                        if (temp > sum)
                            break;
                        else if (temp == sum)
                        {
                            temp = j;
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine($"Task 10: Пiдмасив чисел сума яких дорiвнює {sum} :");
                        for (int n = i; n < temp + 1; n++)
                        {
                            Console.Write($"[{arr[n]}]");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                    }
                }
            }
            if(!flag)
            Console.WriteLine($"Task 10: Пiдмасиву чисел сума яких дорiвнює {sum} не iснує.");
        }
        public static int? Task11(int search, params int[] arr)
        {
            int length = arr.Length;
            int first = 0;
            int last = length;
            if (arr[0] > search || arr[length - 1] < search)
                return null;
            while (first < last)
            {
                int middle = first + (last - first) / 2;
                if (arr[middle] == search)
                    return middle;
                else if (arr[first] == search)
                    return first;
                else if (arr[last-1] == search)
                    return last;

                if (arr[middle] > search)
                    last = middle;
                else if (arr[middle] < search)
                    first = middle + 1;
            }
            if (arr[last] == search)
                return last;
            else return null;
        }
    }
}
