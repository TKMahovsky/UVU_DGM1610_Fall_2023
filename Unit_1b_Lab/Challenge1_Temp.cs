using System;

public class Program
{
    public void Main()
    {
        // Prompt in terminal for user to input a number
        Console.WriteLine("What is the current temperature outside (in Celsius)?");

        // Variable that stores the user input
        string userInput = Console.ReadLine();

        // If-else statement that outputs the requested responses
        if (Convert.ToInt32(userInput) > 30)
        {
          Console.WriteLine("Stay hydrated and avoid staying in the sun for too long!");
        }
        
        else
        {
          Console.WriteLine("Enjoy the pleasant weather!");
        }
    }
}
