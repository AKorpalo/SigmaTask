using System;
using System.Collections.Generic;

namespace SigmaArrayTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList = new MyList();
            for (int i = 0; i < 9; i++)
            {
                myList.Add(i+100);
            }
            myList.AddRange(3,5,5,5);
            foreach (var i in myList)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
        static void ShowTasks()
        {
            Random random = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            int[] array2;

            ArrayTask.ArrayShow(array);
            Console.WriteLine($"Task 1: Елементи не повторюються бiльше 2 разiв: ");
            array2 = ArrayTask.Task1((int[])array.Clone());
            ArrayTask.ArrayShow(array2);
            Console.WriteLine($"Task 2: Зсув елементiв масиву: ");
            array = ArrayTask.Task2(array);
            ArrayTask.ArrayShow(array);
            Console.WriteLine($"Task 3: Сума вiд'ємних чисел масиву: {ArrayTask.Task3(array)}");
            Console.WriteLine($"Task 4: Добуток непарних чисел масиву: {ArrayTask.Task4(array)}");
            Console.WriteLine($"Task 5: Сума елементiв масиву мiж двома першими нулями: {ArrayTask.Task5(array)}");
            Console.WriteLine($"Task 6: Найбiльший елемент масиву: {ArrayTask.Task6(array)}");
            Console.WriteLine($"Task 7: Найменший парний елемент масиву: {ArrayTask.Task7(array)}");
            array = ArrayTask.Task8(array);
            Console.WriteLine($"Task 8: Нульовi елементи на початку масиву: ");
            ArrayTask.ArrayShow(array);
            Console.WriteLine($"Task 9: Сума номерiв мiнiмального i максимального елементiв у масивi: {ArrayTask.Task9(array)}");
            ArrayTask.Task10(100, array);
            int search = 65;
            Console.WriteLine($"Task 11: Бiнарний пошук елемента [{search}]:");
            Array.Sort(array);
            int? res = ArrayTask.Task11(search, array);
            if (res != null)
                Console.WriteLine($"Елемент [{search}] має iндекс [{res}] у вiдсортованому массивi.");
            else Console.WriteLine($"Елемента [{search}] у масивi вiдсутнiй.");
        }
        static void Algorithms()
        {
            int[] arr = new int[10];
            Random random = new Random();
            for (long i = 0; i < 10; i++)
            {
                arr[i] = random.Next(-1000, 1000);
            }
            //SortingAlgorithms.BubbleSort(arr);
            //SortingAlgorithms.QuickSort(0,arr.Length-1,arr);
            //SortingAlgorithms.InsertionSort(arr);
            //SortingAlgorithms.SelectSort(arr);
            //SortingAlgorithms.MergeSort(arr);
            SortingAlgorithms.TreeSort(arr);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
