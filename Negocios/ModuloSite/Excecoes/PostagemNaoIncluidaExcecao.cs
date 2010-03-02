using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;


namespace PontaoCanavial.Models.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe PostagemNaoIncluidaExcecao
    /// </summary>
    public class PostagemNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PostagemNaoIncluidaExcecao()
            : base(SiteConstantes.POSTAGEM_NAO_INCLUIDA)
        { }
    }
}