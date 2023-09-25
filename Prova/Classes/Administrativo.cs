using System;
using Prova.Classes;

namespace Prova.Classes
{
    internal class Administrativo : Funcionario
    {
        public Administrativo(string nome, string cPF, int matricola, DateTime dataN, string sexo, double salario) 
            : base(nome, cPF, matricola, dataN, sexo, salario)
        {
            salario += (salario * 0.15);
            salario += 150;
        }
    }
}
