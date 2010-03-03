using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe UsuarioNaoAlteradoExcecao
    /// </summary>
    public class UsuarioNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioNaoAlteradoExcecao()
            : base(SiteConstantes.USUARIO_NAO_ALTERADO)
        { }
    }
}