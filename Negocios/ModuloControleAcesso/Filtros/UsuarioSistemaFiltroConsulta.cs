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

namespace Negocios.ModuloControleAcesso.Filtros
{
    /// <summary>
    /// Summary description for UsuarioSistemaFiltroConsulta
    /// </summary>
    public class UsuarioSistemaFiltroConsulta : FiltroConsulta
    {
        public bool ID
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Id");
            }
        }
        public bool Nome
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Nome");
            }
        }
        public bool Cpf
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Cpf");
            }
        }

        public bool DataNascimento
        {
            set
            {
                ExecutarOperacao(value, "Usuario.DataNascimento");
            }
        }

        public bool Sexo
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Sexo");
            }
        }

        public bool Email
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Email");
            }
        }

        public bool Site
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Site");
            }
        }

        public bool Rg
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Rg");
                ExecutarOperacao(value, "Usuario.DataExpedicao");
                ExecutarOperacao(value, "Usuario.OrgaoExpeditor");
            }
        }

        public bool NomeOrganizador
        {
            set
            {
                ExecutarOperacao(value, "Usuario.NomeOrganizador");
            }
        }

        public bool Endereco
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Logradouro");
                ExecutarOperacao(value, "Usuario.Complemento");
                ExecutarOperacao(value, "Usuario.CidadeId");
                ExecutarOperacao(value, "Usuario.Cep");
                ExecutarOperacao(value, "Usuario.Numero");
                ExecutarOperacao(value, "Usuario.Bairro");
            }
        }

        public bool EnderecoAtua
        {
            set
            {
                ExecutarOperacao(value, "Usuario.LogradouroAtua");
                ExecutarOperacao(value, "Usuario.ComplementoAtua");
                ExecutarOperacao(value, "Usuario.CidadeIdAtua");
                ExecutarOperacao(value, "Usuario.CepAtua");
                ExecutarOperacao(value, "Usuario.NumeroAtua");
                ExecutarOperacao(value, "Usuario.BairroAtua");
            }
        }

        public bool Descricao
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Descricao");
            }
        }

        public bool Status
        {
            set
            {
                ExecutarOperacao(value, "Usuario.StatusUsuario");
            }
        }

        public bool Login
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Login");
            }
        }

        public bool Senha
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Senha");
            }
        }

        public bool IsAdministrador
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Administrador");
            }
        }

        public bool Aviso
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Aviso");
            }
        }

        public bool Telefone
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Telefone");
            }
        }

        public bool Celular
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Celular");
            }
        }

        

        public bool Imagem
        {
            set
            {
                ExecutarOperacao(value, "Usuario.Imagem");
            }
        }

        public void HabilitaTudo()
        {
            
            this.Cpf = true;
            this.DataNascimento = true;
            this.Email = true;
            this.Endereco = true;
            this.Login = true;
            this.ID = true;
            this.Nome = true;
            this.NomeOrganizador = true;
            this.Descricao = true;
            this.Rg = true;
            this.Sexo = true;
            this.Status = true;
            this.Site = true;
            this.IsAdministrador = true;
            this.Aviso = true;
           this.Telefone = true;
            this.Celular = true;
            this.Senha = true;
            this.EnderecoAtua = true;
            this.Imagem = true;
        }

    }
}