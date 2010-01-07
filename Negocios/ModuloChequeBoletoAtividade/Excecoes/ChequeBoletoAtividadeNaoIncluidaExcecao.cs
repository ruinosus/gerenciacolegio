using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloChequeBoletoAtividade.Constantes;

namespace Negocios.ModuloChequeBoletoAtividade.Excecoes
{
    /// <summary>
    /// Classe ChequeBoletoAtividadeNaoIncluidaExcecao
    /// </summary>
    public class ChequeBoletoAtividadeNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ChequeBoletoAtividadeNaoIncluidaExcecao()
            : base(ChequeBoletoAtividadeConstantes.CHEQUEBOLETOATIVIDADE_NAOINCLUIDA)
        { }
    }
}