using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoAtividade.Constantes;

namespace Negocios.ModuloBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe BoletoAtividadeNaoIncluidaExcecao
    /// </summary>
    public class BoletoAtividadeNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoAtividadeNaoIncluidaExcecao()
            : base(BoletoAtividadeConstantes.BOLETOATIVIDADE_NAOINCLUIDA)
        { }
    }
}