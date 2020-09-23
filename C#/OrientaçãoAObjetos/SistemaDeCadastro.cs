using System;
namespace ConsoleApp3 {
    class Program {
        static void Main (string[] args) {
            Horista prof1 = new Horista ();
            Regime prof2 = new Regime ();
            int op;
            string ops;
            do {
                do {
                    Console.Clear ();
                    Console.WriteLine ("Quantidade Máxima de Professores: " +
                        Professor.qntProfessor);
                    Console.WriteLine ("[1]  Professor: " + prof1.nome);
                    Console.WriteLine ("[2]  Professor: " + prof2.nome);
                    Console.WriteLine ("[0]  Sair");
                    ops = Console.ReadLine ();
                } while (int.TryParse (ops, out op) == false);
                switch (op) {
                    case 0:
                        Console.Clear ();
                        Console.WriteLine ("Pressione qualquer tecla para sair...");
                        Console.ReadKey ();
                        break;
                    case 1:
                        Console.Clear ();
                        prof1.MenuHorista ();
                        break;
                    case 2:
                        Console.Clear ();
                        prof2.MenuRegime ();
                        break;
                    default:
                        Console.Clear ();
                        Console.WriteLine ("Opção Inválida!");
                        Console.ReadKey ();
                        break;
                }
            } while (op != 0);
        }
        class Professor {
            public string nome;
            public static int qntProfessor = 0;
            public float salario { get; set; }
            public int cargaHoraria { get; set; }
            public int matricula;
        }
        class Regime : Professor {
            public Regime () {
                Console.Write ("Informe o nome do professor a ser cadastrado:  ");
                nome = Console.ReadLine ();
                salario = 2000;
                cargaHoraria = 40;
                qntProfessor++;
                matricula = qntProfessor;
            }
            public void MenuRegime () {
                int op;
                string ops;
                do {
                    do {
                        Console.Clear ();
                        Console.WriteLine ("Professor: " + nome);
                        Console.WriteLine ("Matricula: " + matricula);
                        Console.WriteLine ("Carga Horária Semanal: " +
                            cargaHoraria);
                        Console.WriteLine ("Salário: " + salario);
                        Console.WriteLine ("[1]  Mudar Salário");
                        Console.WriteLine ("[0]  Sair");
                        ops = Console.ReadLine ();
                    } while (int.TryParse (ops, out op) == false);
                    switch (op) {
                        case 0:
                            Console.Clear ();
                            Console.WriteLine ("Pressione qualquer tecla para voltar...");
                            Console.ReadKey ();
                            break;
                        case 1:
                            Console.Clear ();
                            Console.Write ("Informe o novo salário: ");
                            salario = float.Parse (Console.ReadLine ());
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
        class Horista : Professor {
            public float salarioHora;
            public Horista () {
                Console.Write ("Informe o nome do professor a ser 
cadastrado:  ");
                nome = Console.ReadLine ();
                salarioHora = 4.5F;
                cargaHoraria = 0;
                qntProfessor++;
                matricula = qntProfessor;
            }
            public void MenuHorista () {
                int op;
                string ops;
                do {
                    do {
                        Console.Clear ();
                        Console.WriteLine ("Professor: " + nome);
                        Console.WriteLine ("Matricula: " + matricula);
                        Console.WriteLine ("Quantidade de Horas Trabalhadas: " +
                            cargaHoraria);
                        Console.WriteLine ("Salário Atual: " + salario);
                        Console.WriteLine ("[1]  Adicionar Horas Trabalhadas");
                        Console.WriteLine ("[0]  Sair");
                        ops = Console.ReadLine ();
                    } while (int.TryParse (ops, out op) == false);
                    switch (op) {
                        case 0:
                            Console.Clear ();
                            Console.WriteLine ("Pressione qualquer tecla para voltar...");
                            Console.ReadKey ();
                            break;
                        case 1:
                            Console.Clear ();
                            Console.Write ("Informe as horas trabalhadas: ");
                            cargaHoraria += int.Parse (Console.ReadLine ());
                            salario = cargaHoraria * salarioHora;
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
    }
}
}
