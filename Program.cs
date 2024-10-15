using ExercicioLista;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;

namespace ExecicioLista {
    class Program {
        static void Main(string[] args) {

            List<Employer> list = new List<Employer>();

            Console.Write("Quantos funcionários vão ser registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Empregado #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employer(id, name, salary));
            }

            Console.WriteLine();
            
            Console.Write("Entre com o id do empregado que ira receber o aumento: ");
            int searchId = int.Parse(Console.ReadLine());

            Employer emp = list.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.WriteLine("Entre com a porcentagem: ");
                double procentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(procentagem);
            }else {
                Console.WriteLine("Essa id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de empregados atualizada: ");
            foreach(Employer obj in list) {
                Console.WriteLine(obj);
            }
            
            

            

        }
    }
}
