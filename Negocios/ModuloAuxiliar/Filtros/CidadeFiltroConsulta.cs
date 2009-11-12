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
using Negocios.ModuloAuxiliar.BaseFiltro;

namespace Negocios.ModuloAuxuliar.Filtros
{
    /// <summary>
    /// Summary description for CidadeFiltroConsulta
    /// </summary>
    public class CidadeFiltroConsulta : FiltroConsulta
    {
        public bool ID
        {
            set
            {
                ExecutarOperacao(value, "Id");
            }
        }

        public bool Nome
        {
            set
            {
                ExecutarOperacao(value, "Nome");
            }
        }

        public bool Estado
        {
            set
            {
                ExecutarOperacao(value, "EstadoId");
            }
        }

        public void HabilitaTudo()
        {
            this.ID = true;
            this.Nome = true;
            this.Estado = true;
        }

    }
}
