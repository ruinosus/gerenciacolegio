using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoAtividade.Constantes;

namespace Negocios.ModuloChequeBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoAtividadeNaoExcluidaExcecao
    /// </summary>
    public class ChequeBoletoAtividadeNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoAtividadeNaoExcluidaExcecao()
            : base(ChequeBoletoAtividadeConstantes.CHEQUEBOLETOATIVIDADE_NAOEXCLUIDA)
        { }
    }
}