using System;
namespace ConsoleApp1 {
    class program {
        static void Main (string[] args) {
            ArvoreG RAIZ = null;
            ArvoreG arv;
            int escolha, count;
            string nomepai, nomefilho;
            count = 0;
            do {
                Console.Clear ();
                Console.WriteLine (" Menu Principal");
                Console.WriteLine ("(1) - Insere um elemento na Árvore");
                Console.WriteLine ("(2) - Lista a Árvore ");
                Console.WriteLine ("(3) - Para SAIR");
                escolha = int.Parse (Console.ReadKey (true).KeyChar.ToString ());
                switch (escolha) {
                    case 1: // Insere um elemento na Arvore
                        Console.Clear ();
                        arv = new ArvoreG ();
                        Console.Write ("Entre com o nome do pai : ");
                        nomepai = Console.ReadLine ();
                        if (RAIZ == null) {
                            arv.Grava (nomepai, ref RAIZ);
                        } else {
                            Console.Write ("Entre com o nome do filho: ");
                            nomefilho = Console.ReadLine ();
                            arv.Grava (nomefilho, ref RAIZ);
                        }
                        count++;
                        if (count > 1)
                            RAIZ.Insere (nomepai, arv);
                        break;

                    case 2: // Lista Arvore
                        RAIZ.MostraArvore (1, ref RAIZ);
                        Console.ReadKey ();
                        break;
                }
            } while (escolha != 3);
        }
        class ArvoreG {
            private string info;
            ArvoreG filho;
            ArvoreG irmao;
            public ArvoreG () // Construtor
            {
                info = "";
                filho = null;
                irmao = null;
            }
            public void Grava (string nome, ref ArvoreG RAIZ) {
                .info = nome;
                if (RAIZ == null)
                    RAIZ = this;
            }
            public void Insere (string nomepai, ArvoreG subarv) {
                ArvoreG temp;
                if (.info == nomepai) {
                    if (.filho == null)
                        .filho = subarv;
                    else {
                        temp = .filho;
                        while (temp != null) {
                            if (temp.irmao == null) {
                                temp.irmao = subarv;
                                temp = null;
                            } else
                                temp = temp.irmao;
                        }

                    }
                } else {
                    if (.irmao != null)
                        .irmao.Insere (nomepai, subarv);
                    if (.filho != null)
                        .filho.Insere (nomepai, subarv);
                }
            }
            public void MostraArvore (int Depth, ref ArvoreG Node) {
                string Branch = string.Empty;
                if (Depth == 1)
                    Depth = 0;
                else {
                    for (int i = 0; i < Depth - 5; i++) Branch += " ";
                    Branch = (Depth == 0) ? "|----" : Branch + "|----";
                }
                Console.WriteLine (Branch + Node.info.ToString ());
                if (Node.filho != null)
                    Node.filho.MostraArvore (Depth + 5, ref Node.filho);
                if (Node.irmao != null)
                    Node.irmao.MostraArvore (Depth, ref Node.irmao);
            }
            ~ArvoreG () {
                Console.Write ("Arvore Genérica excluída da Memória");
            }
        }
    }
}
