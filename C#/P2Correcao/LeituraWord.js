

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Application word = new Application();
            Document document = word.Documents.Open(@"c:\matar\teste.txt");
            String token;
            int linha = 1;

            int count = document.Words.Count;
            for (int i = 1; i <= count; i++)
            {
                token = document.Words[i].Text;
                try
                {
                    int.Parse(token);
                    Console.WriteLine("Linha " + linha + " -     (Inteiro): " + token);
                }
                catch(Exception)
                {
                    if (token.All(Char.IsLetter))
                    {
                        Console.WriteLine("Linha " + linha + " -      (String): " + token);
                    }
                    else
                    {
                        if (token[0] == 13)
                        {
                            ++linha;
                        }
                        else
                        {
                            for (int j = 0; j < token.Length; ++j)
                            {
                                Console.WriteLine("Linha " + linha + " - (Delimitador): " + token[j]);
                            }
                        }
                    }
                }
            }
            word.Documents.Close();
            word.Quit();
            Console.ReadKey();
        }
    }
}
