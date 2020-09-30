using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        private T[] _items;
        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }
        //CustomList<int> myList = new CustomList<int>();
       // myList.Add(5);
        //Console.WriteLine(myList[0]);

        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }
        public void Add(T item)
        {
            if(count == capacity)
            {
                //double capacity
                //create new array based on capacity
                //transfer items into that new array
            }
            _items[count] = item;
            count++;
        }
    }
}
