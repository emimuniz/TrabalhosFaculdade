using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile, outfile;
            int tam;
            char x;

            infile = new System.IO.FileStream("teste.txt",
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.Read);
            outfile = new System.IO.FileStream("teste2.txt",
                                               System.IO.FileMode.Create,
                                               System.IO.FileAccess.Write);

            tam = (int)infile.Length;
            for (int i = 0; i < tam; ++i)
            {
                x = (char)infile.ReadByte();
                if (x == '#')
                {
                    ++i;
                    do
                    {
                        x = (char)infile.ReadByte();
                        ++i;
                    }
                    while (x != '#');
                }
                else
                    if (x!=' ')
                        outfile.WriteByte((byte)char.ToUpper(x));
            }
            infile.Close();
            outfile.Close();
        }
    }
}
