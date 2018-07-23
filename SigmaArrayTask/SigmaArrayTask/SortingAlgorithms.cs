using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaArrayTask
{
    static class SortingAlgorithms
    {
        private static void Swap<T>(int left, int right,T[] array)
        {
            if (left != right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
        }
        public static void BubbleSort(int[] array)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i,i+1,array);
                        swapped = true;
                    }
                }
            } while (swapped);
        }
        public static void QuickSort(int left, int right, int[] array)
        {
            if (left < right)
            {
                int index = left + (right - left) / 2;

                int temp = array[index];
                Swap(index, right, array);
                int leftTemp = left;
                for (int i = left; i < right; i++)
                {
                    if (array[i] < temp)
                    {
                        Swap(i, leftTemp, array);
                        leftTemp++;
                    }
                }
                Swap(leftTemp, right, array);


                QuickSort(left, leftTemp - 1, array);
                QuickSort(leftTemp + 1, right, array);
            }
        }
        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j>=0 && array[j]>temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[++j] = temp;
            }    
        }
        public static void SelectSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int temp = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[temp])
                    {
                        temp = j;
                    }
                }
                if(i!=temp)
                    Swap(i,temp,array);
            }
        }
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int[] left = new int[leftSize];
            int[] right = new int[rightSize];
            Array.Copy(array, 0, left, 0, leftSize);
            Array.Copy(array, leftSize, right, 0, rightSize);
            MergeSort(left);
            MergeSort(right);
            Merge(left,right,array);
        }
        private static void Merge(int[] left, int[] right, int[] array)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            for (int i = 0; i < left.Length + right.Length; i++)
            {
                if (leftIndex >= left.Length)
                    array[i] = right[rightIndex++];
                else if (rightIndex >= right.Length)
                    array[i] = left[leftIndex++];
                else if (left[leftIndex] < right[rightIndex])
                    array[i] = left[leftIndex++];
                else 
                    array[i] = right[rightIndex++];
            }
        }
        public static void TreeSort(int[] array)
        {
            Tree tree = new Tree(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                tree.Insert(new Tree(array[i]));
            }
            tree.Treverse(new Sort(array));
        }
        class Tree
        {
            public Tree left;
            public Tree right;
            public int key;
            public Tree(int k)
            {
                key = k;
            }

            public void Insert(Tree aTree)
            {
                if (aTree.key < key)
                    if (left != null) left.Insert(aTree);
                    else left = aTree;
                else if (right != null) right.Insert(aTree);
                    else right = aTree;
            }
            public void Treverse(ITreeVisitor visitor)
            {
                if (left != null)
                    left.Treverse(visitor);

                visitor.Visit(key);

                if (right != null)
                    right.Treverse(visitor);
            }
        }
        interface ITreeVisitor
        {
            void Visit(int key);
        }
        class Sort : ITreeVisitor
        {
            int[] array;
            int index = 0;
            public Sort(int[] arr)
            {
                array = arr;
            }
            public void Visit(int key)
            {
                array[index++] = key;
            }
        }
    }
}
