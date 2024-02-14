using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How much did you receive money ($)? ");
            double money = double.Parse(Console.ReadLine());


            //For book and supplies:
            Console.WriteLine("\nBook and supplies: {0}$", money * 0.75);
            Console.WriteLine("You can then buy: ");

            //remaining amount for other items
            double remainingMoney = money * (0.25);
            double dividedAmount = remainingMoney / 3;


            // cost of each items
            double forCoffee = 2;
            double forFlashComputer = 4;
            double forSubwayTicket = 3;


            // total number of each items
            int numberCoffees = (int)(dividedAmount / forCoffee);
            int numberFlashComputers = (int)(dividedAmount / forFlashComputer);
            int numberSubwayTickets = (int)(dividedAmount / forSubwayTicket);

            // toal amount for each item
            double coffeeTotalCost = numberCoffees * forCoffee;
            double flashComputersCost= numberFlashComputers * forFlashComputer;
            double subwayTicketsCost = numberSubwayTickets * forSubwayTicket;

            // cost for white flowers after deducing every cost
            double countWhiteFlowers = remainingMoney - coffeeTotalCost - flashComputersCost - coffeeTotalCost;



            //displaying output as indicated
            Console.WriteLine("{0} Coffees\n\n{1} Flash Computer Numbers\n" +
                "{2} Subway Tickets\nand you will have {3} dollars for the " +
                "roses.", numberCoffees, numberFlashComputers, numberSubwayTickets, countWhiteFlowers);

            Console.ReadKey();

        }
    }
}
