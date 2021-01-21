using System;
using System.Linq;
using System.Collections.Generic;

namespace Task02_List_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] rawComands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                //string comand = rawComands[0];


                if(rawComands[0].ToUpper() == "REPORT")
                {
                    break;
                }

                if(rawComands[0].ToUpper() == "BLACKLIST")
                {
                    //string name = rawComands[1];
                    int index = friendList.FindIndex(x => x == rawComands[1]);
                    friendList.RemoveAt(index);
                    friendList.Insert(index, "Blacklisted");
                    Console.WriteLine($"{rawComands[1]} was blacklisted.");
                }

                else if (rawComands[0].ToUpper() == "ERROR")
                {
                    //int index = int.Parse(rawComands[1]);
                    
                    if(friendList[int.Parse(rawComands[1])] != "Blacklisted" && friendList[int.Parse(rawComands[1])] != "Lost")
                    {
                        Console.WriteLine($"{friendList[int.Parse(rawComands[1])]} was lost due to an error.");
                        friendList.RemoveAt(int.Parse(rawComands[1]));
                        friendList.Insert(int.Parse(rawComands[1]), "Lost");
                    }
                }

                else if (rawComands[0].ToUpper() == "CHANGE")
                {
                    //int index = int.Parse(rawComands[1]);
                    //string newName = rawComands[2];

                    //if (int.Parse(rawComands[1]) >= 0 && int.Parse(rawComands[1]) <= friendList.Count - 1)
                    //{
                        Console.WriteLine($"{friendList[int.Parse(rawComands[1])]} changed his username to {rawComands[2]}.");
                        friendList.RemoveAt(int.Parse(rawComands[1]));
                        friendList.Insert(int.Parse(rawComands[1]), rawComands[2]);
                    //}
                }
            }

            int blacklistedNamesCount = 0;
            int lostNamesCount = 0;

            foreach (string chek in friendList)
            {
                if (chek == "Blacklisted") blacklistedNamesCount += 1;
                if (chek == "Lost") lostNamesCount += 1;
            }
            
            /*
            for (int i = 0; i <= friendList.Count - 1; i++)
            {
                if (friendList[i] == "Blacklisted")
                {
                    blacklistedNamesCount += 1;
                }

                if (friendList[i] == "Lost")
                {
                    lostNamesCount += 1;
                }
            }
            */

            Console.WriteLine($"Blacklisted names: {blacklistedNamesCount}");
            Console.WriteLine($"Lost names: {lostNamesCount}");
            Console.WriteLine(string.Join(' ', friendList));
        }
    }
}
