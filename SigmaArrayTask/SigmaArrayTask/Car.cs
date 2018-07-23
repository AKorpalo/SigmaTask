using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaArrayTask
{
    class Car : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Car(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (obj != null)
            {
                return this.Name.CompareTo(temp.Name);
            }
            else throw new InvalidCastException();
        }
    }
}
