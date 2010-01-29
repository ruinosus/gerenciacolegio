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
using System.ComponentModel;
using System.Reflection;

namespace Negocios.ModuloBasico.Enums
{
    public enum TipoPesquisa
    {
        E = 0,
        Ou = 1
    }

    public enum Status
    {
        Inativo = 0,
        Ativo = 1
    }

    /// <summary>
    /// Enum que representa os status do Banco.
    /// </summary>
    public enum StatusBanco
    {
        Inativo = 1,
        Inclusao,
        Alteracao,
        Navegacao
    }

    public enum OperacoesDaTela
    {
        Incluir = 1,
        Alterar = 2,
        Excluir = 3,
        AbrirTela = 4,
        VoltarTela = 5,
        Navegar = 6,
        Bloquear = 7
    }

    

}
