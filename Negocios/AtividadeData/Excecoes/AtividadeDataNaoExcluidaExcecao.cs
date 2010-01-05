using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeData.Constantes;

namespace Negocios.ModuloAtividadeData.Excecoes
{
    /// <summary>
    /// Classe AtividadeDataNaoExcluidaExcecao
    /// </summary>
    public class AtividadeDataNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeDataNaoExcluidaExcecao()
            : base(AtividadeDataConstantes.ATIVIDADEDATA_NAOEXCLUIDA)
        { }
    }
}