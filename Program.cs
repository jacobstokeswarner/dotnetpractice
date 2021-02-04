/*

C# Console app assignment:
Create a console app menu with options for running the programs below. Developers make sure your menu repeats until the user chooses to quit.
You will also need to CREATE A MENU CLASS WITH A METHOD FOR EACH PROGRAM BELOW. INCLUDING A METHOD FOR PRINTING THE MENU.

A: Input/Output: Write a program to prompt the user for their name, and greet them by name.
B: Numeric Types: Write a program to calculate the area of a rectangle and print the answer to the console. You should prompt the user for the demensions.
(what data types should the dimensions be?)
C: Numeric types: Write a program that asks a user for the number of miles they have driven and the amount of gas they have consumed(in gallons) and print
their miles per gallon.
D: Strings: The first sentence of Alice's adventures in wonderland is below. Store this sentence in a string, and then prompt the user for a string search
for within this string. Print whether or not the search term was found. See if you can make the search case-insensitive, so that the search for "alice" 
prints true.

Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her 
sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'
*/
using System;

namespace dotnet_practice_project
{
    class Program
    {
        static void Main(string[] args)
        {
          Menu();
        }

        static void userName ()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + " , nice to meet you!");
            Console.Write("Do you wish to return to the menu? y/n? (y returns you back to the menu, n exits the application");
            string yesOrNo = Console.ReadLine();

            if (yesOrNo == "y")
            {
                Menu();
            }

            else
            {
                Console.ReadLine();
            }
        }

        static void RectangleArea ()
        {
            Console.WriteLine("You have chosen to find the area of a rectangle. Please enter the length of the rectancle (as whole number");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle, again as a whole number");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is " + (lenght * width));
            Console.WriteLine("Do you wish to return to the menu? y/n? (y returns you back to the menu, n exits the application");
            string yesOrNo = Console.ReadLine();
            
             if (yesOrNo == "y")
            {
                Menu();
            }

            else
            {
                Console.ReadLine();
            }


        }

        static void MilesPerGallon ()
        {
            Console.WriteLine("You have chosen to determine how many miles per gallon you have!");
            Console.WriteLine("How many miles have you driven?(as a whole number?");
            int miles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much gas have you used up? (in gallons)");
            int gallons = Convert.ToInt32(Console.ReadLine());
            double milesPerGallon = miles / gallons ;
            Console.WriteLine("You get " + milesPerGallon + " miles per gallon!");
            Console.Write("Do you wish to return to the menu? y/n? (y returns you back to the menu, n exits the application");
            string yesOrNo = Console.ReadLine();

            if (yesOrNo == "y")
            {
                Menu();
            }

            else
            {
                Console.ReadLine();
            }



        }

        static void StringSearch ()
        {

            string story = @"Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her 
            sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            story = story.ToLower();

            Console.WriteLine("enter a word to see if it is in the string (only one word, no spaces");
            string wordSearch = Console.ReadLine();
            wordSearch = wordSearch.ToLower();
            if (story.Contains(wordSearch))
            {
                Console.WriteLine("your word was found! Would you like to try again?(y or n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    StringSearch();
                }

                 else if (answer == "n")
                {
                    Menu();
                }

                else
                {
                    Console.WriteLine("Invalid answer, try again");
                    StringSearch();
                }
            }
            else
            {
                Console.WriteLine("Word not found! would you like to try again? (y or n)");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    StringSearch();
                }

                else if (answer == "n")
                {
                    Menu();
                }

                else 
                {
                    Console.WriteLine("Invalid answer, try again");
                    StringSearch();

                }
            }
            

        }

        static void Menu ()
        {

            Console.WriteLine("Please enter a character 0-3 to choose an aplication");
            Console.WriteLine ("0:  Greeting");
            Console.WriteLine("1:   Area of rectangle");
            Console.WriteLine("2:   Miles Per Gallon");
            Console.WriteLine("3:   Word Search");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                userName();
            }

            else if (choice == 1)
            {
                RectangleArea();
            }

            else if (choice == 2)
            {
                MilesPerGallon();
            }
            else if (choice == 3)
            {
                StringSearch();
            }

            else
            {
                Console.WriteLine("You have made an invalid selection, try again.");
                Menu();
            }

        }



    }
}
