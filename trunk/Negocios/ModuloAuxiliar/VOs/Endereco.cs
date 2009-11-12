using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloAuxuliar.VOs
{
    /// <summary>
    /// Classe que representa um Endereco.
    /// </summary>
    public class Endereco
    {

        private String logradouro;
        /// <summary>
        /// Propriedade relacionada ao Logradouro do Endereco.
        /// </summary>
        public String Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

        private String bairro;
        /// <summary>
        /// Propriedade relacionada ao Bairro do Endereco.
        /// </summary>
        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        private String complemento;
        /// <summary>
        /// Propriedade relacionada ao Complemento do Endereco.
        /// </summary>
        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        private String cep;
        /// <summary>
        /// Propriedade relacionada ao Cep do Endereco.
        /// </summary>
        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private String numero;
        /// <summary>
        /// Propriedade relacionada ao Numero do Endereco.
        /// </summary>
        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private Cidade cidade;
        /// <summary>
        /// Propriedade relacionada a Cidade do Endereco.
        /// </summary>
        public Cidade Cidade
        {
            get
            {
                if (cidade == null)
                    cidade = new Cidade();
                return cidade;
            }
            set { cidade = value; }
        }
        /// <summary>
        /// Construtor padrão que inicializa a Cidade.
        /// </summary>
        public Endereco()
        {

        }
    }

}