using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemAdvncedExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var second = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bombEfect = new Queue<int>(first);
            var bombCasing = new Stack<int>(second);
            var daturaBombs = 0;
            var cherryBombs = 0;
            var smokeDecoyBombs = 0;
            if (bombCasing.Count < bombEfect.Count)
            {
                while (bombCasing.Count > 0)
                {
                    MakeBombs(bombEfect, bombCasing, ref daturaBombs, ref cherryBombs, ref smokeDecoyBombs);
                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                        if (bombEfect.Count > 0 && bombCasing.Count > 0)
                        {
                            Console.WriteLine($"Bomb Effects: " + string.Join(", ", bombEfect));
                            Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasing));
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else if (bombEfect.Count == 0 && bombCasing.Count > 0)
                        {
                            Console.WriteLine($"Bomb Effects: empty");
                            Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasing));
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else if (bombEfect.Count > 0 && bombCasing.Count == 0)
                        {
                            Console.WriteLine($"Bomb Effects: " + string.Join(", ", bombEfect));
                            Console.WriteLine($"Bomb Casings: empty");
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else
                        {
                            Console.WriteLine($"Bomb Effects: empty");
                            Console.WriteLine($"Bomb Casings: empty");
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        return;
                    }

                }
            }
            else
            {
                while (bombEfect.Count > 0)
                {
                    MakeBombs(bombEfect, bombCasing, ref daturaBombs, ref cherryBombs, ref smokeDecoyBombs);
                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                        if (bombEfect.Count > 0 && bombCasing.Count > 0)
                        {
                            Console.WriteLine($"Bomb Effects: " + string.Join(", ", bombEfect));
                            Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasing));
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else if (bombEfect.Count == 0 && bombCasing.Count > 0)
                        {
                            Console.WriteLine($"Bomb Effects: empty");
                            Console.WriteLine($"Bomb Casings: " + string.Join(", ", bombCasing));
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else if (bombEfect.Count > 0 && bombCasing.Count == 0)
                        {
                            Console.WriteLine($"Bomb Effects: " + string.Join(", ", bombEfect));
                            Console.WriteLine($"Bomb Casings: empty");
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        else
                        {
                            Console.WriteLine($"Bomb Effects: empty");
                            Console.WriteLine($"Bomb Casings: empty");
                            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
                            Console.WriteLine($"Datura Bombs: {daturaBombs}");
                            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
                        }
                        return;
                    }

                }
            }
           
            Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            Console.WriteLine($"Bomb Effects: empty");
            Console.WriteLine($"Bomb Casings: empty");
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }



        private static void MakeBombs(Queue<int> bombEfect, Stack<int> bombCasing, ref int daturaBombs, ref int cherryBombs, ref int smokeDecoyBombs)
        {
            var efect = bombEfect.Peek();
            var casing = bombCasing.Peek();
            var sumOfBouth = efect + casing;
            if (sumOfBouth == 40)
            {
                daturaBombs++;
                bombEfect.Dequeue();
                bombCasing.Pop();
            }
            else if (sumOfBouth == 60)
            {
                cherryBombs++;
                bombEfect.Dequeue();
                bombCasing.Pop();
            }
            else if (sumOfBouth == 120)
            {
                smokeDecoyBombs++;
                bombEfect.Dequeue();
                bombCasing.Pop();
            }
            else
            {
                var newItem = bombCasing.Pop() - 5;
                bombCasing.Push(newItem);
            }
        }
    }
}
