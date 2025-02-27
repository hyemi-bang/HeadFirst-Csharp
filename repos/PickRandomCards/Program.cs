﻿using System;

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick : ");

            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
               foreach (string card in CardPicker.PickSomeCard(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            } else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
