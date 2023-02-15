using System;
using System.Globalization;
using ConsoleApp1.Entities;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments) 
            {
                Console.WriteLine(installment);
            }
            

        }
    }
}