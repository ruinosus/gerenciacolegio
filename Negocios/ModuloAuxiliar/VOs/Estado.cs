using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloAuxuliar.VOs
{
    ///<summary>
    ///Classe que representa os estados.
    ///</summary>
    public class Estado
    {
        private int id;
        /// <summary>
        /// Propriedade relacionada ao Id do Estado.
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private String nome;
        /// <summary>
        /// Propriedade relacionada ao Nome do Estado.
        /// </summary>
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private String sigla;
        /// <summary>
        /// Propriedade relacionada a Sigla do Estado.
        /// </summary>
        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        private Regiao regiao;

        public Regiao Regiao
        {
            get {
                if (regiao == null)
                    regiao = new Regiao();
                return regiao; }
            set { regiao = value; }
        }

    }

}