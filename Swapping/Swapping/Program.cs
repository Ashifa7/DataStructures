using System;
using System.Collections.Generic;
using System.Linq;

namespace Swapping
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> GlobalDCT = new Dictionary<string, string>();
            Console.WriteLine("Minimum 2 Array Required for swapping!");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Name for your Array: ");           //Key
                string ArrayName = Console.ReadLine();

                Console.WriteLine("Enter Values in your Array: ");           //Value
                string ArrayValue = Console.ReadLine();

                GlobalDCT.Add(ArrayName, ArrayValue);                       //Add key-values to dct
            }
            bool EnterArr = true;
            do
            {
                Console.WriteLine("Want to enter more arrays? (y/n)");
                string read = Console.ReadLine();

                if(read == "y")
                {
                    Console.WriteLine("Enter Name for your Array: ");           //Key
                    string ArrName = Console.ReadLine();

                    Console.WriteLine("Enter Values in your Array: ");           //Value
                    string ArrValue = Console.ReadLine();

                    GlobalDCT.Add(ArrName, ArrValue);
                }
                else
                {
                    EnterArr = false;
                }
            }
            while (EnterArr);

            Console.WriteLine("You Entered Following Arrays: ");
            for (int i = 0; i < GlobalDCT.Count; i++)
            {
                Console.WriteLine($"{i} => {GlobalDCT.ElementAt(i).Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Choose Index of your target Array from above list: ");
            int TArr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose Index of your Replace Array from above list: ");
            int RArr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your Target Array contains: ");
            string[] TargetList = GlobalDCT.ElementAt(TArr).Value.Split(' ');
            for (int i = 0; i < TargetList.Length; i++)
            {
                Console.WriteLine($"{i} => {TargetList[i]}");
            }

            Console.WriteLine($"Your Replace Array = {GlobalDCT.ElementAt(RArr).Value}");
            string[] ReplaceList = GlobalDCT.ElementAt(RArr).Value.Split(' ');
            for (int i = 0; i < ReplaceList.Length; i++)
            {
                Console.WriteLine($"{i} => {ReplaceList[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Choose Target Index from Target Array: ");
            int TIndex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose Replace Index from Replace Array: ");
            int RIndex = Convert.ToInt32(Console.ReadLine());

            string TValue = TargetList[RIndex];

            string RValue = ReplaceList[TIndex];

            TargetList[TIndex] = RValue;

            ReplaceList[RIndex] = TValue;

            string newTList = string.Join(" ", TargetList.ToArray());
            string newRList = string.Join(" ", ReplaceList.ToArray());

            Console.WriteLine("After successull swap: ");
            Console.WriteLine("Your Target Array {0} is: {1}", GlobalDCT.ElementAt(TArr).Key, newTList);
            Console.WriteLine("Your Replace Array {0} is: {1}", GlobalDCT.ElementAt(RArr).Key, newRList);
        }
    }
}