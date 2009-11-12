using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloAuxuliar.VOs
{
    /// <summary>
    /// Summary description for PessoaVO
    /// </summary>
    public class PessoaVO 
    {
        #region Atributos
        private int id;
        private string nome;
        private string cpf;
        private DateTime dataNascimento;
        private char sexo;
        private string email;
        private string site;
        private Endereco endereco;
        private Rg rg;
        private string telefone;
        private string celular;
        #endregion

        #region Propriedades

        public Rg Rg
        {
            get
            {
                if (rg == null)
                    rg = new Rg();
                return rg;
            }
            set { rg = value; }
        }

        public Endereco Endereco
        {
            get
            {
                if (endereco == null)
                    endereco = new Endereco();
                return endereco;
            }
            set { endereco = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Site
        {
            get { return site; }
            set { site = value; }
        }


        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }



        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        #endregion
    }
}