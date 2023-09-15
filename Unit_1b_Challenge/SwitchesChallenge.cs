// The Expectation is that you write your own code based
// on what you have learned in the class, it can be whatever you want
// If you are having trouble thinking of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.

using System;

public class Program
{
	public Character stealth;
	public Character mage;
	
    public void Main()
    {
	stealth = new Character();
	mage = new Character();
	
	stealth.charHealth = 5;
	stealth.charRange = 2;
	stealth.charSpeed = 10;
	
	mage.charHealth = 7;
	mage.charRange = 6;
	mage.charSpeed = 4;

	string userClass = "";
	
	while (true)
	{
		Console.Write("\nPlease type your chosen character class from the options listed below.\n - Stealth\n - Mage\n");
		userClass = Console.ReadLine();

		switch (userClass)
		{
			case "Stealth":
			case "Mage":
				Console.WriteLine("\nYou selected " + userClass);
				break;
			default:
				Console.WriteLine("Please type a valid character class");
				continue;
		}
		break;
	}

	string userPerk = "";
	
	while (true)
	{
	
		Console.WriteLine("\nType the name of your character's chosen perk based on the options listed below.\n - Speed\n - Range");
		userPerk = Console.ReadLine();
	
		switch (userPerk)
		{
			case "Speed":
			case "Range":
				Console.WriteLine("\nYou selected the " + userPerk + " perk.");
				break;
			default:
				Console.WriteLine("Please type a valid character perk");
				continue;
		}
		break;			
	}
	
	Console.WriteLine("Here are your character's stats:\n");
	
	if (userClass == "Stealth" && userPerk == "Speed")
	{
		Console.WriteLine(" --- " + userClass + " class ---\n" + " - Health: " + stealth.charHealth + "\n - Speed: " + (stealth.charSpeed + 1) + "\n - Range: " + stealth.charRange);	
	}
	else if (userClass == "Stealth" && userPerk == "Range")
	{
		Console.WriteLine(" --- " + userClass + " class ---\n" + " - Health: " + stealth.charHealth + "\n - Speed: " + stealth.charSpeed + "\n - Range: " + (stealth.charRange + 1));	
	}
	else if (userClass == "Mage" && userPerk == "Speed")
	{
		Console.WriteLine(" --- " + userClass + " class ---\n" + " - Health: " + mage.charHealth + "\n - Speed: " + (mage.charSpeed + 1) + "\n - Range: " + mage.charRange);	
	}
	else if (userClass == "Mage" && userPerk == "Range")
	{
		Console.WriteLine(" --- " + userClass + " class ---\n" + " - Health: " + mage.charHealth + "\n - Speed: " + mage.charSpeed + "\n - Range: " + (mage.charRange + 1));	
	}
	else
	{
		Console.WriteLine("Error encountered. Please run program again.");	
	}	
    }
}

public class Character
{
	public int charHealth;
	public int charRange;
	public int charSpeed;
}
