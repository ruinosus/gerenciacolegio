using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloAuxuliar.VOs
{
    /// <summary>
    /// Classe que representa um Rg.
    /// </summary>
    public class Rg
    {
        private string numero;
        /// <summary>
        /// Propriedade relacionada ao Numero do Rg.
        /// </summary>
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private DateTime dataExpedicao;
        /// <summary>
        /// Propriedade relacionada a Data de Expedicao do Rg.
        /// </summary>
        public DateTime DataExpedicao
        {
            get { return dataExpedicao; }
            set { dataExpedicao = value; }
        }

        private string orgaoExpeditor;
        /// <summary>
        /// Propriedade relacionada ao OrgaoExpeditor do Rg.
        /// </summary>
        public string OrgaoExpeditor
        {
            get { return orgaoExpeditor; }
            set { orgaoExpeditor = value; }
        }
    }

}