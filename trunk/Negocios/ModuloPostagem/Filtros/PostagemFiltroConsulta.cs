using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.BaseFiltro;

namespace Negocios.ModuloPostagem.Filtros
{
    /// <summary>
    /// Summary description for PostagemFiltroConsulta
    /// </summary>
    public class PostagemFiltroConsulta:FiltroConsulta
    {

        public bool ID
        {
            set
            {
                ExecutarOperacao(value, "Id");
            }
        }

        public bool Usuario
        {
            set
            {
                ExecutarOperacao(value, "UsuarioId");
            }
        }

        public bool Preview
        {
            set
            {
                ExecutarOperacao(value, "Preview");
            }
        }

        public bool Titulo
        {
            set
            {
                ExecutarOperacao(value, "Titulo");
            }
        }

        public bool SubTitulo
        {
            set
            {
                ExecutarOperacao(value, "SubTitulo");
            }
        }

        public bool Corpo
        {
            set
            {
                ExecutarOperacao(value, "Corpo");
            }
        }

        public bool Imagem
        {
            set
            {
                ExecutarOperacao(value, "Imagem");
            }
        }

        public bool StatusPostagem
        {
            set
            {
                ExecutarOperacao(value, "StatusPostagem");
            }
        }

        public bool LocalPostagem
        {
            set
            {
                ExecutarOperacao(value, "LocalPostagem");
            }
        }

        public bool TipoPostagem
        {
            set
            {
                ExecutarOperacao(value, "TipoPostagem");
            }
        }

        public bool DataCriacao
        {
            set
            {
                ExecutarOperacao(value, "DataCriacao");
            }
        }

        public bool DataInicioVigencia
        {
            set
            {
                ExecutarOperacao(value, "DataInicioVigencia");
            }
        }

        public bool DataFinalVigencia
        {
            set
            {
                ExecutarOperacao(value, "DataFinalVigencia");
            }
        }
        public void HabilitaTudo()
        {
            this.ID = true;
            this.Imagem = true;
            this.LocalPostagem = true;
            this.Preview = true;
            this.StatusPostagem = true;
            this.TipoPostagem = true;
            this.SubTitulo = true;
            this.Titulo = true;
            this.Usuario = true;
            this.Corpo = true;
            this.DataCriacao = true;
            this.DataFinalVigencia = true;
            this.DataInicioVigencia = true;

        }
    }
}