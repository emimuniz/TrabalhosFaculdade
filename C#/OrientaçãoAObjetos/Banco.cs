using System;
namespace ConsoleApp139 {
    class Program {
        class ContaCorrente {
            private float salario_funcionario = 0;
            private float saldoPoupanca = 0;
            private float saldoInves = 0;
            public float credito (float dinheiro) {
                return salario_funcionario­ = dinheiro;
            }
            public float debito (float dinheiro) {
                return salario_funcionario += dinheiro;
            }
            public void saldo () {
                Console.WriteLine ("Seu saldo é: {0}", salario_funcionario);
            }
            class ContaPoupanca : ContaCorrente {
                public void Poupança (float dinheiro) {
                    saldoPoupanca += dinheiro;
                    Console.WriteLine ("Saldo: {0}", saldoPoupanca);
                }
            }
            class InvestimentoAnimal : ContaCorrente {
                public void InvestAnimal (float dinheiro) {
                    saldoInves += dinheiro;
                    Console.WriteLine ("Saldo: {0}", saldoInves);
                }
            }
            static void Main (string[] args) {
                bool flag = true;
                float valor = 0;
                char escolha = 'S';
                ContaCorrente ContaFuncionario = new ContaCorrente ();
                InvestimentoAnimal Invest = new InvestimentoAnimal ();
                ContaPoupanca Poupa = new ContaPoupanca ();
                Console.WriteLine ("=======================================");

                Console.WriteLine ("Digite: ");
                Console.WriteLine ("1 ­ Credito");
                Console.WriteLine ("2 ­ Debito");
                Console.WriteLine ("3 ­ Saldo");
                Console.WriteLine ("4 ­ Poupança ");
                Console.WriteLine ("5 ­ Investimento Animal");
                Console.WriteLine ("========================================");
                int opcao = int.Parse (Console.ReadLine ());
                do {
                    do {
                        switch (opcao) {
                            case 1:
                                flag = true;
                                Console.WriteLine ("Digite o valor a ser 
retirado:");
                                valor = float.Parse (Console.ReadLine ());
                                ContaFuncionario.credito (valor);
                                break;
                            case 2:
                                flag = true;
                                Console.WriteLine ("Digite o valor a ser 
colocado: ");
                                valor = float.Parse (Console.ReadLine ());
                                ContaFuncionario.debito (valor);
                                break;
                            case 3:
                                flag = true;
                                ContaFuncionario.saldo ();
                                break;
                            case 4:
                                flag = true;
                                Console.WriteLine ("Digite o valor a ser 
colocado: ");
                                valor = float.Parse (Console.ReadLine ());
                                Poupa.Poupança (valor);
                                break;
                            case 5:
                                flag = true;
                                Console.WriteLine ("Digite o valor a ser 
colocado: ");
                                valor = float.Parse (Console.ReadLine ());
                                break;
                            default:
                                flag = false;
                                Console.WriteLine ("Opcão Invalida!");
                                Console.WriteLine ("Digite novamente a opção: 
");
                                opcao = int.Parse (Console.ReadLine ());
                                break;
                        }
                    } while (flag == false);
                    Console.WriteLine ("Deseja fazer mais alguma coisa: S/N");

                    escolha = char.Parse (Console.ReadLine ().ToUpper ());
                    if (escolha == 'S') {
                        Console.WriteLine ("Digite a nova opção: ");
                        opcao = int.Parse (Console.ReadLine ());
                    }
                } while (escolha == 'S');
                Console.ReadKey ();
            }
        }
    }
}
