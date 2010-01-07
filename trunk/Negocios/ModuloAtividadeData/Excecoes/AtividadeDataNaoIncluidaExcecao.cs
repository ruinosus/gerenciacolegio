using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeData.Constantes;

namespace Negocios.ModuloAtividadeData.Excecoes
{
    /// <summary>
    /// Classe AtividadeDataNaoIncluidaExcecao
    /// </summary>
    public class AtividadeDataNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeDataNaoIncluidaExcecao()
            : base(AtividadeDataConstantes.ATIVIDADEDATA_NAOINCLUIDA)
        { }
    }
}