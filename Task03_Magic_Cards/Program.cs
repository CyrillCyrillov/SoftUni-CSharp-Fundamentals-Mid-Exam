using System;
using System.Linq;
using System.Collections.Generic;

namespace Task03_Magic_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> validCards = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> deckOfCards = new List<string>();

            while (true)
            {
                string[] rawComands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string comand = rawComands[0];


                if (comand.ToUpper() == "READY")
                {
                    break;
                }

                if (comand.ToUpper() == "ADD")
                {
                    string cardName = rawComands[1];
                    if(validCards.Contains(cardName))
                    {
                        //deckOfCards.Remove(cardName);
                        //deckOfCards.RemoveAt(deckOfCards.Count - 1);
                        deckOfCards.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if (comand.ToUpper() == "INSERT")
                {
                    string cardName = rawComands[1];
                    int index = int.Parse(rawComands[2]);

                    if (index >= 0 && index <= deckOfCards.Count - 1 && validCards.Contains(cardName))
                    {
                        
                        //deckOfCards.RemoveAt(index);
                        //deckOfCards.Remove(cardName);
                        deckOfCards.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }

                else if (comand.ToUpper() == "REMOVE")
                {
                    string cardName = rawComands[1];
                    
                    if (validCards.Contains(cardName) && deckOfCards.Contains(cardName))
                    {
                        deckOfCards.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if (comand.ToUpper() == "SWAP")
                {
                    string cardNameOne = rawComands[1];
                    string cardNameTwo = rawComands[2];

                    int indexOne = deckOfCards.FindIndex(x => x == cardNameOne);
                    int indexTwo = deckOfCards.FindIndex(x => x == cardNameTwo);

                    // string heplTempVar = deckOfCards[indexOne];
                    
                    deckOfCards.RemoveAt(indexOne);
                    deckOfCards.Insert(indexOne, cardNameTwo);

                    deckOfCards.RemoveAt(indexTwo);
                    deckOfCards.Insert(indexTwo, cardNameOne);

                }

                else if (comand.ToUpper() == "SHUFFLE")
                {
                    deckOfCards.Reverse();
                }
            }

            Console.WriteLine(string.Join(' ', deckOfCards));
        }
    }
}
