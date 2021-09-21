using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //locating file path
            var FilePath = Directory.GetCurrentDirectory();
            var IndexOfBin = FilePath.IndexOf("\\bin");
            var NewPath = FilePath.Remove(IndexOfBin) + @"\Array Numbers.txt";

            List<int> list = new List<int>();
           

            Console.WriteLine("How many numbers you want ?");
            Console.Write("Enter :");

            //take correct input from user
             int TotalElementCount;
            while (true)
            {
                try
                {
                    TotalElementCount = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have not entered integer number :(");
                    return;
                }
            }
        
            
            

            int Number;
            int iterator = 0;

            //Make sure that user enters number only
            Console.WriteLine("Enter numbers:");
            while (iterator < TotalElementCount)
            {
                try
                {
                    Number = int.Parse(Console.ReadLine());
                    list.Add(Number);
                    iterator++;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have not entered integer number :(");
                    continue;
                }
            }

            //writing list of numbers into file
            using (StreamWriter file = new StreamWriter(NewPath))
            {
                foreach (var element in list)
                {
                    file.WriteLine(element);
                }
            }

            //take input number from user
            int InputNumber;
            while (true)
            {
                Console.WriteLine("Please enter number who's pair count you want:");
                try
                {
                    InputNumber = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You have not entered integer number :(");
                    return;
                }
            }

            int CountOccuranceOfNumber =0;

            //start reading from file one by one
            string line;
            using (StreamReader file = new StreamReader(NewPath))
            {
                
                while ( (line = file.ReadLine())!=null )
                {
                    int NumberFromFile = int.Parse(line);

                    if (NumberFromFile == InputNumber)
                    {
                        CountOccuranceOfNumber++;
                    }
                }
            }

            //end logic
            if (CountOccuranceOfNumber <= 1)
            {
                Console.WriteLine($"Sorry! No pair found for input number {InputNumber}. :(");
            }

            else
            {
                Console.WriteLine("We Found {0} pairs for input number {1}. :)",CountOccuranceOfNumber/2,InputNumber);
            }



        }
    }
}
