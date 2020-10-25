public static void gravaArquivo()
        {
            FileStream infile, outfile;
            int tam;
            int qtdargs;
            char x;

            infile = new System.IO.FileStream("pontocom.lib",
                                               System.IO.FileMode.Open,
                                               System.IO.FileAccess.Read);
            outfile = new System.IO.FileStream("programa.com",
                                               System.IO.FileMode.Append,
                                               System.IO.FileAccess.Write);

            MeuCompiladorDAL.consultaIndiceLib();
            tam = int.Parse(IndiceLib.getTamanho());
            infile.Position = int.Parse(IndiceLib.getInicio());
            qtdargs = MeuCompiladorDAL.leQtdArgumentos();

            for (int i = 0; i < tam; ++i)
            {
                x = (char)infile.ReadByte();
                outfile.WriteByte((byte)x);
                if (qtdargs != 0)
                {
                    MeuCompiladorDAL.leUmTokenValido();
                    outfile.WriteByte(byte.Parse(Token.getToken()));
                    infile.ReadByte();
                    i++;
                    qtdargs--;
                }
            }
            infile.Close();
            outfile.Close();

        }
