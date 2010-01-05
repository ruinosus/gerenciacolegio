using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoMensalidade.Constantes;

namespace Negocios.ModuloChequeBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoMensalidadeNaoExcluidaExcecao
    /// </summary>
    public class ChequeBoletoMensalidadeNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoMensalidadeNaoExcluidaExcecao()
            : base(ChequeBoletoMensalidadeConstantes.CHEQUEBOLETOMENSALIDADE_NAOEXCLUIDA)
        { }
    }
}