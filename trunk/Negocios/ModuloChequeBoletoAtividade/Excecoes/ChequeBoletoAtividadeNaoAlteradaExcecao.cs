using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoAtividade.Constantes;

namespace Negocios.ModuloChequeBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoAtividadeNaoAlteradaExcecao
    /// </summary>
    public class ChequeBoletoAtividadeNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoAtividadeNaoAlteradaExcecao()
            : base(ChequeBoletoAtividadeConstantes.CHEQUEBOLETOATIVIDADE_NAOALTERADA)
        { }
    }
}