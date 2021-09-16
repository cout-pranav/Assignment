using System;
using System.Collections.Generic;
using System.IO;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Open File And Read File Content One By One
            var filePath = @"C:\Users\tambatp\OneDrive - Lenze SE\Desktop\learn code\FirstAssignment\FirstAssignment\sample.txt";
            var fileName = Path.GetFileName(filePath);

            var linesCount = 0;
            //read one line at a time from file

            Dictionary<string, List<int>> openWith = new Dictionary<string, List<int>>();

            foreach (var line in File.ReadLines(filePath))
            {
                linesCount++;
                //if line is black
                if (String.IsNullOrWhiteSpace(line))
                    continue;

               

                var words = line.Split(' ');

                foreach (var word in words)
                {
                    var cleanWord = MakeWordClean(word).ToLower();

                    
                    // if word is already there in dictionary
                    if ( openWith.ContainsKey(cleanWord) )
                    {
                        // insertion of word & list of lines on which it has occured
                        var list = openWith[cleanWord];
                        list.Add(linesCount-1);
                        openWith[cleanWord] = list;
                        
                    }
                    else// if word is not there in dictionary
                    {
                        //adding line num with as value
                        openWith.Add(cleanWord, new List<int>() { linesCount-1 });
                    }
                }

            }//endFor

//  *********************Indexing of Lines Starts From 0 **********************
            // KeyAndItsOccurance(openWith);

            Console.WriteLine("Input String:");
            var inputString = Console.ReadLine().ToLower();

           
            if (openWith.ContainsKey(inputString))
            {
                var value = openWith[inputString];

                Console.WriteLine("Total occurrences: {0}", value.Count);

                Console.WriteLine("Input integer:");
                var intValue = Convert.ToInt32(Console.ReadLine());

                if(intValue > value.Count )
                {
                    Console.WriteLine($"Value Entered Is Greater Than Count Of {inputString}");
                }
                else
                {
                    Console.WriteLine("Answer: Line {0}", value[intValue-1]);
                }
 
            }
            else
            {
                Console.WriteLine("String is not present");
            }
            
        }//end Main

      public static void KeyAndItsOccurance(Dictionary<string, List<int>> openWith)
        {
            foreach (KeyValuePair<string, List<int>> kvp in openWith)
            {
                var Key = kvp.Key;
                var Value = kvp.Value;

                Console.Write($"Key => {Key}" + " ");

                Console.Write(",Occurance Line =>");
                foreach (var v in Value)
                {
                    Console.Write(v + " ");
                }

                Console.WriteLine("\n");
            }
        }
        /// <summary>
        /// Fuction removes prefix and sufix from word 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string MakeWordClean(string word)
        {
            int start = 0;
            int end = word.Length - 1;


            if(word.EndsWith('.') || word.EndsWith(','))
            {
                end--;
            }

            if (word.EndsWith('\'') || word.EndsWith(')'))
            {
                end--;
            }


            if (word.StartsWith('\'') || word.StartsWith('(') )
            {
                start++;
            }
   
            return word.Substring(start,end-start+1);
        }
    }
}
