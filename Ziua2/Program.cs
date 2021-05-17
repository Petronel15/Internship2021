using System;
using System.Collections.Generic;
using Core;
using Core.Exceptions;
using Service;

namespace Ziua2
{
    class Program
    {
        private static CustomerCommands customerCommands;

        static Program()
        {
            customerCommands = new CustomerCommands();
        }

        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Console patcient management \r");

            while (!endApp)
            {
                try
                {
                    Console.WriteLine("Please select an option: 1 - view customers; 2 - add customers  ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            customerCommands.ShowCustomers();
                            break;
                        case "2":
                            customerCommands.AddCustomers();
                            break;
                        default:
                            Console.WriteLine("Wrong option");
                            Console.WriteLine("Please select an option: 1 - view customers; 2 - add customers  ");
                            break;
                    }

                    Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue:");
                    if (Console.ReadLine() == "q")
                        endApp = true;
                    Console.WriteLine("\n");

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
