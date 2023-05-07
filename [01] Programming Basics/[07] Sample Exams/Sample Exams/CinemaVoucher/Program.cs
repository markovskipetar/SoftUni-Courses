using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            int tickets = 0;
            int others = 0;

            while (true)
            {
                string purchase = Console.ReadLine();

                if (purchase == "End")
                {
                    break;
                }

                if (purchase.Length > 8)
                {
                    int moneyForTickets = purchase[0] + purchase[1];

                    if (moneyForTickets <= voucher)
                    {
                        tickets++;
                        voucher -= moneyForTickets;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    int moneyForOthers = purchase[0];

                    if (moneyForOthers <= voucher)
                    {
                        others++;
                        voucher -= moneyForOthers;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(tickets);
            Console.WriteLine(others);
        }
    }
}
