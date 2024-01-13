using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        // La función muestra en la consola el mensaje "Welcome to the programa!".
        DisplayWelcomeMessage();

        // Las funciones piden el nomber del usuario y su numero favorito
        string userName = GettUserName();
        int userNumber = GetUserNumber();

        // La funcion calcula el cuadrado del numero y devuelve su resultado
        int squaredNumber = SquareNumber(userNumber);


        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GettUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int GetUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
