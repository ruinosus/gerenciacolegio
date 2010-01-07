using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoMensalidade.Constantes;

namespace Negocios.ModuloChequeBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoMensalidadeNaoIncluidaExcecao
    /// </summary>
    public class ChequeBoletoMensalidadeNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoMensalidadeNaoIncluidaExcecao()
            : base(ChequeBoletoMensalidadeConstantes.CHEQUEBOLETOMENSALIDADE_NAOINCLUIDA)
        { }
    }
}