using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DS
    {
        public static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Select any option from below:");
            Console.WriteLine("\ta - List");
            Console.WriteLine("\tb - Dictionary");
            Console.WriteLine("\tc - SortedList");
            Console.WriteLine("\td - Stack");
            Console.WriteLine("\te - Queue");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine();
                    Console.WriteLine("Enter any integers to your list: ");
                    List<int> listItems = new List<int>();

                    string ListInput = Console.ReadLine();
                    int value;
                    if (int.TryParse(ListInput, out value))
                    {
                        Console.WriteLine("Enter a valid number!");
                    }
                    listItems = ListInput.Split(' ').Select(int.Parse).ToList();

                    Console.WriteLine("Your LIST contains " + listItems.Count() + " items, they are: ");
                    foreach (var listdata in listItems)
                    {
                        Console.WriteLine("\t\"{0}\"", listdata);
                    }
                    Console.ReadLine();
                    break;
                case "b":
                    Console.WriteLine();
                    Console.WriteLine("Input Name=Age pairs: ");
                    var dctInput = Console.ReadLine();
                    string[] arr = dctInput.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Dictionary<string, int> dct = new Dictionary<string, int>();

                    foreach (string t in arr)
                    {
                        string[] dctout = t.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        dct.Add(dctout[0], Convert.ToInt32(dctout[1]));
                    }
                    foreach(KeyValuePair<string, int> kvp in dct)
                    {
                        Console.WriteLine(kvp.Key+ " is " +kvp.Value+ " years old");
                    }
                    Console.ReadLine();
                    break;
                case "c":
                    Console.WriteLine();
                    Console.WriteLine("Input Name=Age pairs: ");
                    var slInput = Console.ReadLine();
                    string[] slarr = slInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    SortedList<string, int> sl = new SortedList<string, int>();

                    foreach (string t in slarr)
                    {
                        string[] slout = t.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        sl.Add(slout[0], Convert.ToInt32(slout[1]));
                    }
                    foreach (KeyValuePair<string, int> kvp in sl)
                    {
                        Console.WriteLine(kvp.Key + " is " + kvp.Value + " years old");
                    }
                    Console.ReadLine();
                    break;
                case "d":
                    List<string> listItemsData = new List<string>();
                    Console.WriteLine();
                    Console.WriteLine("Enter characters: ");
                    var stackInput = Console.ReadLine();
                    Stack s = new Stack();
                    listItemsData = stackInput.Split(' ').ToList();
                    Console.WriteLine("Your Stack contains: ");
                    for (int i = 0; i < listItemsData.Count(); i++)
                    {
                        char c = Convert.ToChar(listItemsData[i]) ;
                        s.Push(c);
                        Console.WriteLine(c);
                    }
                    Console.WriteLine("Pop all elements from Stack");

                    while (s.Count > 0) 
                    { 
                        Console.WriteLine(s.Pop()); 
                    }
                    
                    Console.ReadLine();

                    break;
                case "e":
                    Console.WriteLine("Queue");
                    break;
            }
        }

    }
}