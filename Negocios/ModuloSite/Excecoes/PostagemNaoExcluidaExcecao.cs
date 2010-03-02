using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe PostagemNaoExcluidaExcecao
    /// </summary>
    public class PostagemNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PostagemNaoExcluidaExcecao()
            : base(SiteConstantes.POSTAGEM_NAO_EXCLUIDA)
        { }
    }
}