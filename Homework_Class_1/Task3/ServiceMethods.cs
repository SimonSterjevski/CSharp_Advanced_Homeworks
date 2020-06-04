using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class ServiceMethods
    {
        public static void Play()
        {
            Random random = new Random();
            Console.WriteLine("Select: 1)Rock  2)Paper  3)Scissors");
            string playerChoise = Console.ReadLine();
            int computerChoise = random.Next(1, 4);
            switch (playerChoise)
            {
                case "1":
                    if (computerChoise == 1)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Rock}");
                        Console.WriteLine("It is a draw");
                        break;
                    } else if (computerChoise == 2)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Paper}");
                        Console.WriteLine($"{OptionEnum.Paper} is stronger than {OptionEnum.Rock}. You lost!");
                        Score.ComputerWins++;
                        break;
                    } else
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Scissors}");
                        Console.WriteLine($"{OptionEnum.Rock} is stronger than {OptionEnum.Scissors}. You won!");
                        Score.PlayerWins++;
                        break;
                    }
                case "2":
                    if (computerChoise == 1)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Rock}");
                        Console.WriteLine($"{OptionEnum.Paper} is stronger than {OptionEnum.Rock}. You won!");
                        Score.PlayerWins++;
                        break;
                    }
                    else if (computerChoise == 2)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Paper}");
                        Console.WriteLine("It is a draw");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Scissors}");
                        Console.WriteLine($"{OptionEnum.Scissors} is stronger than {OptionEnum.Paper}. You lost!");
                        Score.ComputerWins++;
                        break;
                    }
                case "3":
                    if (computerChoise == 1)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Rock}");
                        Console.WriteLine($"{OptionEnum.Rock} is stronger than {OptionEnum.Scissors}. You lost!");
                        Score.ComputerWins++;
                        break;
                    }
                    else if (computerChoise == 2)
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Paper}");
                        Console.WriteLine($"{OptionEnum.Scissors} is stronger than {OptionEnum.Paper}. You won!");
                        Score.PlayerWins++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Computer choise: {OptionEnum.Scissors}");
                        Console.WriteLine("It is a draw");
                        break;
                    }
                default:
                    Play();
                    break;
            }
            Console.WriteLine("Press enter to go to main menu");
            Console.ReadLine();
            Console.Clear();
        }

        public static void SeeStats()
        {
            if (Score.TotalGamesPlayed > 0)
            {
                Console.WriteLine($"Total games played: {Score.TotalGamesPlayed}");
                Console.WriteLine($" Player wins: {Score.PlayerWins}, {(double)Score.PlayerWins/Score.TotalGamesPlayed*100}%");
                Console.WriteLine($" Computer wins: {Score.ComputerWins}, {(double)Score.ComputerWins/Score.TotalGamesPlayed*100}%");
            }
            else
            {
                Console.WriteLine("No games played yet!");
            }
            Console.WriteLine("Press enter to go to main menu");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
