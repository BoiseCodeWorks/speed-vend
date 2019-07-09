using System;
using vendmachine.Models;

namespace vendmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            VendMachine vm = new VendMachine(true);
            VendMachine vm2 = new VendMachine(false);

            bool inVend = true;
            while (inVend)
            {
                vm.PrintContents();
                System.Console.WriteLine("Press a number to chose an item or 'd' to deposit money");
                string choice = Console.ReadLine().ToLower();
                if (choice == "d")
                {
                    System.Console.Write("Enter an amount: ");
                    string amount = Console.ReadLine();
                    vm.AddMoney(amount);
                    continue;
                }
                vm.Vend(choice);
            }


        }
    }
}
