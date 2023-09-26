using System;
					
public class Program
{
	public Car luxuryCar;
	public Boost nosBoost;
	public Car sportsCar;
	
	public void Main()
	{
		luxuryCar = new Car();
		nosBoost = new Boost();
		sportsCar = new Car();

		// These 2 lines are to show the boost amount in mph
		Console.WriteLine("Boost amount is: " + nosBoost.speedIncrease + " mph.");
		Console.WriteLine("");
		
		// These following 3 lines establish a top speed and then += the speed increase caused by the boost
		Console.WriteLine("Initial luxury car top speed: " + luxuryCar.luxuryTopSpeed);
		luxuryCar.luxuryTopSpeed += nosBoost.speedIncrease;
		Console.WriteLine("Boosted luxury car top speed is " + luxuryCar.luxuryTopSpeed + " for " + nosBoost.boostDuration + " seconds");
		
		Console.WriteLine("");
		// These folowing 3 lines do the same thing as above, but for the sports car instead of the luxury car
		Console.WriteLine("Initial sports car top speed: " + sportsCar.sportTopSpeed);
		sportsCar.sportTopSpeed += nosBoost.speedIncrease;
		Console.WriteLine("Boosted sports car top speed is " + sportsCar.sportTopSpeed + " for " + nosBoost.boostDuration + " seconds");
		Console.WriteLine("");
		
		/* The following 4 lines assign clunky connections to classes and variables to 
		much shorter, much more concise variable names. This also helps readability.
		Multi-line comment here just because I found the format in the documentation and liked it*/
		string luxName = luxuryCar.luxuryCarName;
		string sportName = sportsCar.sportsCarName;
		int luxSpeed = luxuryCar.luxuryTopSpeed;
		int sportSpeed = sportsCar.sportTopSpeed;
		
		//this if/else block is here to determing which car is faster, as well as to print the speed difference
		if (luxuryCar.luxuryTopSpeed < sportsCar.sportTopSpeed)
		{
			string cheerWord = "Wow!";
			Console.WriteLine("The " + sportName + " is faster than the " + luxName + " by " + Math.Abs(luxSpeed - sportSpeed) + " mph. " + cheerWord);
		}
		else
		{
			string cheerWord = "Darn!";
			Console.WriteLine("The " + sportName + " is slower than the " + luxName + " by " + Math.Abs(luxSpeed - sportSpeed) + " mph. " + cheerWord);
		}
	}
}

public class Car
{
	/* This is the Car class, and allows for user input for the top speeds. This method of user input makes 
	some things awkward but I thought it was neat to have a user input (especially a numeric input rather than a string).
	Couldn't think of a good way to make it display text along with the input when doing it this way, though. Very clunky.*/
	public string luxuryCarName = "Mercedes";
	public int luxuryTopSpeed = Convert.ToInt32(Console.ReadLine());
	public string sportsCarName = "Mustang";
	public int sportTopSpeed = Convert.ToInt32(Console.ReadLine());
}

public class Boost
{
	// This class defines boost, how much boosting increases the car speed by, and for how long
	public string boostName = "Nos";
	public int speedIncrease = 20;
	public float boostDuration = 12.5f;
}
