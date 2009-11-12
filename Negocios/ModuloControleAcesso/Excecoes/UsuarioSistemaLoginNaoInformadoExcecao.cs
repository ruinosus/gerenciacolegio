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
/// Summary description for UsuarioLoginNaoInformado 
/// </summary>
public class UsuarioSistemaLoginNaoInformadoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante.
        /// </summary>
    public UsuarioSistemaLoginNaoInformadoExcecao()
            : base(ConstantesControleAcesso.USUARIO_LOGINNAOINFORMADO)
        { }
    }
}