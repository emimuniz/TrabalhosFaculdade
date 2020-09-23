using System;
using System.Collections.Generic;
using System.Linq;
namespace ArvoreAVL {
    class Arvore {
        private int info, fb;
        Arvore sae, sad;
        public Arvore () // Construtor
        {
            info = 0;
            sae = sad = null;
        }
        public void Insere (int n, ref Arvore RAIZ) {
            Arvore temp, subarv, noDesb = null;
            this.info = n;
            this.fb = 0;
            if (RAIZ == null)
                RAIZ = this;
            else {
                temp = RAIZ;
                while (temp != null) {
                    subarv = temp;
                    if (n <= temp.info) {
                        temp = temp.sae;
                        if (temp == null) subarv.sae = this;
                        subarv.fb--;
                    } else {
                        temp = temp.sad;
                        if (temp == null) subarv.sad = this;
                        subarv.fb++;
                    }
                    if (subarv.fb > 1 || subarv.fb < -1)
                        noDesb = subarv;
                }
                if (noDesb != null) {
                    if (noDesb.fb > 0) BalanceamentoEsq (ref RAIZ, noDesb);
                    else BalanceamentoDir (ref RAIZ, noDesb);
                }
            }
        }
        public void BalanceamentoEsq (ref Arvore RAIZ, Arvore noDesb) {
            if (noDesb == RAIZ) {
                RAIZ = noDesb.sad;
                noDesb.fb = 0;
                RAIZ.fb--;

            } else {
                Arvore temp = RAIZ;
                while (temp.sad != noDesb) {
                    temp = temp.sad;
                }
                temp.sad = noDesb.sad;
                temp.fb--;
                temp.sad.fb--;
                noDesb.fb = 0;
            }
            noDesb.sad.sae = noDesb;
            noDesb.sad = null;
        }
        public void BalanceamentoDir (ref Arvore RAIZ, Arvore noDesb) {
            if (noDesb == RAIZ) {
                RAIZ = noDesb.sae;
                noDesb.fb = 0;
                RAIZ.fb++;
            } else {
                Arvore temp = RAIZ;
                while (temp.sae != noDesb) {
                    temp = temp.sae;
                }
                temp.sae = noDesb.sae;
                temp.fb--;
                temp.sae.fb++;
                noDesb.fb = 0;
            }
            noDesb.sae.sad = noDesb;
            noDesb.sae = null;
        }
        ~Arvore () {
            Console.Write ("Arvore Binaria excluída da Memória");
            Console.ReadKey ();
        }
    }
    class Program {
        static void Main (string[] args) {
            Arvore RAIZ = null;
            Arvore arv;
            int n, escolha;
            do {

                Console.Clear ();
                Console.WriteLine (" Menu Principal");
                Console.WriteLine ("(1) - Insere um elemento na Árvore");
                Console.WriteLine ("(0) - Para SAIR");
                escolha = int.Parse (Console.ReadKey (true).KeyChar.ToString ());
                Console.Clear ();
                switch (escolha) {
                    case 1: // Insere um elemento na Arvore
                        arv = new Arvore ();
                        Console.Write ("Entre com um numero : ");
                        n = int.Parse (Console.ReadLine ());
                        arv.Insere (n, ref RAIZ);
                        break;
                }
            } while (escolha != 0);
        }
    }
}
