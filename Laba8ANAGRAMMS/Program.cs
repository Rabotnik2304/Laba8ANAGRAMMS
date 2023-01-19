using System;
using System.Collections.Generic;

namespace Laba8ANAGRAMMS
{
    internal class Program
    {
        static void Main()
        {
            string[] array = new string[] {"code", "doce", "ecod", "framer", "frame"};
            
            List<string> listOfSortedWords = new List<string>();

            List<string> result = new List<string>();
            
            foreach (string notSortedWord in array)
            {
                char[] arrayOfLetters = new char[notSortedWord.Length];
                for (int i = 0; i < notSortedWord.Length; i++)
                {
                    arrayOfLetters[i] = notSortedWord[i];
                }
                Array.Sort(arrayOfLetters);

                string sortedWord = String.Join("", arrayOfLetters);
                
                bool isSortedWordInlistOfSortedWords = IsSortedWordInlistOfSortedWords(listOfSortedWords, sortedWord);

                if (isSortedWordInlistOfSortedWords)
                {
                    listOfSortedWords.Add(sortedWord);
                    result.Add(notSortedWord);
                }
            }

            result.Sort();
            
            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }

        private static bool IsSortedWordInlistOfSortedWords(List<string> listOfSortedWords, string sortedWord)
        {
            bool isSortedWordInlistOfSortedWords = true;
            foreach (string word in listOfSortedWords)
            {
                if (word == sortedWord)
                {
                    isSortedWordInlistOfSortedWords = false;
                }
            }

            return isSortedWordInlistOfSortedWords;
        }
    }
}