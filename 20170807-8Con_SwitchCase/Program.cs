using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_8Con_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch-case : seçim listesi söz konusuysa, if e göre daha performanslı çalıştığı için tercih edilebilir. 
             */

            // UYGULAMA : ekrandan 1-2-3-4-5-6-7 şeklinde gün girilsin. bu günün hangi güne denk geldiğini yazı ile gösteren programı yazınız.

            Console.Write("Haftanın gününü giriniz : ");
            string gün = Console.ReadLine();

            switch (gün)
            {
                case "1": Console.Write("Pazartesi");break;
                case "2": Console.Write("Salı"); break;
                case "3": Console.Write("Çarşamba"); break;
                case "4": Console.Write("Perşembe"); break;
                case "5": Console.Write("Cuma"); break;
                case "6": Console.Write("Cumartesi"); break;
                case "7": Console.Write("Pazar"); break;

                default: Console.Write("öyle bir gün yok"); break;
            }

            Console.Read();
        }
    }
}
