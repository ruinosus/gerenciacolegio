using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoMensalidade.Constantes;

namespace Negocios.ModuloChequeBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoMensalidadeNaoAlteradaExcecao
    /// </summary>
    public class ChequeBoletoMensalidadeNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoMensalidadeNaoAlteradaExcecao()
            : base(ChequeBoletoMensalidadeConstantes.CHEQUEBOLETOMENSALIDADE_NAOALTERADA)
        { }
    }
}