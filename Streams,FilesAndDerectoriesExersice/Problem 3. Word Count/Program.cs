using System;
using System.IO;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllLines("words.txt");
            var text = File.ReadAllText("text.txt").ToLower();
            foreach (var item in words)
            {
                var counter = 0;
                var arrOfWord = text.Split();
                for (int i = 0; i < arrOfWord.Length; i++)
                {
                    if (item == arrOfWord[i])
                    {
                        counter++;
                    }
                }
                var currentWordInfo = $"{item} - {counter}";
                File.AppendAllText("actualResults.txt", currentWordInfo);
            }

        }
    }
}
