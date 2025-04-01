using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refaktoryxacja_kodu {
    internal class Program {

        static void Main(string[] args) {

            Console.Write("Wybierz klasę biletu (1 - Ekonomiczna, 2 - Biznesowa, 3 - Pierwsza klasa): ");

            int ticketType = int.Parse(Console.ReadLine());

            

            


            string[] clases = { "Ekonomiczna", "Biznesowa", "klassa" };
            var tickets = new Dictionary<int, string>();

            int index = 1;

            foreach (var item in tickets) {
                tickets.Add(index++, item);
            }

            string ticketClass = GetTicketClass(ticketType);

            Console.WriteLine($"Wybrana klasa: {ticketClass}");

        }



        private static string GetTicketClass(int ticketType) {

            var classess = new Directory<string, int> {
                { "Ekonomiczna", 1 },
                { "Biznesowa", 2 },
                { "Pirwsza klassa", 3 }
           };

        }

    }
}
