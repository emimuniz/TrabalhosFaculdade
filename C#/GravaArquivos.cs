class TradutorBLL
{
    public static void gravaArquivo()
    {
        FileStream infile, outfile;
        int tam;
        char x;

        infile = new System.IO.FileStream("PONTOCOM.LIB",
                                            System.IO.FileMode.Open,
                                            System.IO.FileAccess.Read);
        outfile = new System.IO.FileStream("programa.com",
                                            System.IO.FileMode.Append,
                                            System.IO.FileAccess.Write);

        tam = int.Parse(PontoCom.getTamanho());
        infile.Position = int.Parse(PontoCom.getInicio());
        for (int i = 0; i < tam; ++i)
        {
            x = (char)infile.ReadByte();
            outfile.WriteByte((byte)x);
        }
        infile.Close();
        outfile.Close();

    }
    public static void geraExecutavel()
    {
        MeuCompiladorDAL.populaDR();

        MeuCompiladorDAL.leUmTokenValido();
        while (Erro.getErro() == false)
        {
            PontoCom.setCodigo(Token.getCodigo());
            MeuCompiladorDAL.lepontocom();

            if (!Erro.getErro())
                gravaArquivo();

            MeuCompiladorDAL.leUmTokenValido();
        }
        Erro.setErro(false);

    }
