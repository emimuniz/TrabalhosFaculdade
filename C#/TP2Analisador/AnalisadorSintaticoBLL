using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCompilador
{
    class AnalisadorSintaticoBLL
    {
        public static void validaSequencia()
        {
            Erro.setErro(false);
            MeuCompiladorDAL.populaGabarito(int.Parse(Token.getCodigo()));
            MeuCompiladorDAL.leGabarito();
            while (Erro.getErro() == false)
            {
                if (Token.getCodigo() != Gabarito.getInfo())
                {
                    Erro.setErro("Linha " + Token.getLinha() + "- token inesperado: " + Token.getToken());
                    return;
                }
                MeuCompiladorDAL.leGabarito();
                if (Erro.getErro()) { Erro.setErro(false);  return; }
                MeuCompiladorDAL.leUmTokenValido();
            }
            Erro.setErro(false);
        }

        public static void analiseSintatica()
        {
            MeuCompiladorDAL.populaDR();

            MeuCompiladorDAL.leUmTokenValido();
            while (Erro.getErro() == false)
            {
                validaSequencia();
                if (Erro.getErro()) return;
                MeuCompiladorDAL.leUmTokenValido();
            }
            Erro.setErro(false);
        }

    }
}
