using System;
namespace ConsoleApp3 {
    class Program {
        class Lampada {
            string statusLampada = "Desligada";
            public bool flag = true;
            public float voltagem { get; set; }
            public float potencia { get; set; }
            public void Ligado () {
                if (statusLampada != "Ligada") {
                    Console.WriteLine ("Lampada esta Ligada!");
                    statusLampada = "Ligada";
                } else Console.WriteLine ("Lampada já esta Ligada");
            }
            public void Desligado () {
                if (statusLampada != "Desligada") {
                    Console.WriteLine ("Lampada esta Desligada!");
                    statusLampada = "Desligada";
                } else Console.WriteLine ("Lampada já esta Desligada!");
            }
            public void Sair () {
                Console.WriteLine ("Deseja realmente sair: ");
                char escolha = char.Parse (Console.ReadLine ().ToUpper ());
                if (escolha == 'S') flag = false;
                else if (escolha == 'N') flag = true;
            }
        }
        static void Main (string[] args) {
            Lampada StatusLampada = new Lampada ();
            Console.WriteLine ("===========================");
            Console.WriteLine ("Digite o valor da voltagem: ");
            StatusLampada.voltagem = float.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o valor da potencia: ");
            StatusLampada.potencia = float.Parse (Console.ReadLine ());
            Console.WriteLine ("Deseja :");
            Console.WriteLine ("1  Ligar a Lampada ");
            Console.WriteLine ("2  Desligar a Lampada ");
            Console.WriteLine ("3  Sair");
            Console.WriteLine ("============================");
            do {
                int opcao = int.Parse (Console.ReadLine ());
                switch (opcao) {
                    case 1:
                        Console.WriteLine ("Potencia: {0}",
                            StatusLampada.potencia);
                        Console.WriteLine ("Tensão: {0}",
                            StatusLampada.potencia);
                        StatusLampada.Ligado ();
                        break;
                    case 2:
                        Console.WriteLine ("Potencia: {0}",
                            StatusLampada.potencia);
                        Console.WriteLine ("Tensão: {0}",
                            StatusLampada.potencia);
                        StatusLampada.Desligado ();
                        break;
                    case 3:
                        Console.WriteLine ("Potencia: {0}",
                            StatusLampada.potencia);
                        Console.WriteLine ("Tensão: {0}",
                            StatusLampada.potencia);
                        StatusLampada.Sair ();
                        break;
                    default:
                        Console.WriteLine ("Opção Invalida!");
                        break;
                }
            } while (StatusLampada.flag != false);
            Console.ReadKey ();
        }
    }
}
