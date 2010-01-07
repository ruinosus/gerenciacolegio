using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoAtividade.Constantes;

namespace Negocios.ModuloBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe BoletoAtividadeNaoExcluidaExcecao
    /// </summary>
    public class BoletoAtividadeNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoAtividadeNaoExcluidaExcecao()
            : base(BoletoAtividadeConstantes.BOLETOATIVIDADE_NAOEXCLUIDA)
        { }
    }
}