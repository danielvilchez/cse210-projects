using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep3 World!");

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

       // Inicializar la variable de adivinanza con un valor inicial no válido.
       int guess = -1;

       // Bucle while
       while (guess != magicNumber)
       {
        Console.Write("What is your guess? ");
        // Leer la linea como numero entero
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }

        else 
        {
            Console.WriteLine("You guessed it!");
        }

       }
       
    }
}