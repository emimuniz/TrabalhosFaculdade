using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MeuCompilador
{
    class MeuCompiladorBLL
    {
        public static void compilarPrograma()
        {
            // Procedimento para Análise Léxica do meu código

            AnalisadorLexicoBLL.filtro();
            AnalisadorLexicoBLL.scanner();
            if (Erro.getErro()) return;

            // Procedimento para Análise Sintática do meu código
            
            AnalisadorSintaticoBLL.analiseSintatica();
            if (Erro.getErro()) return;

            // Procedimento para Análise Semântica do meu código

            AnalisadorSemanticoBLL.analiseSemantica();
            if (Erro.getErro()) return;

            // Procedimento para Tradução do meu código
            if (File.Exists("programa.com")) File.Delete("programa.com");
            TradutorBLL.geraExecutavel();
        }
    }
}
