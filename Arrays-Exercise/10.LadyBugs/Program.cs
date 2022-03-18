using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsPlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] playingField = new int[fieldSize];
            playingField = ladybugsPlaces;


            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputArray = input.Split();

                int indexOfLadybug = int.Parse(inputArray[0]);
                int moves = int.Parse(inputArray[2]);
                if (indexOfLadybug < 0 || indexOfLadybug >= fieldSize || playingField[indexOfLadybug] == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (moves < 0 && inputArray[1] == "left")
                {
                    inputArray[1] = "right";
                }
                else if (moves < 0 && inputArray[1] == "right")
                {
                    inputArray[1] = "left";
                }

                moves = Math.Abs(moves);
                switch (inputArray[1])
                {
                    case "left":
                        if (moves > 0)
                        {
                            playingField[indexOfLadybug] = 0;
                            if (indexOfLadybug - moves < 0)
                            {
                                break;
                            }

                            if (playingField[indexOfLadybug - moves] == 1)
                            {
                                if (indexOfLadybug - moves * 2 < 0)
                                {
                                    break;
                                }
                                else
                                {
                                    playingField[indexOfLadybug - moves * 2] = 1;
                                    break;
                                }
                            }

                            playingField[indexOfLadybug - moves] = 1;

                        }
                        break;
                    case "right":
                        if (moves > 0)
                        {
                            playingField[indexOfLadybug] = 0;
                            if (indexOfLadybug + moves >= playingField.Length)
                            {
                                break;
                            }
                            if (playingField[indexOfLadybug + moves] == 1)
                            {
                                if (indexOfLadybug + moves * 2 >= playingField.Length)
                                {
                                    break;
                                }
                                else
                                {
                                    playingField[indexOfLadybug + moves * 2] = 1;
                                    break;
                                }

                            }


                            playingField[indexOfLadybug + moves] = 1;

                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", playingField));
        }
    }
}
