using System;
namespace ConsoleApp138 {
    class Program {
        class Calculadora {
            public void Soma (int x, int y) {
                Console.WriteLine ("O valor é: {0}", x + y);
            }
            public void sub (int x, int y) {
                Console.WriteLine ("O valor é {0}", x­ y);
            }
            public void multi (int x, int y) {
                Console.WriteLine ("O valor é: {0}", x * y);
            }
            public void div (int x, int y) {
                Console.WriteLine ("O valor é: {0}", x / y);
            }
        }
        class CalculadoraCientifica : Calculadora {
            public void raiz (int x) {
                Console.WriteLine ("O valor é: {0}", Math.Sqrt (x));
            }
        }
        static void Main (string[] args) {
            bool flag = true;
            Calculadora Calcula = new Calculadora ();
            CalculadoraCientifica NovaCal = new CalculadoraCientifica ();
            Console.WriteLine ("===================================");
            Console.WriteLine ("Digite o primeiro valor: ");
            int x = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o segundo valor: ");
            int y = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite: ");
            Console.WriteLine ("1 Soma");
            Console.WriteLine ("2 Subtração");
            Console.WriteLine ("3 Multiplicação");
            Console.WriteLine ("4 Divisão");
            Console.WriteLine ("5 ­ Extração de Raiz");
            Console.WriteLine ("====================================");
            int opcao = int.Parse (Console.ReadLine ());
            do {
                switch (opcao) {
                    case 1:
                        Calcula.Soma (x, y);
                        flag = true;
                        break;
                    case 2:
                        if (x > y) Calcula.sub (x, y);
                        else if (y > x) Calcula.sub (y, x);
                        flag = true;
                        break;
                    case 3:
                        Calcula.multi (x, y);
                        flag = true;
                        break;
                    case 4:
                        Calcula.div (x, y);
                        flag = true;
                        break;
                    case 5:
                        NovaCal.raiz (x);
                        flag = true;
                        break;
                    default:
                        flag = false;
                        Console.WriteLine ("Opção Invalida!");
                        Console.WriteLine ("Digite opção novamente: ");
                        opcao = int.Parse (Console.ReadLine ());
                        break;
                }
            }
            while (flag == false);
            Console.ReadKey ();
        }
    }
}
