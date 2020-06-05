public static void analiseSemantica()
        {
            MeuCompiladorDAL.deletaDelimitadores();
            MeuCompiladorDAL.populaDR();

            MeuCompiladorDAL.leUmTokenValido();
            while (Erro.getErro() == false)
            {
                Erro.setErro(false);
                int aux;

                int codigo = int.Parse(Token.getCodigo());

                MeuCompiladorDAL.leQtdArgumentos(codigo);
                int qtdArgumentos = int.Parse(QtdArgumentos.getQtdArgumentos());

                for (int i = 0; i < qtdArgumentos; ++i)
                {
                    MeuCompiladorDAL.leArgLimites(codigo, i);

                    MeuCompiladorDAL.leUmTokenValido();
                    aux = int.Parse(Token.getToken());
                    if (aux < int.Parse(ArgLimites.getMinimo()) || aux > int.Parse(ArgLimites.getMaximo()))
                    {
                        Erro.setErro("Linha " + Token.getLinha() + ": valor fora da faixa(" + Token.getToken() + ")");
                        return;
                    }
                }
                MeuCompiladorDAL.leUmTokenValido();
            }

            Erro.setErro(false);
        }
