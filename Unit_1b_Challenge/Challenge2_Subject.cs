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
        
        
        // Second prompt for favorite subject
        Console.WriteLine("What's your favorite subject (Math, Science, Music, History, or Literature)?");
        string userSubject = Console.ReadLine();

        // Store user input in a variable
        string subject = userSubject;
        
        // Switch cases for each given subject
        switch (subject)
        {
            case "Math":
                Console.WriteLine("Wow, you must be smarter than me!");
                break;
            case "Science":
                Console.WriteLine("Awesome, I always wanted to be an engineer when I grew up!");
                break;
            case "Music":
                Console.WriteLine("Me too, I studied music performance for 2 years!");
                break;
            case "History":
                Console.WriteLine("I find history so fascinating!");
                break;				
            case "Literature":
                Console.WriteLine("I bet you read a lot more books than I do!");
                break;
            default:
                Console.WriteLine("Please type one of the options given. Case sensitive!");
                break;
        }
    }
}
