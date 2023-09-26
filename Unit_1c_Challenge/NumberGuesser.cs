using System;
					
public class Program
{
	public void Main()
	{
		//Generate a random number and store it in a variable
		Random rand = new Random();
		int refNum = rand.Next(1, 11);
		
		/*while loop with an if/else-if/else statement to check and
		provide feedback on the accuracy of the guess*/
		while (true)
		{
			//Prompt the user and accept an input value, which is stored in a variable
			Console.Write("Guess a number between 1 and 10: ");
			int userNum = Convert.ToInt32(Console.ReadLine());

			if (userNum < refNum)
			{
				Console.WriteLine("Too low! Try again.");
			}
			else if (userNum > refNum)
			{
				Console.WriteLine("Too high! Try again.");
			}
			else
			{
				Console.WriteLine("You got it! The number was " + refNum);
				break;
			}
		}
	}
}
