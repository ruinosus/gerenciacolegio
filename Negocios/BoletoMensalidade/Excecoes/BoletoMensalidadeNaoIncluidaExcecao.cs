using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoMensalidade.Constantes;

namespace Negocios.ModuloBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe BoletoMensalidadeNaoIncluidaExcecao
    /// </summary>
    public class BoletoMensalidadeNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoMensalidadeNaoIncluidaExcecao()
            : base(BoletoMensalidadeConstantes.BOLETOMENSALIDADE_NAOINCLUIDA)
        { }
    }
}