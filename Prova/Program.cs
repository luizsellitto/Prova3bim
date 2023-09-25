using System;
using System.Reflection;
using Prova.Classes;
class Program
{
    static void Main(string[] args)
    {
        int matricula = 0;
        List<Funcionario> funcionario = new List<Funcionario>();
        List<Medico> medico = new List<Medico>();
        List<Administrativo> administrativo = new List<Administrativo>();
        try
        {
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar um novo funcionário padrão");
                Console.WriteLine("2 - Adicionar um novo funcionário médico");
                Console.WriteLine("3 - Adicionar um novo funcionário administrativo");
                Console.WriteLine("4 - Ver todos os funcionários");
                Console.WriteLine("5 - Sair");
                int menu = Convert.ToInt32(Console.ReadLine());
                if(menu == 1 || menu == 2 || menu == 3 || menu == 4 || menu == 5 )
                        switch (menu)
                {
                    case 1:
                        voltando1:;
                            try 
                            {
                            nome1:;
                                Console.WriteLine("Escreva o nome do funcionário:");
                                string nome = Console.ReadLine();
                                if (nome == "")
                                {
                                    Console.WriteLine("Nome deve estar preenchido");
                                    goto nome1;
                                }
                            cpf1:;
                                Console.WriteLine("Escreva o CPF do funcionário:");
                                string cPF = Console.ReadLine();
                                if (cPF == "")
                                {
                                    Console.WriteLine("CPF deve estar preenchido");
                                    goto cpf1;
                                }
                                Console.WriteLine("Escreva a data de nascimento do funcionário:");
                                DateTime dataN = DateTime.Parse(Console.ReadLine());
                            sexo1:;
                                Console.WriteLine("Escreva o sexo do funcionário:");
                                string sexo = Console.ReadLine();
                                if (sexo == "")
                                {
                                    Console.WriteLine("Sexo deve estar preenchido");
                                    goto sexo1;
                                }
                            salario1:;
                                Console.WriteLine("Escreva o salário do funcionário:");
                                double salario = Convert.ToDouble(Console.ReadLine());
                                if (salario <= 0)
                                {
                                    Console.WriteLine("Salário inválido, preencha novamente");
                                    goto salario1;
                                }

                                Funcionario f = new Funcionario(nome, cPF, matricula, dataN, sexo, salario);
                                funcionario.Add(f);
                                matricula++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Alguma informação provavelmente foi digitada com o formato inválido, tente novamente");
                                goto voltando1;
                            }
                            
                        break;
                    case 2:
                        voltando2:;
                            try
                            {
                            nome2:;
                                Console.WriteLine("Escreva o nome do funcionário:");
                                string nome = Console.ReadLine();
                                if (nome == "")
                                {
                                    Console.WriteLine("Nome deve estar preenchido");
                                    goto nome2;
                                }
                            cpf2:;
                                Console.WriteLine("Escreva o CPF do funcionário:");
                                string cPF = Console.ReadLine();
                                if (cPF == "")
                                {
                                    Console.WriteLine("CPF deve estar preenchido");
                                    goto cpf2;
                                }
                                Console.WriteLine("Escreva a data de nascimento do funcionário:");
                                DateTime dataN = DateTime.Parse(Console.ReadLine());
                            sexo2:;
                                Console.WriteLine("Escreva o sexo do funcionário:");
                                string sexo = Console.ReadLine();
                                if (sexo == "")
                                {
                                    Console.WriteLine("Sexo deve estar preenchido");
                                    goto sexo2;
                                }
                            salario2:;
                                Console.WriteLine("Escreva o salário do funcionário:");
                                double salario = Convert.ToDouble(Console.ReadLine());
                                if (salario <= 0)
                                {
                                    Console.WriteLine("Salário inválido, preencha novamente");
                                    goto salario2;
                                }
                            cRM:;
                                Console.WriteLine("Digite a CRM do funcionário");
                                string cRM = Console.ReadLine();
                                if (cRM == "")
                                {
                                    Console.WriteLine("CRM deve estar preenchido");
                                    goto cRM;
                                }
                            vHE:;
                                Console.WriteLine("Escreva o valor da hora extra do funcionário:");
                                double vHE = Convert.ToDouble(Console.ReadLine());
                                if (vHE <= 0)
                                {
                                    Console.WriteLine("Valor de hora extra inválido, preencha novamente");
                                    goto vHE;
                                }
                            especialidade:;
                                Console.WriteLine("Digite a especialidade do funcionário");
                                string especialidade = Console.ReadLine();
                                if (especialidade == "")
                                {
                                    Console.WriteLine("A especialidade deve estar preenchida");
                                    goto especialidade;
                                }


                                Medico m = new Medico(cRM, vHE, especialidade, nome, cPF, matricula, dataN, sexo, salario);
                                medico.Add(m);
                                matricula++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Alguma informação provavelmente foi digitada com o formato inválido, tente novamente");
                                goto voltando2;
                            }
                            break;
                    case 3:
                        voltando3:;
                            try
                            {
                            nome3:;
                                Console.WriteLine("Escreva o nome do funcionário:");
                                string nome = Console.ReadLine();
                                if (nome == "")
                                {
                                    Console.WriteLine("Nome deve estar preenchido");
                                    goto nome3;
                                }
                            cpf3:;
                                Console.WriteLine("Escreva o CPF do funcionário:");
                                string cPF = Console.ReadLine();
                                if (cPF == "")
                                {
                                    Console.WriteLine("CPF deve estar preenchido");
                                    goto cpf3;
                                }
                                Console.WriteLine("Escreva a data de nascimento do funcionário:");
                                DateTime dataN = DateTime.Parse(Console.ReadLine());
                            sexo3:;
                                Console.WriteLine("Escreva o sexo do funcionário:");
                                string sexo = Console.ReadLine();
                                if (sexo == "")
                                {
                                    Console.WriteLine("Sexo deve estar preenchido");
                                    goto sexo3;
                                }
                            salario3:;
                                Console.WriteLine("Escreva o salário do funcionário:");
                                double salario = Convert.ToDouble(Console.ReadLine());
                                if (salario <= 0)
                                {
                                    Console.WriteLine("Salário inválido, preencha novamente");
                                    goto salario3;
                                }

                                Administrativo a = new Administrativo(nome, cPF, matricula, dataN, sexo, salario);
                                administrativo.Add(a);
                                matricula++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Alguma informação provavelmente foi digitada com o formato inválido, tente novamente");
                                goto voltando1;
                            }
                            break;
                    case 4:
                            Console.WriteLine("Funcionários Padrão: \n");
                            if (funcionario.Count != null)
                            {
                                foreach (Funcionario f in funcionario)
                                {
                                    Console.WriteLine($"Nome: {f.Nome} ; CPF: {f.CPF} ; Matrícula: {f.Matricola} ; Data de Nascimento: {f.DataN} ; Sexo: {f.Sexo} ; Salário: {f.Salario}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ainda não há funcionários padrão\n");
                            }
                            Console.WriteLine("\n Funcionários Médicos: \n");
                            if (medico.Count != null)
                            {
                                foreach (Medico m in medico)
                                {
                                    Console.WriteLine($"Nome: {m.Nome} ; CPF: {m.CPF} ; Matrícula: {m.Matricola} ; Data de Nascimento: {m.DataN} ; Sexo: {m.Sexo} ; Salário: {m.Salario} ; CRM: {m.CRM} ; Valor da Hora Extra: {m.ValorHE} ; Especialidade: {m.Especialidade}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ainda não há funcionários médicos\n");
                            }
                            Console.WriteLine("\n Funcionários Admnistrativos: \n");
                            if (administrativo.Count != null)
                            {
                                foreach (Administrativo a in administrativo)
                                {
                                    Console.WriteLine($"Nome: {a.Nome} ; CPF: {a.CPF} ; Matrícula: {a.Matricola} ; Data de Nascimento: {a.DataN} ; Sexo: {a.Sexo} ; Salário: {a.Salario}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ainda não há funcionários administrativos\n");
                            }
                            break;
                    case 5:
                        goto exit;
                        break;
                }


            }exit:;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Algo deu errado\n");
        }
    }
}