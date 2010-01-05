using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoMensalidade.Constantes;

namespace Negocios.ModuloBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe BoletoMensalidadeNaoExcluidaExcecao
    /// </summary>
    public class BoletoMensalidadeNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoMensalidadeNaoExcluidaExcecao()
            : base(BoletoMensalidadeConstantes.BOLETOMENSALIDADE_NAOEXCLUIDA)
        { }
    }
}