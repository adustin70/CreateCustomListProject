﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T>// : IEnumerable
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

        public void Remove(T item)
        {
            T[] newListArray = new T[capacity];
            int counter = 0;
            foreach (T listItem in listArray)
            {
                newListArray[counter] = listItem;
                counter++;
                if (EqualityComparer<T>.Default.Equals(item, listItem))
                {
                    counter--;
                    newListArray[counter] = listItem;
                }
            }
            listArray = newListArray;
            count--;
        }

        public override string ToString()
        {
            string itemsToString = "";
            for (int i = 0; i < count; i++)
            {
                itemsToString += listArray[i].ToString();
            }            
            return itemsToString;
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list1.count; i++)
            {
                list2.Add(list1[i]);
            }
            return list2;
        }

        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            for (int i = 0; i > customList1.count; i--)
            {
                customList1.Remove(customList2[i]);
            }
            return customList1;
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
