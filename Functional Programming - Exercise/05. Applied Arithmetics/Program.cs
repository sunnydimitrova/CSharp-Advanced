using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input;
            Action<int[]> print = (arr) => Console.WriteLine(string.Join(" ", arr));
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "print")
                {
                    print(numbers);
                }
                else
                {
                    Func<int[], int[]> mathOparation = OperationWhithNumbers(input);
                    numbers = mathOparation(numbers);
                }
            }
        }

        static Func<int[], int[]> OperationWhithNumbers(string input)
        {
            Func<int[], int[]> oparationWithNumbers = null;
            if (input == "add")
            {
                oparationWithNumbers = new Func<int[], int[]>((arr) =>
                {
                    return arr.Select(n => n + 1).ToArray();
                });
                
            }
            else if (input == "multiply")
            {
                oparationWithNumbers = new Func<int[], int[]>((arr) =>
                {
                    return arr.Select(n => n * 2).ToArray();
                });
            }
            else if (input == "subtract")
            {
                oparationWithNumbers = new Func<int[], int[]>((arr) =>
               {
                   return arr.Select(n => n - 1).ToArray();
               });
            }
            return oparationWithNumbers;

        }
    }
}
