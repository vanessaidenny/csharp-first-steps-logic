using System;

namespace Exercises
{    
    public class Exercise
    {        
        //Gives a random number from a maximum value obtained
        public static string RaffleNumber(int maxValue)
        {
            Random number = new Random();
            maxValue++;

            int raffle = number.Next(1,maxValue);
            var date = DateTime.Now;

            return $"\nNumber: {raffle} \nGenerated on {date:d} - {date:t}";
        }

        //Calculates the largest number of two obtained
        public static string LargerNumber(int firstValue, int secondValue)
        {
            int largerValue = Math.Max(firstValue,secondValue);
            return $"\nLargest number: {largerValue}";
        }

        /*
            Calculates the years elapsed between two dates

            Parameters:
                DateTime birthDate:
                   Date input to calculate the age

            Returns:
                return 0 when the date input is larger than today
                return years elapsed
        */
        public static int CalculatesAge(DateTime birthDate)
        {
            double daysInYear = 365.2425;

            if (birthDate >= DateTime.Today.Date)
                return 0;

            double daysElapsed = DateTime.Today.Subtract(birthDate).TotalDays;
            double totalAge = daysElapsed/daysInYear;

            return (int)Math.Truncate(totalAge);
        }

        /* Complicated Permissions Challenge
        Implement business rules that restrict access to users based
        on their permissions and their level. Display a different
        message to the user depending on their permissions and level.
        */
        public static string ComplicatedPermission(string permissionType, int permissionLevel)
        {            
            if (permissionType.Contains("Admin"))
                return permissionLevel > 55 ? 
                "\nWelcome, Super Admin user." :
                "\nWelcome, Admin user.";
            else if (permissionType.Contains("Manager"))
                return permissionLevel >= 20 ?
                "\nContact an Admin for access." :
                "\nYou do not have sufficient privileges.";
            else
                return "\nYou do not have sufficient privileges.";
        }

        /*
        Game Rules
            The hero and the monster will start with 10 health points.
            All attacks will be a value between 1 and 10.
            The hero will attack first.
            Print the amount of health the monster lost and their remaining health.
            If the monster's health is greater than 0, it can attack the hero.
            Print the amount of health the hero lost and their remaining health.
            Continue this sequence of attacking until either the monster's health or
            hero's health is zero or less.
            Print the winner.
        */
        public static string GameBattle()
        {
            int heroHealth = 10;
            int monsterHealth = 10;

            int count = 0;

            Random attack = new Random();

            do{
                Console.WriteLine($"\nATTACK - {++count}");

                int lostPoint = attack.Next(1,11);
                monsterHealth -= lostPoint;
                Console.WriteLine($"Monster lost {lostPoint} and now has {monsterHealth} health.");

                if (monsterHealth<=0) continue;

                lostPoint = attack.Next(1,11);
                heroHealth -= lostPoint;
                Console.WriteLine($"Hero lost {lostPoint} and now has {heroHealth} health.");
            }
            while(monsterHealth>0 && heroHealth>0);

            Console.WriteLine("\nBattle Result:");
            return heroHealth > monsterHealth ? "Hero wins!!" : "Monster wins!!";
        }
        
    }
}
