using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBoletoMensalidade.Constantes;

namespace Negocios.ModuloBoletoMensalidade.Excecoes
{
    /// <summary>
    /// Classe BoletoMensalidadeNaoAlteradaExcecao
    /// </summary>
    public class BoletoMensalidadeNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public BoletoMensalidadeNaoAlteradaExcecao()
            : base(BoletoMensalidadeConstantes.BOLETOMENSALIDADE_NAOALTERADA)
        { }
    }
}