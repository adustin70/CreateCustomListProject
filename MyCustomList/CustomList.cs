using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>
    {
        // member variables        
        private T[] listArray;
        private int count;
        private int capacity;
        public int Count { get => count; }
        public int Capacity { get => capacity; }

        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            listArray = new T[capacity];
        }


        // member methods
        public void Add(T item)
        {
            if (count == capacity)
            {
                int counter = 0;
                capacity = capacity * 2;
                T[] newListArray = new T[capacity];
                foreach (T listItem in listArray)
                {
                    newListArray[counter] = listItem;
                    counter++;
                }
                listArray = newListArray;
            }

            listArray[count] = item;
            count++;
        }

        public T this[int index]
        {
            get
            {
                return listArray[index];
            }
        }

    }
}
