using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_ravi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            f1.nome=Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double salario_media = (f1.salario + f2.salario) / 2.0;
            Console.WriteLine("Salario médio = " + salario_media);

            Console.WriteLine("Primeiro Funcionario: " + f1.nome);
            Console.WriteLine("Segundo Funcionario: " +f2.nome);

        }
    }
}
