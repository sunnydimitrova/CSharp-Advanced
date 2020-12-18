using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var version = new Stack<string>();
            var text = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = int.Parse(input[0]);
                if (command == 1)
                {
                    version.Push(text.ToString());
                    text.Append(input[1]);
                }
                else if (command == 2)
                {
                    version.Push(text.ToString());
                    var elmentForRemove = int.Parse(input[1]);
                    text.Remove(text.Length - elmentForRemove, elmentForRemove);
                }
                else if (command == 3)
                {
                    var index = int.Parse(input[1]) - 1;
                    Console.WriteLine(text[index]);
                }
                else
                {
                    text.Clear();
                    text.Append(version.Pop());
                }
            }
        }
    }
}
