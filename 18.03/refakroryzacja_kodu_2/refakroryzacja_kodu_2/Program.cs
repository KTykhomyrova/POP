using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refaktoryzacja_kodu_2 {
    internal class Program {
        static void Main(string[] args) {
            //zmiana dłudich instrukcji warunkiwych na wyrażeniw switch
            Console.WriteLine("Podaj numer roli od 1 do 3:");
            if (int.TryParse(Console.ReadLine(), out int roleId)) {
                string role = GetUserRole(roleId);
            } else {
                Console.WriteLine("Niepoprawny numer roli");
            }
        }

        private static string GetUserRole(int roleId) => roleId switch 
        {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
