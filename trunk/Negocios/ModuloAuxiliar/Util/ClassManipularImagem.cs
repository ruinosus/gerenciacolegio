using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Negocios.ModuloAuxiliar.Util
{

    /// <summary>
    /// Classe auxiliar para a manipulação de imagens no sistema.
    /// </summary>
    public class ClassManipularImagem
    {
        private int id;
        private int numero;
        private string nome;
        private string miniatura;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Miniatura
        {
            get { return miniatura; }
            set { miniatura = value; }
        }

    }
}
