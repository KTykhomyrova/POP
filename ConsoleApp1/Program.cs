using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        class User {
            public string firstName { get; }
            public string lastName { get; }
            public string email { get; }
            public int age { get; }
            public string? PhoneNamber { get; }

            internal User(string firstname, string lastname, string Email, int Age) {
                if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname)) {
                    throw new ArgumentException("Imię i nazwisko nie może być puste");
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) {
                    throw new ArgumentException("Niepoprawny adres email");
                }
                if (age<0) {
                    throw new ArgumentException("Wiek musi być większe zera");
                }
                if (!string.IsNullOrEmpty(PhoneNamber) && !Regex.IsMatch(PhoneNamber, @"^\+?\d{9,15}$")) {
                    throw new ArgumentException("Niepoprawny numer");
                }
                firstName = firstname;
                lastName = lastname;
                email = Email;  
                age = Age;
            }
        }
        static void Main(string[] args) {
            try {
                User user = new User("Janusz", "Nowak", "Janusz.nowak@gmail.com", 20);

                Console.WriteLine($"Utworzono użytkownika: {user.firstName}, {user.lastName}, {user.email}, wiek {user.age}");

            } catch (ArgumentException ex){
                Console.WriteLine($"Błąd: {ex.Message}");
            }


            


        }
    }
}
