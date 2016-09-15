using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {

        /*
        Longest Word
        
        Challenge Description:

        In this challenge you need to find the longest word in a sentence. If the sentence has more than one word of the same length you should pick the first one. 

        Input sample:

        Your program should accept as its first argument a path to a filename. Input example is the following 
                
        1 some line with text
        2 another line  
        
        Each line has one or more words. Each word is separated by space char. 

        Output sample:

        Print the longest word in the following way. 

        
        1 some
        2 another
        */

        static void Main(string[] args)
        {
            // Initialize and declare Variables
            string sentence = "some line with text";

            int sentLeng = sentence.Length;
            string longWord = "";

            // Split into string and count words and lengths
            string[] sent = sentence.Split(' ');

            foreach (string word in sent)
            {
                // For each word in the array
                // We need to count the characters (chars) in each word
                // and determine which has the most chars
                int wordLength = word.Length;
                int longWordLength = longWord.Length;

                if (wordLength > longWordLength)
                {
                    longWordLength = wordLength;
                    longWord = word;
                }
            }
            // Print largest 
            Console.WriteLine("The the largest word in my sentence is {0}", longWord);

        }
    }
}
