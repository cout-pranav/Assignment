using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace FirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //finding relative file path
            var filePath = Directory.GetCurrentDirectory();
            var indexOfBin = filePath.IndexOf("\\bin");
            var newPath = filePath.Remove(indexOfBin) + @"\sample.txt";

            var linesCount = 0;          
            Dictionary<string, List<int>> ourDictionary = new Dictionary<string, List<int>>();

            //read one line at a time from file
            foreach (var line in File.ReadLines(newPath))
            {
                linesCount++; 
                
                //if line is black
                if (String.IsNullOrWhiteSpace(line))
                    continue;

                //seperate words from file
                var words = line.Split(' ');

                    foreach (var word in words)
                    {
                        var cleanWord = PrefixSufixStrippngOnWord(word).ToLower();

                        
                        // if word is already there in dictionary
                        if ( ourDictionary.ContainsKey(cleanWord) )
                        {
                            // insertion of word & list of lines on which it has occured
                            var list = ourDictionary[cleanWord];
                            list.Add(linesCount);
                            ourDictionary[cleanWord] = list;
                            
                        }
                        else// if word is not there in dictionary
                        {
                            //adding line num with as value
                            ourDictionary.Add(cleanWord, new List<int>() { linesCount});
                        }
                    }

            }//endFor

//  *********************Indexing of Lines Starts From 0 **********************
            // KeyAndItsOccurance(openWith);

            Console.WriteLine("Input String:");
            var inputString = Console.ReadLine().ToLower();

           
            if (ourDictionary.ContainsKey(inputString))
            {
                var value = ourDictionary[inputString];

                Console.WriteLine("Total occurrences: {0}", value.Count);

                Console.WriteLine("Input integer:");
                var intValue = Convert.ToInt32(Console.ReadLine());

                if(intValue > value.Count )
                {
                    Console.WriteLine($"Value Entered Is Greater Than Count Of \" {inputString} \"   " );
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

        /// <summary>
        /// Fuction removes prefix and sufix from word 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string PrefixSufixStrippngOnWord(string word)
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
    }
}
