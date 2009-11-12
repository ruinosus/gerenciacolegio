using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.BaseFiltro;

namespace Negocios.ModuloComentario.Filtro
{
    /// <summary>
    /// Summary description for ComentarioFiltroConsulta
    /// </summary>
    public class ComentarioFiltroConsulta:FiltroConsulta
    {

        public bool ID
        {
            set
            {
                ExecutarOperacao(value, "Id");
            }
        }

        public bool Descricao
        {
            set
            {
                ExecutarOperacao(value, "Descricao");
            }
        }

        public bool DataCriacao
        {
            set
            {
                ExecutarOperacao(value, "DataCriacao");
            }
        }

        public bool Usuario
        {
            set
            {
                ExecutarOperacao(value, "UsuarioId");
            }
        }

        public bool Postagem
        {
            set
            {
                ExecutarOperacao(value, "PostagemId");
            }
        }

        public void HabilitaTudo()
        {
            this.ID = true;
            this.Descricao = true;
            this.DataCriacao = true;
            this.Usuario = true;
            this.Postagem = true;
        }
    }
}