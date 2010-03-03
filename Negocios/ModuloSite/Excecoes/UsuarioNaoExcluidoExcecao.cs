using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe UsuarioNaoExcluidoExcecao
    /// </summary>
    public class UsuarioNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioNaoExcluidoExcecao()
            : base(SiteConstantes.USUARIO_NAO_EXCLUIDO)
        { }
    }
}