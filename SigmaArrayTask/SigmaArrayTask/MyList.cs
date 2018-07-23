using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaArrayTask
{
    class MyList : IEnumerable
    {
        public int Capacity { get; set; }

        private int _count;
        public int Count { get { return _count; } }

        private int[] array;
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                    return array[index];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Count)
                    array[index] = value;
                else throw new IndexOutOfRangeException();
            }
        }

        public MyList() : this(10){}
        public MyList(int capacity)
        {
            Capacity = capacity;
            array = new int[Capacity];
            _count = 0;
        }
        public MyList(int[] arr) 
        {
            _count = arr.Length;
            array = new int[_count * 2];
            for (int i = 0; i < _count; i++)
            {
                array[i] = arr[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
        public int Add(int value)
        {
            if (Capacity > _count)
            {
                array[_count] = value;
                _count++;
                return _count-1;
            }
            else
            {
                int[] array1 = new int[Capacity*=2];
                for (int i = 0; i < array.Length; i++)
                {
                    array1[i] = array[i];
                }
                array = array1;
                array[_count] = value;
                _count++;
                return _count - 1;
            }
        }
        public void AddRange(params int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            foreach (var i in arr)
            {
                Add(i);
            }
        }
        public bool Contains(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                    return true;
            }
            return false;
        }
        public void Clear()
        {
            _count = 0;
        }
        public int IndexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(int value)
        {
            for (int i = Count - 1; i > 0; i--)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int index, int value)
        {
            if (index >= Count)
                throw new IndexOutOfRangeException();
            Add(0);
            for (int i = Count-2; i > index; i--)
            {
                array[i + 1] = array[i];
            }
            array[index] = value;
        }
        public bool Remove(int value)
        {
            if (IndexOf(value) == -1)
                return false;
            else
            {
                for (int i = IndexOf(value); i < Count; i++)
                {
                    array[i] = array[i + 1];
                }
                _count--;
                return true;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            else
            {
                for (int i = index; i < Count; i++)
                {
                    array[i] = array[i + 1];
                }
                _count--;
            }
        }
        public void CopyTo(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length >= Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    arr[i] = array[i];
                }
            }
            else throw new ArgumentException();
        }
        public void CopyTo(MyList arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < Count; i++)
            {
                arr.Add(array[i]);
            }
        }
        public void CopyTo(int[] arr, int index)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (arr.Length - index >= Count)
            {
                for (int i = 0; i < Count; i++)
                {
                    arr[index + i] = array[i];
                }
            }
            else throw new ArgumentException();
        }
        public void Reverse()
        {
            int temp;
            for (int i = 0; i < Count/2; i++)
            {
                temp = array[i];
                array[i] = array[Count - 1 - i];
                array[Count - 1 - i] = temp;
            }
        }
        public int[] ToArray()
        {
            int[] arr = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                arr[i] = array[i];
            }

            return arr;
        }
        public MyList GetRange(int index, int count)
        {
            if (index < 0 || count < 0)
                throw new ArgumentOutOfRangeException();
            if (index >= Count || index + count > Count)
                throw new ArgumentException();
            MyList myList = new MyList();
            for (int i = 0; i < count; i++)
            {
                myList.Add(array[i+index]);
            }
            return myList;
        }
        public override string ToString()
        {
            return array.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj.ToString() == ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
