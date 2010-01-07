using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoAtividade.Constantes;

namespace Negocios.ModuloBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe BoletoAtividadeNaoAlteradaExcecao
    /// </summary>
    public class BoletoAtividadeNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoAtividadeNaoAlteradaExcecao()
            : base(BoletoAtividadeConstantes.BOLETOATIVIDADE_NAOALTERADA)
        { }
    }
}