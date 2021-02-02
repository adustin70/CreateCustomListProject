using System;
using System.Collections;
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
        public int Capacity 
        { 
            get => capacity;
            set { capacity = value; }
        }

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
                IncreaseCapacity();
            }

            listArray[count] = item;
            count++;
        }

        public void IncreaseCapacity()
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

        public T this[int index]
        {
            get
            {
                if (count < index || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return listArray[index];
                }
            }
            set
            {
                if (count < index || index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    listArray[index] = value;
                }
            }
        }

        public void Remove(T item)
        {
            T[] newListArray = new T[capacity];
            int counter = 0;
            for (int i = 0; i < count; i++)
            {
                newListArray[counter] = listArray[i];
                counter++;
                if (EqualityComparer<T>.Default.Equals(item, listArray[i]))
                {
                    counter--;
                }
            }
            listArray = newListArray;
            count--;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(listArray[i]);
            }
            return stringBuilder.ToString();
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> newList = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                newList.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                newList.Add(list2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> newRemoveList = new CustomList<T>();
            for (int i = 0; i < customList2.count; i++)
            {
                customList1.Remove(customList2[i]);                
            }
            for (int i = 0; i < customList1.count; i++)
            {
                newRemoveList.Add(customList1[i]);
            }
            return newRemoveList;
        }

        public CustomList<T> Zip(CustomList<T> customList)
        {
            CustomList<T> newZipperList = new CustomList<T>();
            int newCount = 0;
            if (count > customList.count)
            {
                newCount = count;
            }
            else if (customList.count > count)
            {
                newCount = customList.count;
            }
            else if (count == customList.count)
            {
                newCount = count + customList.count;
            }

            for (int i = 0; i < newCount; i++)
            {
                if (count > 0)
                {
                    newZipperList.Add(listArray[i]);
                    count--;
                }

                if (customList.count > 0)
                {
                    newZipperList.Add(customList[i]);
                    customList.count--;
                }
            }
            return newZipperList;
        }
    }
}
