using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1 {
    class Program {
        static void Main (string[] args) {
            ExercicioDoCPF
            long[] primeiro = new long[10];
            long[] verifica1 = new long[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            long[] verifica2 = new long[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            long resultado = 0, resultado2 = 0;
            Console.WriteLine ("Digite 9 numeros do seu cpf: ");
            long cpf = long.Parse (Console.ReadLine ());
            for (int i = 8; i >= 0; i--) {
                primeiro[i] = cpf % 10;
                cpf = cpf / 10;
            }
            for (int i = 0; i < verifica1.Length; i++) {
                resultado += primeiro[i] * verifica1[i];
            }
            resultado = resultado * 10 % 11;
            primeiro[9] = resultado;
            for (int i = 0; i < verifica2.Length; i++) {
                resultado2 += primeiro[i] * verifica2[i];
            }
            resultado2 = resultado2 * 10 % 11;
            Console.WriteLine ("O primeiro numero é: {0}", resultado);
            Console.WriteLine ("O segundo numero é: {0}", resultado2);
            Console.ReadKey ();
        }
    }
}
