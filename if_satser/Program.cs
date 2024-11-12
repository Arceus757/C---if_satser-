using System;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // Console.Write("Enter the firts number: ");
        // double num1 = Convert.ToDouble(Console.ReadLine());

        // Console.Write("Enter the second number: ");
        // double num2 = Convert.ToDouble(Console.ReadLine());

        // if (num1 > num2)
        // {
        //     Console.WriteLine($"{1} is the largest.");
        // }
        // else if (num1 < num2)
        // {
        //     Console.WriteLine($"{num2} is the largest.");
        // }
        // else
        // {
        //     Console.WriteLine("The numbers are equal.");
        // }



        // Uppgift 2 
        // Console.Write("Enter a number between 1-100: ");
        // int number = int.Parse(Console.ReadLine());

        // if (number >= 1 && number <= 100)
        // {
        //     string colorWord = "";

        //     if (number >= 1 && number <= 18)
        //     {
        //         colorWord = "Red";
        //     }
        //     else if (number >= 19 && number <= 30)
        //     {
        //         colorWord = "Yellow";
        //     }
        //     else if (number >= 31 && number <= 50)
        //     {
        //         colorWord = "Green";
        //     }
        //     else if (number >= 51 && number <= 99)
        //     {
        //         colorWord = "Purple";
        //     }
        //     else if (number == 100)
        //     {
        //         colorWord = "Blue"; // Assuming you want to handle 100 separately
        //     }

        //     Console.WriteLine(colorWord);
        // }
        // else
        // {
        //     Console.WriteLine("Number is not between 1-100");
        // }


        // Uppgift 3
        // Console.Write("Enter a number: ");
        // int number = int.Parse(Console.ReadLine());

        // if (number % 2 == 0)
        // {
        //     Console.WriteLine("The number is even.");
        // }
        // else
        // {
        //     Console.WriteLine("The number is odd.");
        // }


        // Uppgift 4
        Console.WriteLine("Enter a character: ");
        string? character = Console.ReadLine();

        switch(character) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }

    }
}