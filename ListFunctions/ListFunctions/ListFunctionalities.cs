using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFunctions
{
    public class ListFunctionalities
    {
        //Method 1
        public void MergeLists(string newInput, List<int> GlobalList)
        {
            List<int> newList = new List<int>();
            newList = newInput.Split(' ').Select(int.Parse).ToList();
            GlobalList.AddRange(newList);
            Console.WriteLine();
            Console.WriteLine("Now Elements in list are: ");
            foreach (var items in GlobalList)
            {
                Console.WriteLine(items);
            }
        }

        public void AddElement(int newElement, List<int> GlobalList)
        {
            GlobalList.Add(newElement);
            Console.WriteLine();
            Console.WriteLine("Now Elements in list are: ");
            foreach (var items in GlobalList)
            {
                Console.WriteLine(items);
            }
        }

        public void AddAtPos(int InsertIndex, int InsertNum, List<int> GlobalList)
        {
            GlobalList.Insert(InsertIndex, InsertNum);
            Console.WriteLine();
            Console.WriteLine("Now Elements in list are: ");
            foreach (var items in GlobalList)
            {
                Console.WriteLine(items);
            }
        }

        public void RemoveFromPos(int RemoveIndex, int RemoveCount, List<int> GlobalList)
        {
            GlobalList.RemoveRange(RemoveIndex, RemoveCount);
            Console.WriteLine();
            Console.WriteLine("Now Elements in list are: ");
            foreach (var items in GlobalList)
            {
                Console.WriteLine(items);
            }
        }

        public void Sorting(string w, List<int> GlobalList)
        {
            switch (w)
            {
                case "a":
                    {
                        Console.WriteLine("Elements in Ascending Order: ");
                        GlobalList.Sort();
                        foreach (var items in GlobalList)
                        {
                            Console.WriteLine(items);
                        }
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine("Elements in Descending Order: ");
                        GlobalList.Sort();
                        GlobalList.Reverse();
                        foreach (var items in GlobalList)
                        {
                            Console.WriteLine(items);
                        }
                        break;
                    }
            }
        }
        public void FindElement(int Position, List<int> GlobalList)
        {
            Console.WriteLine("Element at Index {0} is {1}", Position,
            GlobalList.ElementAt(Position));
        }

    }
}
