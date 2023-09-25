using System;
using Prova.Classes;

namespace Prova.Classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set;}
        public int Matricola { get; set;}
        public DateTime DataN { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cPF, int matricola, DateTime dataN, string sexo, double salario)
        {
            Nome = nome;
            CPF = cPF;
            Matricola = matricola;
            DataN = dataN;
            Sexo = sexo;
            Salario = salario;
        }
    }
}
