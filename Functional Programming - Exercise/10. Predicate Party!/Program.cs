using System;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var gests = Console.ReadLine().Split().ToList();
            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                var splitedInput = input.Split();
                var removeOrDouble = splitedInput[0];
                var startOrEndOrLenght = splitedInput[1];
                if (removeOrDouble == "Remove" && startOrEndOrLenght == "StartsWith")
                {
                    
                }
            }
        }

        
    }
}
