using System;

public class Program
{
	
    public void Main()
    {
	Console.WriteLine("Please type a number to build your pyramid:");
	int userNum = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("\nHere is your pyramid!\n");
		
	for (int i = 1; i <= userNum; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
		Console.WriteLine();
	}
    }
}
