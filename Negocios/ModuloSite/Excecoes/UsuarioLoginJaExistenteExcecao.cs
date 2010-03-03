using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloSite.Constantes;

namespace Negocios.ModuloSite.Excecoes
{
    /// <summary>
    /// Classe UsuarioLoginJaExistenteExcecao
    /// </summary>
    public class UsuarioLoginJaExistenteExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public UsuarioLoginJaExistenteExcecao()
            : base(SiteConstantes.USUARIO_LOING_JA_EXISTENTE)
        { }
    }
}