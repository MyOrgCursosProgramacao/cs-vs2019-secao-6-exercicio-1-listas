using System;
using System.Collections.Generic;
using System.Globalization;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução do exercício proposto de listas da seção 6");
            Console.WriteLine("Entre com os dados dos funcionários");

            Console.Write("Quantos funcionários desejas registrar? ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            int id;
            string nome;
            double salario;
            double percentagem;
            bool loop = true;

            for (int i=1; i <= numeroFuncionarios; i++)
            {
                Console.WriteLine($"Funcionário #{i}");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                do
                {
                    Funcionario func = listaFuncionarios.Find(x => x.Id == id);
                    if (func != null)
                    {
                        Console.Write(Environment.NewLine
                            + "Id de funcionário existente."
                            + Environment.NewLine
                            + "Digite uma nova id para o funcionário: ");
                        id = int.Parse(Console.ReadLine());
                        loop = true;
                    }
                    else
                    {
                        loop = false;
                    }
                } while (loop);

                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Salário: R$ ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios.Add(new Funcionario(id, nome, salario));
            }

        }
    }
}
