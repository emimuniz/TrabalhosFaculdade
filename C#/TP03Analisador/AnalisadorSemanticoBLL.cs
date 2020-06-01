using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeuCompilador
{
    class AnalisadorSemanticoBLL
    {
        public static void validaSequencia()
        {
            Erro.setErro(false);
            int tokenValue = int.Parse(Token.getCodigo());
            int tokenzinho;

            switch (tokenValue)
            {
                case 1:
                    {

                        MeuCompiladorDAL.leUmTokenValido();
                        tokenzinho = int.Parse(Token.getToken());

                        if (tokenzinho > 0 && tokenzinho < 81)
                        {
                            MeuCompiladorDAL.leUmTokenValido();
                             tokenzinho = int.Parse(Token.getToken());
                             if (tokenzinho < 1 && tokenzinho > 25)
                                Erro.setErro(true);
                        }
                        else Erro.setErro(true);                       
                        
                    }
                    break;
                case 2:
                    {

                        MeuCompiladorDAL.leUmTokenValido();
                        tokenzinho = int.Parse(Token.getToken());

                        if (tokenzinho < 0 && tokenzinho > 9)
                            Erro.setErro(true);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void analiseSemantica()
        {
            MeuCompiladorDAL.deletaDelimitadores();

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
