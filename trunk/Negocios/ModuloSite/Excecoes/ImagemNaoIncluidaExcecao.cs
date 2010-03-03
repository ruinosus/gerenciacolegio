using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe ImagemNaoIncluidaExcecao
    /// </summary>
    public class ImagemNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ImagemNaoIncluidaExcecao()
            : base(SiteConstantes.IMAGEM_NAO_INCLUIDA)
        { }
    }
}