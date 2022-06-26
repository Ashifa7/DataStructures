using System;
using System.Collections.Generic;
using System.Linq;

namespace ListFunctions
{
    public class Lists
    {
        public static void Main()
        {
            List<int> GlobalList = new List<int>();
            Console.WriteLine("Enter Elements to your Global list: ");
            string ListInput = Console.ReadLine();
            int value;
            if (int.TryParse(ListInput, out value))
            {
                Console.WriteLine("Enter a valid number!");
            }
            GlobalList = ListInput.Split(' ').Select(int.Parse).ToList();


            bool option = true;

            do
            {
                Console.WriteLine("Want to continue with other list operations? (y/n)");
                var a = Console.ReadLine();

                if (a == "y")
                {
                    Console.WriteLine("\t1) Add List of Elements");
                    Console.WriteLine("\t2) Add single Element");
                    Console.WriteLine("\t3) Add Element at given position");
                    Console.WriteLine("\t4) Remove Element from given position");
                    Console.WriteLine("\t5) Sort Elements");
                    Console.WriteLine("\t6) Find Element at given Index");
                    Console.Write("Enter your option: ");
                    var b = Convert.ToInt32(Console.ReadLine());
                    //Object of class whose methods are called
                    ListFunctionalities listFunctionalities = new ListFunctionalities();

                    switch (b)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter list of elements: ");
                                string newInput = Console.ReadLine();
                                listFunctionalities.MergeLists(newInput, GlobalList);
                                break;

                            }
                        case 2:
                            {
                                Console.Write("Enter Element to add: ");
                                var newElement = Convert.ToInt32(Console.ReadLine());
                                listFunctionalities.AddElement(newElement, GlobalList);
                                break;

                            }
                        case 3:
                            {
                                Console.Write("Enter index where you want to Add Element: ");
                                var InsertIndex = Convert.ToInt32(Console.ReadLine());
                                if (InsertIndex >= GlobalList.Count())
                                {
                                    Console.Write("Enter valid Index: ");
                                    InsertIndex = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Enter value you want to add: ");
                                var InsertNum = Convert.ToInt32(Console.ReadLine());

                                //call method
                                listFunctionalities.AddAtPos(InsertIndex, InsertNum, GlobalList);
                                break;


                            }
                        case 4:
                            {
                                Console.Write("Enter index of element to remove: ");
                                var RemoveIndex = Convert.ToInt32(Console.ReadLine());
                                if (RemoveIndex >= GlobalList.Count())
                                {
                                    Console.Write("Enter valid Index: ");
                                    RemoveIndex = Convert.ToInt32(Console.ReadLine());
                                }
                                Console.Write("Enter count of elemnts to remove: ");
                                var RemoveCount = Convert.ToInt32(Console.ReadLine());
                                if (RemoveCount >= (GlobalList.Count() - RemoveIndex + 1))
                                {
                                    Console.Write("Enter valid Count: ");
                                    RemoveCount = Convert.ToInt32(Console.ReadLine());
                                }
                                //call method
                                listFunctionalities.RemoveFromPos(RemoveIndex, RemoveCount,
                                    GlobalList);
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Sort in which order? ");
                                Console.WriteLine("\ta Ascending order");
                                Console.WriteLine("\tb Descending order");
                                var w = Console.ReadLine();
                                listFunctionalities.Sorting(w, GlobalList);
                                break;
                            }
                        case 6:
                            {
                                Console.Write("Enter Index to find Element: ");
                                var Position = Convert.ToInt32(Console.ReadLine());
                                if (Position >= GlobalList.Count())
                                {
                                    Console.Write("Enter valid Index: ");
                                    Position = Convert.ToInt32(Console.ReadLine());
                                }
                                listFunctionalities.FindElement(Position, GlobalList);
                                break;
                            }
                    }

                }
                else if (GlobalList.Count == 0)
                {
                    Console.WriteLine("Your List is Empty!!!");
                    option = false;
                }
                else {
                    Console.WriteLine("Final list Includes: ");
                    foreach (var items in GlobalList)
                    {
                        Console.WriteLine(items);
                    }
                    option = false;
                }
            } while (option);

            Console.ReadLine();
        }
    }

}
