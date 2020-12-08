using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void AumentarSalario(double percentagem)
        {
            Salario = (1.0 + percentagem / 100.0) * Salario;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario;
        }
    }


}
