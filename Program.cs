using System.Drawing;
using System.Text;

namespace ConsoleApp3; 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть число від 1 до 100: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Помилка: введене число не знаходиться в діапазоні від 1 до 100");
            }
        }
        else
        {
            Console.WriteLine("Помилка: введене значення не є числом");
        }
    }
}
