using System;

public class Program
{
    public void Main()
    {
            // Prompt user to input number
    		Console.WriteLine("Enter your grade percentage");
    		string userInput = Console.ReadLine();

            // Store user input in a variable
    		int grade = Convert.ToInt32(userInput);

            // if/else-if/else block that outputs the correct letter grade
    		if (grade >= 90 && grade <= 100)
    		{
    			Console.WriteLine("You got an A!");
    		}
    		else if (grade >=80 && grade <= 89)
    		{
    			Console.WriteLine("You got a B!");
    		}
    		else if (grade >=70 && grade <= 79)
    		{
    			Console.WriteLine("You got a C!");
    		}
    		else if (grade >=60 && grade <= 69)
    		{
    			Console.WriteLine("You got a D... Study more!");
    		}
    		else if (grade >=0 && grade <= 59)
    		{
    			Console.WriteLine("You got an F... Yikes!");
    		}
    		else
    		{
    			Console.WriteLine("Invalid input, try again :(");
    		}
    }
}
