using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refaktoryzacja {
    internal class Program {
        static void Main(string[] args) {
            //zmiana dłudich instrukcji warunkiwych na wyrażeniw switch
            Console.WriteLine("Podaj numer roli od 1 do 3:");
            if (int.TryParse(Console.ReadLine(), out int roleId)) {
                string role = GetUserRole(roleId);
            } 
            else {
                Console.WriteLine("Niepoprawny numer roli");
            }
        }

        private static string GetUserRole(int roleId) {
            switch (roleId) {
                case 1:
                    return "Administrator";
                case 2:
                    return "Moderator";
                case 3:
                    return "Użytkownik";
                default:
                    return "Błędna rol";
            }
        }
    }
}
