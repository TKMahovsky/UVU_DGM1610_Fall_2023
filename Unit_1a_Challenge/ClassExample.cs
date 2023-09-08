//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;

public class ClassExample
{
	
}

public class ClassWithVariables
{
	public int number = 2;
	public string userName = "Bob";
	public string lastName = "Michaels";
	public float idNumber = 35.264f;
	public float age = 42;
	public float yearsWorking = 17;
	
}

public class ClassWithFunctions
{
	public ClassWithVariables variables;
	
	public void Main()
	{
		variables = new ClassWithVariables();
		Console.WriteLine("--- Running Function ---\n");
		Console.WriteLine("Name: " + variables.userName + " " + variables.lastName);
		Console.WriteLine("Bob has worked here for " + variables.yearsWorking + " years.");
		
		string ifStatement = (variables.age < 50f) ? (variables.userName + " is younger than 50") : (variables.userName + " is older than 50");
		Console.WriteLine(ifStatement);
		Console.WriteLine("He is " + variables.age);
		Console.WriteLine(variables.userName + " has been working this job for " + (variables.yearsWorking / variables.age * 100) + " percent of his life.");
	}
}
