using System;
using Prova.Classes;

namespace Prova.Classes
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double ValorHE { get; set; }
        public string Especialidade { get; set; }

        public Medico(string cRM, double valorHE, string especialidade, string nome, string cPF, int matricola, DateTime dataN, string sexo, double salario) 
            : base(nome, cPF, matricola, dataN, sexo, salario)
        {
            salario += (salario * 0.20);
            CRM = cRM;
            ValorHE = valorHE;
            Especialidade = especialidade;

        }
    }
}
