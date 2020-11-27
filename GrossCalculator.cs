using System;

namespace FinanceCalculator
{
    class GrossCalculator : IFinanceCalculator
    {
        public void Calculate()
        {
            int taxValue = 0;
            float netValue, grossValue = 0;
            
            Console.Write("Podaj kwotę netto: ");
            if (!float.TryParse(Console.ReadLine(), out netValue))
            {
                Console.WriteLine("Niepoprawna kwota netto.");
                return;
            }

            Console.Write("Podaj stawkę VAT (8 lub 23): ");
            if (!Int32.TryParse(Console.ReadLine(), out taxValue)
                || (taxValue != 8 && taxValue != 23))
            {
                Console.WriteLine("Niepoprawna stawka VAT.");
                return;
            }

            grossValue = netValue + netValue * taxValue / 100; 
            Console.WriteLine(String.Format("Kwota brutto: {0}", grossValue));
        }
    }
}
