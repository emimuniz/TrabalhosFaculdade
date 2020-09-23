using System;
namespace ProjetoFila
{
 class Fila
 {
 public Fila() // Construtor
 {
     info = 0;
     next = null;
 }
 public void Insere(int n, ref Fila START, ref Fila END)
 {
       this.info = n;
       if (START == null)
       START = END = this;
       else
       {
           END.next = this;
           END = this;
       }
 }
 public void Remove(ref Fila START)
 {
       START = this.next;
       Console.Write("Número excluído");
       Console.ReadKey();
 }
 public int Consulta(int valor)
 {
       Fila temp = this;
       int posicao = 0;
       int achou = 0;
       while (temp != null && achou == 0)
       {
           if (temp.info == valor)
                  achou = 1;
           posicao++;
           temp = temp.next;
       }
           if (achou == 0) posicao = 0;
           return (posicao);
       }
       public void Imprimir()
       {
         Fila temp = this;
         while(temp != null)
         {
             Console.WriteLine(temp.info);
             temp = temp.next;
         }
        Console.ReadKey();
     }
     
 public void Somatoria()
 {
     Fila temp = this;
     int soma = 0;
     while (temp != null)
     {
        if (temp.info % 2 == 0)
          soma += temp.info;
        temp = temp.next;
     }
     if(soma == 0)
     {
        Console.WriteLine("Não há números pares!");
     }
     else
     {
         Console.WriteLine(soma);
         Console.ReadKey();
     }
 }
 private int info;
 Fila next;
 }
 
 class Program
 {
    static void Main(string[] args)
 {
   Fila START, END, ff;
   START = END = null;
   int n, escolha, resultado;
 do
 {
     Console.Clear();
     Console.WriteLine(" Menu Principal");
     Console.WriteLine("(1) - Insere um elemento na Fila");
     Console.WriteLine("(2) - Remove um elemento da Fila");
     Console.WriteLine("(3) - Consulta um elemento da Fila");
     Console.WriteLine("(4) - Imprime os elementos da Fila");
     Console.WriteLine("(5) - Para SAIR");
     Console.WriteLine("(6) - Soma dos elementos pares da Fila");
     escolha = int.Parse(Console.ReadLine());
 switch (escolha)
 {
    case 1: // Insere um elemento na Fila
        Console.Clear();
        ff = new Fila();
        Console.Write("Entre com um numero : ");
        n = int.Parse(Console.ReadLine());
        ff.Insere(n, ref START, ref END);
        break;
   case 2: //Remove
        START.Remove(ref START);
        
        break;
   case 3://CONSULTAR
        Console.Clear();
if(START != null)
{
    Console.Write("Entre com um numero : ");
    n = int.Parse(Console.ReadLine());
    resultado = START.Consulta(n);
  if (resultado == 0)
    Console.Write("Numero nao encontrado!");
 else
    Console.Write("Numero existe na posicao {0}", resultado);
}
 Console.ReadKey();
break;
 case 4: //IMPRIMIR
 Console.Clear();
if (START == null)
 Console.Write("Pilha Vazia");
 else
 START.Imprimir();
 break;
 case 6: //somatoria
 Console.Clear();
if (START != null)
 START.Somatoria();
 else
 Console.WriteLine("Pilha vazia");
Console.ReadKey();
 break;
 }
 } while (escolha != 5);
 }
 }
}
