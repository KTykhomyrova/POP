using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04._03 {
	internal class Program {

		class Employee {
			//brak inkapsulacji, niepoprawne użycie pól zamiast właściwości (nie mamy kontroli nad ustawianiem wartości)
			//brak zabiezpieczenia pzed pustym imieniem
			public string Name;
			public int Age; //błędnr typ dannych(powinniśmy zastosować typ: bajt (0-255), ushort(0-65535), DataTime(misimy dodać metodę obliczająca wiek w czasie rzeczywistym))
			public double Salary;
			
			public Employee(string name, int age, double salary) {
				Name = name;
				Age = age;
				Salary = salary;
			}

			//brak walidacji w metodzie, nie sprawdzamy czy amount jest dodatnie
			public void IncreaseSalary(double amount) {
				Salary += amount;
			}
		}
		static void Main(string[] args) {
			
			Employee person = new Employee("Jan", 20, 1000.50);
			person.Age = -5; // możemy ustawić błędny wiek
			person.Salary = -1000; //możemy ustawić negatywną pensje

			Console.WriteLine($"Pracownik: {person.Name}, {person.Age}, {person.Salary}\n");

			

			

		}
	}
}
