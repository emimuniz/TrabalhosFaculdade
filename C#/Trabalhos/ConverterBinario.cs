using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp80 {
    class Program {
        static void Main (string[] args) {
            //ex01();
            //ex02();
            ex03 ();
            Console.ReadKey (true);
        }
        static void ex01 () {
            Console.Write ("Digite um valor: ");
            int numero = int.Parse (Console.ReadLine ());
            Console.Write ("\nA soma dos primeiros {0} valores inteiros é {1}",
                numero, SomaInteiros (numero));
        }
        static int SomaInteiros (int valor) {
            if (valor == 1) return 1;
            else return valor + SomaInteiros (--valor);
        }
        static void ex02 () {
            int[] inteiros = new int[10];
            for (int i = 0; i < 10; i++) {
                Console.Write ("Digite o {0}º valor:", i + 1);
                inteiros[i] =
                    int.Parse (Console.ReadLine ());
            }
            Console.WriteLine ("\nValores digitados: ");
            MostraVetor (inteiros, inteiros.Length);
        }
        static int MostraVetor (int[] vetor, int i) {
            if (i == 0) {
                return i;
            } else {
                Console.WriteLine (vetor[MostraVetor (vetor, --i)]);
                return ++i;
            }
        }
        static void ex03 () {
            Console.Write ("Digite um valor na base decimal: ");
            int dec = int.Parse (Console.ReadLine ());
            Console.Write ("\nValor na base binária: ");

            Console.Write (Dec2Bin (dec));
        }
        static int Dec2Bin (int valor) {
            if (valor / 2 != 0) Console.Write (Dec2Bin (valor / 2));
            return valor % 2;
        }
    }
}
