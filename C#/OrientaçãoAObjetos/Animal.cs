using System;
namespace ConsoleApp137 {
    class Program {
        class Animal {
            public void Acordar () {
                Console.WriteLine ("O animal acordou!");
            }
            public void Comer () {
                Console.WriteLine ("O animal comeu!");
            }
            public void Dormir () {
                Console.WriteLine ("O animal dormiu!");
            }
        }
        class Mamifero : Animal {
            private string nomeDoMamifero = "";
            public string Nome {
                set {.nomeDoMamifero = value; }
            }
            public void Mamar () {
                Console.WriteLine ("O {0} Mamou!", nomeDoMamifero);
            }
        }
        class Morcego : Mamifero {
            private string nomeDoMorcego = "";
            public string Nome {
                set {.nomeDoMorcego = value; }
            }
            public void Voar () {
                Console.WriteLine ("O {0} voo", nomeDoMorcego);
            }
        }
        class Baleia : Mamifero {

            private string nomeDaBaleia = "";
            public string Nome {
                set {.nomeDaBaleia = value; }
            }
            public void Nadar () {
                Console.WriteLine ("A {0} nadou!", nomeDaBaleia);
            }
        }
        static void Main (string[] args) {
            Animal DadosAnimal = new Animal ();
            Console.WriteLine ("Digite o nome do Mamifero: ");
            string nomeMamifero = Console.ReadLine ();
            Mamifero dadosMamifero = new Mamifero () { Nome = nomeMamifero };
            dadosMamifero.Acordar ();
            dadosMamifero.Comer ();
            dadosMamifero.Dormir ();
            dadosMamifero.Mamar ();
            Console.WriteLine ("Digite o nome do Morcego: ");
            string nomeMorcego = Console.ReadLine ();
            Morcego DadosMorcego = new Morcego () { Nome = nomeMorcego };
            Console.WriteLine ("Digite o nome da Baleia: ");
            string nomeBaleia = Console.ReadLine ();
            Baleia DadosBaleia = new Baleia () { Nome = nomeBaleia };
            Console.ReadKey ();
        }
    }
}
