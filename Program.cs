// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;

namespace mybankUssd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Ussd:");
            var userInput =Convert.ToInt32(Console.ReadLine());
            var inputvalue = 919;

            if (userInput == inputvalue)
            {
                Console.Write("1: Airtime self\n" + "2: Airtime Others\n" + "3: Transfer Same Bank\n" + "4: Transfer Others Bank\n" + "5: Check Balnace\n" + "6: Bill Payment\n\n");

                Console.WriteLine("Enter a number:");
                var Input = Convert.ToByte(Console.ReadLine());

                switch (Input)
                {
                case 1:
                        Console.WriteLine("Enter amount:");
                        var rechargeAmont = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Pin:");
                        Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Are you sure...");
                        Console.WriteLine("1: Yes");
                        Console.WriteLine("2: No");

                        Console.WriteLine("Enter an option");
                       var option = Convert.ToInt32(Console.ReadLine());

                        var successful = 1;

                        if (option == successful)
                        {
                            Console.WriteLine("Successful");
                        }
                        else
                        {
                            Console.WriteLine("unSuccessful");
                        }
                    
                        break;
                case 2:
                        Console.WriteLine("Enter Phone number:");
                        Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter network option: ");
                        Console.WriteLine("1: MTN\n" + "2: GLO\n" + "3: Airtel\n" + "4: 9mobile");

                        Console.WriteLine("Choose number option: ");
                        Convert.ToByte(Console.ReadLine());

                        Console.WriteLine("Enter amount:");
                        Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Pin:");
                        Convert.ToByte(Console.ReadLine());

                        Console.WriteLine("Are you sure...");
                        Console.WriteLine("1: Yes");
                        Console.WriteLine("2: No");

                        Console.WriteLine("Enter an option: ");
                        var option2 = Convert.ToInt32(Console.ReadLine());

                        var successful2 = 1;

                        if (option2 == successful2)
                        {
                            Console.WriteLine("Successful");
                        }
                        else
                        {
                            Console.WriteLine("unSuccessful");
                        }

                        break;
                case 3:
                        Console.WriteLine("Enter account number:");
                        Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter amount:");
                        Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Pin:");
                        Convert.ToByte(Console.ReadLine());

                        Console.WriteLine("Are you sure...");
                        Console.WriteLine("1: Yes");
                        Console.WriteLine("2: No");

                        Console.WriteLine("Enter an option");
                        var option3 = Convert.ToInt32(Console.ReadLine());

                        var successful3 = 1;

                        if (option3 == successful3)
                        {
                            Console.WriteLine("Successful");
                        }
                        else
                        {
                            Console.WriteLine("unSuccessful");
                        }

                        break;
                case 4:
                    Console.WriteLine("1: Wema Bnak");
                    Console.WriteLine("2: Access Bank");
                    Console.WriteLine("3: Fidelity Bank");
                    Console.WriteLine("4: First Bnak");
                    Console.WriteLine("5: zenith Bnak");
                    Console.WriteLine("6: Providous Bnak");
                    Console.WriteLine("7: GT Bnak");
                    Console.WriteLine("98: Stanbic Bank");

                    Console.WriteLine("choose a number: ");
                    Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter account number: ");
                    Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter amount:");
                        Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Pin:");
                        Convert.ToByte(Console.ReadLine());

                        Console.WriteLine("Are you sure...");
                        Console.WriteLine("1: Yes");
                        Console.WriteLine("2: No");

                        Console.WriteLine("Enter an option");
                        var option4 = Convert.ToInt32(Console.ReadLine());

                        var successful4 = 1;

                        if (option4 == successful4)
                        {
                            Console.WriteLine("Successful");
                        }
                        else
                        {
                            Console.WriteLine("unSuccessful");
                        }
                        break;
                case 5:
                    Console.WriteLine("#20 fee rate applied");

                        Console.WriteLine("Enter Pin:");
                        Convert.ToByte(Console.ReadLine());
                        break;
                case 6:
                    Console.WriteLine("Utility bill: ");
                    Console.WriteLine("sporting and Gaming: ");
                    Console.WriteLine("Cable TV: ");
                        break;

                default:
                    Console.WriteLine("INVALID");
                    break;
                }  
            }
            else 
            {
                Console.WriteLine("Error SSSND");
            }
        }
    }
}
//Console.WriteLine("Hello, World!");

