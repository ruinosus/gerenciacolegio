using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe PostagemNaoAlteradaExcecao
    /// </summary>
    public class PostagemNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PostagemNaoAlteradaExcecao()
            : base(SiteConstantes.POSTAGEM_NAO_ALTERADA)
        { }
    }
}