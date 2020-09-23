using System;
namespace ConsoleApp3 {
    class Program {
        static void Main (string[] args) {
            Circle circulo = new Circle ();
            Square quadrado = new Square ();
            Triangle triangulo = new Triangle ();
            Retangle retangulo = new Retangle ();
            int op;
            string ops;
            do {
                do {
                    Console.Clear ();
                    Console.WriteLine (" Menu das Figuras Geométricas ");
                    Console.WriteLine ("[1] Mudar diâmetro do Circulo");
                    Console.WriteLine ("[2] Mudar tamanho do Triângulo");
                    Console.WriteLine ("[3] Mudar tamanho do Quadrado");
                    Console.WriteLine ("[4] Mudar tamanho do Retângulo");
                    Console.WriteLine ("[5] Mostrar a área das figuras");
                    Console.WriteLine ("[0] Sair");
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
                        circulo.calculaArea ();
                        break;
                    case 2:
                        Console.Clear ();
                        triangulo.calculaArea ();
                        break;
                    case 3:
                        Console.Clear ();
                        quadrado.calculaArea ();
                        break;
                    case 4:
                        Console.Clear ();
                        retangulo.calculaArea ();

                        break;
                    case 5:
                        Console.Clear ();
                        Console.WriteLine ("Área do Circulo: " +
                            circulo.area);
                        Console.WriteLine ("Área do Triângulo: " +
                            triangulo.area);
                        Console.WriteLine ("Área do Quadrado: " +
                            quadrado.area);
                        Console.WriteLine ("Área do Retângulo: " +
                            retangulo.area);
                        Console.WriteLine ("Pressione qualquer tecla para voltar...");
                        Console.ReadKey ();
                        break;
                    default:
                        Console.Clear ();
                        Console.WriteLine ("Opção Inválida!");
                        Console.ReadKey ();
                        break;
                }
            } while (op != 0);
        }
        class Figura {
            public double area;
        }
        class Circle : Figura {
            public double diametro;
            public void calculaArea () {
                do {
                    Console.Write ("Digite o valor do novo diâmetro: ");
                    diametro = double.Parse (Console.ReadLine ());
                } while (diametro <= 0);
                area = Math.PI * diametro;
            }
        }
        class Triangle : Figura {
            public double h, b;
            public void calculaArea () {
                do {
                    Console.Write ("Digite o valor da nova altura: ");
                    h = double.Parse (Console.ReadLine ());
                    Console.Write ("Digite o valor da nova base: ");
                    b = double.Parse (Console.ReadLine ());
                } while (b <= 0 || h <= 0);
                area = b * h / 2;
            }
        }
        class Square : Figura

        {
            public double aresta;
            public void calculaArea () {
                do {
                    Console.Write ("Digite o valor das arestas do quadrado:");
                    aresta = double.Parse (Console.ReadLine ());
                } while (aresta <= 0);
                area = Math.Pow (aresta, 2);
            }
        }
        class Retangle : Figura {
            public double h, b;
            public void calculaArea () {
                do {
                    Console.Write ("Digite o valor novo da altura: ");
                    h = double.Parse (Console.ReadLine ());
                    Console.Write ("Digite o valor novo da base: ");
                    b = double.Parse (Console.ReadLine ());
                } while (h <= 0 || b <= 0);
                area = h * b;
            }
        }
    }
}
