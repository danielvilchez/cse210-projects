using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep4 World!");

       List<int> numbers = new List<int>();

       int userNumber = -1;

       // Bucle while
       while (userNumber != 0)
       {
        Console.Write("Enter a number (0 to quit)");

        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);

        if (userNumber != 0)
        {
            numbers.Add(userNumber);           
        }
       }

       // Part 1: Sum
       int sum = 0;
       foreach (int number in numbers)
       {
        sum += number;
       }

       Console.WriteLine($"The sum is: {sum}");

       // Part 2: Average
       float average = ((float)sum) / numbers.Count;
       Console.WriteLine($"The average is: {average}");

       // Part 3: The max
       // Se declara una variable max e inicializa con el primer elemento de la lista numbers
       int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}