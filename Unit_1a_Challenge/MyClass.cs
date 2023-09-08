// Write a console program with a program class, and Main Function
// Add another class with any name, add variables 
// Using the new keyword create several objects
// Console writeline the Objects variables

using System;
					
public class MyClass
{
	public Variable Num1;
	public Variable Num2;
	public Variable Word1;

	public void Main()
	{
		Num1 = new Variable();
		Num2 = new Variable();
		Word1 = new Variable();
		
		// User input for Canvas Challenge 3
		Console.WriteLine("Please enter a number: ");
		Num1.number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The first chosen test variable is: " + Num1.number + "\n");
		
		Console.WriteLine("Please enter another number: ");
		Num2.number = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The second chosen test variable is: " + Num2.number + "\n");
		
		string booleanVar = (Num1.number > Num2.number) ? (Num1.number + " is greater than " + Num2.number) : (Num1.number + " is less than " + Num2.number);
		Console.WriteLine(booleanVar);
		
		// Basic math block for Canvas Challenge 2
		Console.WriteLine(Num1.number + " * " + Num2.number + " = " + (Num1.number * Num2.number));
		Console.WriteLine(Num1.number + " / " + Num2.number + " = " + (Num1.number / Num2.number));
		Console.WriteLine(Num1.number + " + " + Num2.number + " = " + (Num1.number + Num2.number));
		Console.WriteLine(Num1.number + " - " + Num2.number + " = " + (Num1.number - Num2.number));
		
		Word1.word = "\nThanks for checking out my little program!";
		Console.WriteLine(Word1.word);
	}
}

public class Variable
{
	public float number;
	public string word;
}
