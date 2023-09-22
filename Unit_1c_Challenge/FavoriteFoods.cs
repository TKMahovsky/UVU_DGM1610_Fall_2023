using System;
					
public class Program
{
	public void Main()
	{
		/*Creation of new string objects in a variable because
		I couldn't get the curly braces method to work how I wanted it to
		and I'm more used to python lists lol*/
        	string[] userFood = new string[3];
		
		/*Looping through 3 times to accept 3 user inputs
		then storing them in the array at their index*/
		for (int i = 0; i < 3; i++)
	        {
	            Console.Write("Enter your favorite food #{0}: ", i + 1);
	            userFood[i] = Console.ReadLine();
	        }
			
		//Providing feedback/response on the input foods
		Console.WriteLine("\nSo you're saying:");
	        foreach (string fav in userFood)
	        {
	            Console.WriteLine("I love " + fav + "!");
	        }
	}
}
