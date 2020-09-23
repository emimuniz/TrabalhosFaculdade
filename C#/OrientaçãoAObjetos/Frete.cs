using System;
namespace ConsoleApp3 {
    class Program {
        static void Main (string[] args) {
            double peso, t, c;
            int op;
            string ops;
            do {
                do {
                    Console.Clear ();
                    Console.WriteLine (" Menu de Transporte ");
                    Console.WriteLine ("[1]  Lançar peso");
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
                        do {
                            Console.Write ("Digite o valor do peso em Kg: ");
                            peso = double.Parse (Console.ReadLine ());
                        } while (peso <= 0);
                        calculaTransporte ();
                        break;
                    default:
                        Console.Clear ();
                        Console.WriteLine ("Opção Inválida!");
                        Console.ReadKey ();
                        break;
                }
            } while (op != 0);
            void calculaTransporte () {
                t = 450 + (3.50 * peso);
                c = 230 + (3.70 * peso);
                Console.WriteLine ("Preço de transportação por caminhão: R$ " + c);
                Console.WriteLine ("Preço de transportação por trem: R$ " +
                    t);
                if (t < c) Console.WriteLine ("A melhor estratégia de transpotação é a de TREM!");
                else Console.WriteLine ("A melhor estratégia de transportação é a de CAMINHÃO!");
                Console.WriteLine ("Pressione qualquer tecla para voltar...");
                Console.ReadKey ();
            }
        }
    }
}
