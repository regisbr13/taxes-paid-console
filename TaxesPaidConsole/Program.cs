using System;
using System.Globalization;
using System.Collections.Generic;
using TaxesPaidConsole.Entities;

namespace TaxesPaidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #{0} data:", i);
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payers.Add(new IndiviualPayer(name, anualIncome, healthExpend));
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new CompanyPayer(name, anualIncome, employees));
                }
            }


        }
    }
}
