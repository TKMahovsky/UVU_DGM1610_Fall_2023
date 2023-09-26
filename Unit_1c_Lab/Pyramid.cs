using System;

public class Program
{
	
    public void Main()
    {
	//User input prompt, which is stored in a variable called userNum
	Console.WriteLine("Please type a number to build your pyramid:");
	int userNum = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("\nHere is your pyramid!\n");

	//Outer loop for establishing rows
	for (int i = 1; i <= userNum; i++)
        {
	//Inner loop for writing out each individual number for each row
	//Console.Write is used instead of WriteLine in order to create rows of numbers rather than one number per line
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
		Console.WriteLine();
	}
    }
}
