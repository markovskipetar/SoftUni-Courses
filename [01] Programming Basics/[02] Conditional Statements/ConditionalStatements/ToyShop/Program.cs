using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double mominskoParti = double.Parse(Console.ReadLine());
            int lubovnoPoslanie = int.Parse(Console.ReadLine());
            int vosuchnaRoza = int.Parse(Console.ReadLine());
            int kluchodurjatel = int.Parse(Console.ReadLine());
            int karikatura = int.Parse(Console.ReadLine());
            int kusmetIznenada = int.Parse(Console.ReadLine());

            int allToysCount = lubovnoPoslanie + vosuchnaRoza + kluchodurjatel + karikatura + kusmetIznenada;
            double totalMoney = lubovnoPoslanie * 0.60 + vosuchnaRoza * 7.20 + kluchodurjatel * 3.60 + karikatura * 18.20 + kusmetIznenada * 22;

            if (allToysCount >= 25)
            {
                totalMoney *= 0.65;
            }

            totalMoney *= 0.90;

            if (totalMoney >= mominskoParti)
            {
                Console.WriteLine($"Yes! {(totalMoney - mominskoParti):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(mominskoParti - totalMoney):F2} lv needed.");
            }
        }
    }
}
