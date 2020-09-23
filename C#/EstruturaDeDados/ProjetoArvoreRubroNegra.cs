using System;
using System.Collections.Generic;
using System.Linq;
namespace ArvoreRubroNegra {
    enum corNo { preto, vermelho }
    class Arvore {
        int info;
        Arvore sad;
        Arvore sae;
        corNo cor;
        public Arvore () // Construtor {
        info = 0;
        sae = sad = null;
        cor = corNo.vermelho;
    }
    public void Insere (int n, ref Arvore RAIZ) {
        Arvore temp, subarv;
        this.info = n;
        if (RAIZ == null) {
            RAIZ = this;
            cor = corNo.preto;
        } else {
            temp = RAIZ;
            while (temp != null) {
                subarv = temp;
                if (n <= temp.info) {
                    temp = temp.sae;
                    if (temp == null)
                        subarv.sae = this;
                } else {
                    temp = temp.sad;
                    if (temp == null)
                        subarv.sad = this;
                }
                if (subarv.cor == corNo.vermelho)
                    this.cor = corNo.preto;
            }
        }
        if (RAIZ.VerificaCorNos ()) {
            Console.WriteLine ("Os corNos estão desalanceados");
            Console.ReadLine ();
        }
    }
    public bool VerificaCorNos () {
        bool desbal = false;
        if (sae != null) {
            if (this.cor == corNo.vermelho) {
                if (sae.cor == corNo.vermelho) desbal = true;
                else if (sad == null) desbal = true;
            }
            if (desbal) return true;
            else desbal = sae.VerificaCorNos ();
        }
        if (!desbal && sad != null) {
            if (this.cor == corNo.vermelho) {
                if (sad.cor == corNo.vermelho) desbal = true;
                else if (sae == null) desbal = true;
            }
            if (desbal) return true;
            else desbal = sad.VerificaCorNos ();
        }
        return false;
    }
    public void NavEmNivel () {
        List<Arvore> lista = new List<Arvore> () { this };
        Arvore temp;
        while (lista.Count != 0) {
            temp = lista.First ();
            Console.Write ("{0} ({1}) ", temp.info, temp.cor);
            if (temp.sae != null)
                lista.Add (temp.sae);
            if (temp.sad != null)
                lista.Add (temp.sad);
            lista.RemoveAt (0);
        }
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
        int n, escolha, qtdNo = 0;
        int[] nums = new int[6] { 10, 8, 12, 6, 9, 7 };
        foreach (var num in nums) {
            Arvore temp = new Arvore ();
            temp.Insere (num, ref RAIZ);
        }
        do {
            Console.Clear ();
            Console.WriteLine (" Menu Principal");
            Console.WriteLine ("(1) ­ Insere um elemento na Árvore");
            Console.WriteLine ("(2) ­ Navegação em Nível");
            Console.WriteLine ("(8) ­ Para SAIR");
            escolha = int.Parse (Console.ReadKey (true).KeyChar.ToString ());
            switch (escolha) {
                case 1: // Insere um elemento na Arvore
                    Console.Clear ();
                    arv = new Arvore ();
                    Console.Write ("Entre com um numero : ");
                    n = int.Parse (Console.ReadLine ());
                    arv.Insere (n, ref RAIZ);
                    qtdNo++;
                    break;
                case 2:
                    Console.Clear ();
                    RAIZ.NavEmNivel ();
                    Console.ReadKey ();
                    break;
            }
        } while (escolha != 8);
    }
}
}
