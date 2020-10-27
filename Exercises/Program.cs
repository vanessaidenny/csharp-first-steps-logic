using System;
using Exercises;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInsert your name:");
            var name = Console.ReadLine();

            Console.WriteLine($"\nHello, {name}! Select an option:");
            Console.WriteLine("1 - Obtain a raffle number");
            Console.WriteLine("2 - Obtain a larger number");
            Console.WriteLine("3 - Obtain the age");
            Console.WriteLine("4 - Complicated permission");
            Console.WriteLine("5 - Game Battle");
            Console.WriteLine("6 - Exit");

            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nInsert the max value to raffle a number:");
                    int maxValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Exercise.RaffleNumber(maxValue));
                    break;

                case 2:
                    Console.WriteLine("\nInsert the first number:");
                    int firstValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nInsert the second number:");
                    int secondValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Exercise.LargerNumber(firstValue, secondValue));
                    break;

                case 3:
                    Console.WriteLine("\nInsert your birth date: (dd/mm/yyyy)");

                    try {
                        DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                        int resultAge = Exercise.CalculatesAge(birthDate);
                        Console.WriteLine($"\nBirth: {birthDate:d} - Age: {resultAge}");
                    }
                    catch (FormatException){
                        Console.WriteLine("\nInvalid date format - Insert as (dd/mm/yyyy) format\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nInsert your permission's type");
                    Console.WriteLine("1 - Admin");
                    Console.WriteLine("2 - Manager");
                    Console.WriteLine("3 - Admin|Manager");
                    string permissionType = Console.ReadLine();

                    Console.WriteLine("\nInsert your permission's level:");
                    int permissionLevel = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Exercise.ComplicatedPermission(permissionType, permissionLevel));
                    break;

                case 5:
                    Console.WriteLine(Exercise.GameBattle());
                    break;

                case 6:
                default:
                    Exit();
                    break;
            }
                
            static void Exit()
            {            
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey(true);
            }
        }
    }
}