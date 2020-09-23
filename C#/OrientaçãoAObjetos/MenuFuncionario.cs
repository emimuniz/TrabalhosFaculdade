using System;
namespace ConsoleApp3 {
    class Program {
        static void Main (string[] args) {
            Empregado func1 = new Empregado ();
            Empregado func2 = new Empregado ();
            int op;
            string ops;
            do {
                do {
                    Console.Clear ();
                    Console.WriteLine (" Menu de Funcionários ");
                    Console.WriteLine ("[1]  " + func1.nome);
                    Console.WriteLine ("[2]  " + func2.nome);
                    Console.WriteLine ("[0]  Sair");
                    ops = Console.ReadLine ();
                } while (int.TryParse (ops, out op) == false);
                switch (op) {
                    case 0:
                        Console.Clear ();
                        Console.WriteLine ("Pressione qualquer tecla para  sair...");
                        Console.ReadKey ();
                        break;
                    case 1:
                        Console.Clear ();
                        func1.Menu ();
                        break;
                    case 2:
                        Console.Clear ();
                        func2.Menu ();
                        break;
                    default:
                        Console.Clear ();
                        Console.WriteLine ("Opção Inválida!");
                        Console.ReadKey ();
                        break;
                }
            } while (op != 0);
        }
    }
    class Empregado {
        public string nome, departamento;

        public int horasTrabalhadasMes { get; set; }
        public double salarioPorHora { get; set; }
        static int qntFunc = 0;
        public Empregado () {
            do {
                Console.Write ("Informe o nome do funcionário a ser cadastrado:");
                nome = Console.ReadLine ();
                Console.Write ("Informe o departamento do mesmo: ");
                departamento = Console.ReadLine ();
            } while (nome == " " || departamento == " ");
            do {
                Console.Write ("Informe as horas que serão trabalhadas por mês ");
                horasTrabalhadasMes = int.Parse (Console.ReadLine ());
                Console.Write ("Informe o salário/hora: ");
                salarioPorHora = double.Parse (Console.ReadLine ());
            } while (horasTrabalhadasMes < 0 || salarioPorHora <= 0);
            qntFunc++;
        }
        public void Menu () {
            int op;
            string ops;
            do {
                do {
                    Console.Clear ();
                    Console.WriteLine (" {0} ", nome);
                    Console.WriteLine ("[1]  Mostrar Dados");
                    Console.WriteLine ("[2]  Calcular Salário Mensal");
                    Console.WriteLine ("[3]  Mudar Nome");
                    Console.WriteLine ("[4]  Mudar Departamento");
                    Console.WriteLine ("[5]  Mudar Horas de Trabalho Mensal");
                    Console.WriteLine ("[6]  Mudar Salário/hora");
                    Console.WriteLine ("[0]  Sair");
                    ops = Console.ReadLine ();
                } while (int.TryParse (ops, out op) == false);
                switch (op) {
                    case 0:
                        Console.Clear ();
                        Console.WriteLine ("Pressione qualquer tecla para  voltar...");
                        Console.ReadKey ();
                        break;
                    case 1:
                        Console.Clear ();
                        mostraDados ();
                        break;
                    case 2:

                        Console.Clear ();
                        calculaSalarioMensal ();
                        break;
                    case 3:
                        do {
                            Console.Clear ();
                            Console.Write ("Informe o novo nome do funcionário:");
                            nome = Console.ReadLine ();
                        } while (nome == " ");
                        break;
                    case 4:
                        do {
                            Console.Clear ();
                            Console.Write ("Informe o departamento do mesmo: ");
                            departamento = Console.ReadLine ();
                        } while (departamento == " ");
                        break;
                    case 5:
                        do {
                            Console.Clear ();
                            Console.Write ("Informe as horas que serão trabalhadas :");
                            horasTrabalhadasMes = int.Parse (Console.ReadLine ());
                        } while (horasTrabalhadasMes < 0);
                        break;
                    case 6:
                        do {
                            Console.Clear ();
                            Console.Write ("Informe o salário/hora: ");
                            salarioPorHora = double.Parse (Console.ReadLine ());
                        } while (salarioPorHora <= 0);
                        break;
                    default:
                        Console.Clear ();
                        Console.WriteLine ("Opção Inválida!");
                        Console.ReadKey ();
                        break;
                }
            } while (op != 0);
        }
        public void mostraDados () {
            Console.Clear ();
            Console.WriteLine ("Nome: " + nome);
            Console.WriteLine ("Departamento: " + departamento);
            Console.WriteLine ("Horas Trabalhadas por Mês: " +
                horasTrabalhadasMes);
            Console.WriteLine ("Salário Por Hora: " + salarioPorHora);
            Console.WriteLine ("Pressione qualquer tecla para voltar...");
            Console.ReadKey ();
        }
        public void calculaSalarioMensal () {
            Console.Clear ();
            Console.WriteLine ("Salário Mensal: " + (salarioPorHora *
                horasTrabalhadasMes));
            Console.WriteLine ("Pressione qualquer tecla para voltar...");
            Console.ReadKey ();
        }
    }
