using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refaktoryzacja_kodu_3 {
    internal class Program {
        static void Main(string[] args) {
            //zaawansowanie dla przejrzystości

            List<string> names = new List<string> { "Katarzyna", "Franciszek", "Jan"};
            Dictionary<int, string> users = new Dictionary<int, string>();

            for (int i = 0; i < names.Count; i++) {
                users.Add(i + 1, names[i]);
            }

            Console.WriteLine("Podaj ID użytkownika 1 do 3:");
            if (int.TryParse(Console.ReadLine(), out int userId) && users.ContainsKey(userId)) {
                string userName = users[userId];
                string role = GetUserRole(userId);
                Console.WriteLine($"User: {userName}, rola: {role}");
            } else {
                Console.WriteLine("Niepoprawny numer roli");
            }
        }

        private static string GetUserRole(int roleId) => roleId switch {
            1 => "Administrator",
            2 => "Moderator",
            3 => "Użytkownik",
            _ => "Nieznana rola",
        };
    }
}
