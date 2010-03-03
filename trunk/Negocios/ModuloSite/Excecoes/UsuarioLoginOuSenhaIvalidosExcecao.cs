using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe UsuarioLoginOuSenhaInvalidosExcecao
    /// </summary>
    public class UsuarioLoginOuSenhaInvalidosExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioLoginOuSenhaInvalidosExcecao()
            : base(SiteConstantes.USUARIO_LOGIN_OU_SENHA_INVALIDOS)
        { }
    }
}