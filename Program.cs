// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.Write("Masukkan satu huruf: ");
        char input = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (input == 'A' || input == 'I' || input == 'U' || input == 'E' || input == 'O')
        {
            Console.WriteLine($"Huruf {input} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {input} merupakan huruf konsonan");
        }
    }
}
