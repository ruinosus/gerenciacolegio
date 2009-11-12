using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloAuxuliar.VOs
{

    ///<summary>
    ///Classe que representa as Cidades.
    ///</summary>
    public class Cidade
    {
        private int id;
        /// <summary>
        /// Propriedade relacionada ao Id da Cidade.
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private String nome;
        /// <summary>
        /// Propriedade relacionada ao Nome da Cidade.
        /// </summary>
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private Estado estado;
        /// <summary>
        /// Propriedade relacionada ao Estado da Cidade.
        /// </summary>
        public Estado Estado
        {
            get
            {
                if (estado == null)
                    estado = new Estado();

                return estado;
            }
            set { estado = value; }
        }
        /// <summary>
        /// Construtor padrão da Cidade que inicializa o Estado.
        /// </summary>
        public Cidade()
        {
            
        }


    }

}