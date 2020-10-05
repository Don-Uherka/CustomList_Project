using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T> : IEnumerable
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
                capacity = capacity * 2;
                //double capacity
                T[] _safe;
                _safe = new T[capacity];
                //create new array based on capacity
                //transfer items into that new array
                for (int i = 0; i < count; i++)
                {
                    _safe[i] = _items[i];
                }
                _items = _safe;
            }
            _items[count] = item;
            count++;
        }
        public void Remove(T itemToRemove)
        {
            T[] _temp;
            _temp = new T[capacity];
            int j = 0;
            
            for (int i = 0; i < count; i++)
            {
                
                if (_items[i].Equals(itemToRemove))
                {
                    //don't transfer the item
                }
                else
                {
                    
                    _temp[j] = _items[i];
                    j++;
                    count--;
                    
                   //transfer these items to new array
                }
                _items[i] = _temp[j];
                
            }
            
            //A, B, C
            //0, 1, 2

            //Remove B

            //A, C
            //0, 1
            

            //Create a new list with only the values we want to keep
            //loop through and look at each value, if/else
            //if the value is not itemToRemove, put it in the new list
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return _items[i];
            }
        }
    }
}
