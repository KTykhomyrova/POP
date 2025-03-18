using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace refaktoryzacja_kodu_4 {
    internal class Program {
        static void Main(string[] args) {
            //unikanie NuulReferenceException poprzez ??
            //konwersja dużych instrukcji na directionary
            //użycie LINKQ
            //var names = names.Select(userName, index).ToDirectionary(u => u.Id, u=>Name);

            string name = null;
            Console.WriteLine(name ?? "Domyślna wartość");

            string[] names = { "Katarzyna", "Franciszek", "Jan" };
            var users = new Dictionary<int, string>();

            int index = 1;

            foreach (var UserName in names) {
                users.Add(index++, UserName);
            }

            Console.WriteLine("Podaj ID użytkownika 1 do 3:");
            if (int.TryParse(Console.ReadLine(), out int userId) && users.ContainsKey(userId)) {
                string userName = users[userId];
                string role = GetUserRole(userId);
                Console.WriteLine($"User: {userName}, rola: {role}");
            } else {
                Console.WriteLine("Niepoprawny numer roli");
            }
            Console.WriteLine("Podaj typ klienta(Silver, gold, platina):");

            string customerType = Console.ReadLine();
            int discount = GetDiscount(customerType);
            Console.WriteLine($"Rabat dla klienta: {customerType}, rabat {discount}%");
        }

        private static int GetDiscount(string customerType) {
            var discount = new Directory<string, int> {
                { "Silver", 5 },
                { "Gold", 10 },
                { "Platinum", 15 }
           };

        }

        private static string GetUserRole(int roleId) => roleId switch {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
