using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAtividadeData.Constantes;

namespace Negocios.ModuloAtividadeData.Excecoes
{
    /// <summary>
    /// Classe AtividadeDataNaoAlteradaExcecao
    /// </summary>
    public class AtividadeDataNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AtividadeDataNaoAlteradaExcecao()
            : base(AtividadeDataConstantes.ATIVIDADEDATA_NAOALTERADA)
        { }
    }
}