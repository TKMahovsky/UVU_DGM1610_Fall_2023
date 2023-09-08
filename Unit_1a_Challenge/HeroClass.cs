//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero heroFour;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		heroFour = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		heroThree.health = 2;
		heroThree.heroArmor = 5;
		
		heroFour.health = 3;
		heroFour.powerBoost = 3;
		
		Console.WriteLine("Hero One health: " + heroOne.health);
		Console.WriteLine("Hero One power level: " + heroOne.powerLevel + "\n");
		
		Console.WriteLine("Hero Two health: " + heroTwo.health);
		Console.WriteLine("Hero Two power level: " + heroTwo.powerLevel + "\n");
		
		Console.WriteLine("Hero Three health: " + heroThree.health);
		Console.WriteLine("Hero Three found armor worth " + heroThree.heroArmor + ", his health is now " + (heroThree.health += heroThree.heroArmor) + "!!\n");
		
		Console.WriteLine("Hero Four health: " + heroFour.health);
		Console.WriteLine("Hero Four found a 3x power boost, her health has multiplied to " + (heroFour.health * heroFour.powerBoost) + "!");
	}
}

public class Hero
{
	public int health;
	public int powerLevel;
	public int powerBoost;
	public int heroArmor;
}
