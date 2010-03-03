using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe ImagemNaoExcluidaExcecao
    /// </summary>
    public class ImagemNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ImagemNaoExcluidaExcecao()
            : base(SiteConstantes.IMAGEM_NAO_EXCLUIDA)
        { }
    }
}