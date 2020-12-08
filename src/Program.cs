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

            Console.Write(Environment.NewLine + "Quantos funcionários desejas registrar? ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            int id;
            string nome;
            double salario;
            bool loop = true;

            for (int i = 1; i <= numeroFuncionarios; i++)
            {
                Console.WriteLine(Environment.NewLine + $"Funcionário #{i}");
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

                Console.Write("Salário: R$ ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine(Environment.NewLine + "Lista atualizada de funcionários: ");
            foreach (Funcionario obj in listaFuncionarios)
            {
                Console.WriteLine(obj);
            }

            Console.Write(Environment.NewLine + "Digite a Id do funcionário que terá aumento de salário: ");
            id = int.Parse(Console.ReadLine());
            do
            {
                Funcionario func = listaFuncionarios.Find(x => x.Id == id);
                if (func == null)
                {
                    Console.Write(Environment.NewLine
                        + "Id de funcionário inexistente."
                        + Environment.NewLine
                        + "Digite a Id para o funcionário que terá aumento de salário: ");
                    id = int.Parse(Console.ReadLine());
                    loop = true;
                }
                else
                {
                    Console.WriteLine(func);
                    Console.Write(Environment.NewLine + "Digite a percentagem de aumento de salário: ");
                    func.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    Console.WriteLine(Environment.NewLine + "Funcionário atualizado: " + func);
                    loop = false;
                }
            } while (loop);

            Console.WriteLine(Environment.NewLine + "Lista atualizada de funcionários: ");
            foreach (Funcionario obj in listaFuncionarios)
            {
                Console.WriteLine(obj);
            }

        }

    }
}
