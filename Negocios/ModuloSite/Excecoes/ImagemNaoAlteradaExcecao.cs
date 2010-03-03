using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe ImagemNaoAlteradaExcecao
    /// </summary>
    public class ImagemNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ImagemNaoAlteradaExcecao()
            : base(SiteConstantes.IMAGEM_NAO_ALTERADA)
        { }
    }
}