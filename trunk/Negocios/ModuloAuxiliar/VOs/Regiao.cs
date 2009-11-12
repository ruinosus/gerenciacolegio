using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Negocios.ModuloAuxuliar.VOs
{
    ///<summary>
    ///Classe que representa as regiões.
    ///</summary>
    public class Regiao
    {
        private int id;
        /// <summary>
        /// Propriedade relacionada ao Id da Região.
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private String nome;
        /// <summary>
        /// Propriedade relacionada ao Nome da Região.
        /// </summary>
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String sigla;
        /// <summary>
        /// Propriedade relacionada a Sigla da Região.
        /// </summary>
        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

    }

}