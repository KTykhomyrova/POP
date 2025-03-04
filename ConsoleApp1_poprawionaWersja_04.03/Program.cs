using System;

namespace ConsoleApp1_poprawionaWersja_04._03 {
	internal class Program {
		class Employee {
			public string Name { get; }
			public DateOnly DateOfBirth { get; }
			public int Age => CalculateAge();

			public Employee(string name, DateOnly dateOfBirth) {
				Name = name;
				DateOfBirth = dateOfBirth;
			}

			private int CalculateAge() {
				var today = DateOnly.FromDateTime(DateTime.Today);
				int age = today.Year - DateOfBirth.Year;

				if(DateOfBirth > today.AddYears(-age))
					age--;
				return age;
			}
		}

		static void Main(string[] args) {
			string name = GetValidName();
			DateOnly dateOfBirth = GetValidateDateOfBirth();

			Employee emp = new Employee(name, dateOfBirth);
			Console.WriteLine($"Pracownik: {emp.Name}, wiek: {emp.Age}");
		}

		private static string GetValidName() {
			string name;
			const sbyte MinLength = 3;
			const sbyte MaxLength = 50;

			string[] errorMessage = new string[] {
				"imię nie może być puste!" +
				$"Imie muśi mieć co najmniej {MinLength} znaków" +
				$"Imie muśi mieć maksyamlne {MinLength} znaków"
			};
			do {
				Console.WriteLine("POdsj imię");
				name = Console.ReadLine()?.Trim();

				if(string.IsNullOrWhiteSpace(name)) {
					Console.WriteLine(errorMessage[0]);
				}else if(name.Length < ) {

				}
			}
			while(true);

			do {
				Console.WriteLine("Podaj imię");
				name = Console.ReadLine()?.Trim();

				if(string.IsNullOrWhiteSpace(name)) {
					Console.WriteLine("Błąd: imię nie może być puste");
				}
			}
			while(string.IsNullOrWhiteSpace(name));

			return name;
		}

		private static DateOnly GetValidateDateOfBirth() {
			DateOnly dateOfBirth;
			bool isValidDate = false;

			do {
				Console.WriteLine("Podaj datę urodzenia (rrrr-mm-dd):");
				string input = Console.ReadLine();

				if(DateOnly.TryParseExact(input, out dateOfBirth) && dateOfBirth <= DateOnly.FromDateTime(DateTime.Now)) {
					isValidDate = true;
				} else {
					Console.WriteLine("Błąd: niepoprawny format daty.");
				}

			} while(!isValidDate);

			return dateOfBirth;
		}
	}
}
