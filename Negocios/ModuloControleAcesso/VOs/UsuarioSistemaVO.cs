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
using Negocios.ModuloAuxuliar.VOs; 
using Negocios.ModuloAuxuliar.Enums;


namespace Negocios.ModuloControleAcesso.VOs
{
    /// <summary>
    /// Summary description for UsuarioSistemaVO
    /// </summary>
    public class UsuarioSistemaVO : PessoaVO
    {
        #region Atributos
        private string nomeOrganizador;
        private string descricao;
        private StatusUsuarioSistema statusUsuarioSistema;
        private string login;
        private string senha;
        private string aviso;
        private bool isAdministrador;
        private Endereco enderecoAtua;
        private byte[] imagem;


        #endregion

        #region Propriedades
        public string NomeOrganizador
        {
            get { return nomeOrganizador; }
            set { nomeOrganizador = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public StatusUsuarioSistema StatusUsuarioSistema
        {
            get { return statusUsuarioSistema; }
            set { statusUsuarioSistema = value; }
        }


        public string Login
        {
            get { return login; }

            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }

            set { senha = value; }
        }

        public bool IsAdministrador
        {
            get { return isAdministrador; }
            set { isAdministrador = value; }
        }

        public string Aviso
        {
            get { return aviso; }
            set { aviso = value; }
        }

        public Endereco EnderecoAtua
        {
            get
            {
                if (enderecoAtua == null)
                    enderecoAtua = new Endereco();
                return enderecoAtua;
            }
            set { enderecoAtua = value; }
        }

        public byte[] Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        #endregion
    }
}