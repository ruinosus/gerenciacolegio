using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Negocios.ModuloControleAcesso.Excecoes
{
    /// <summary>
    /// Summary description for UsuarioNaoExcluido
    /// </summary>
    public class UsuarioSistemaNaoExcluidoExcecao: Exception
    { 
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante.
        /// </summary>
        public UsuarioSistemaNaoExcluidoExcecao()
            : base(ConstantesControleAcesso.USUARIO_NAOEXCLUIDO)
        { }
    }
}