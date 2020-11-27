using System;

namespace FinanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IFinanceCalculator calculator = null;
            Console.WriteLine("Wybierz operację:");
            Console.WriteLine("1 -> Wyliczenie kwoty brutto");

            switch (Console.ReadLine())
            {
                case "1":
                    calculator = new GrossCalculator();
                    break;
                default:
                    Console.WriteLine("Niepoprawny numer operacji.");
                    break;
            }

            calculator?.Calculate();

            Console.Write("Naciśnij dowolny klawisz, aby wyjść z programu.");
            Console.ReadKey();
        }
    }
}
