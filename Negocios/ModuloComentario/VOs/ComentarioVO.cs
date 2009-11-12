using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloPostagem.VOs;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloComentario.VOs
{
    /// <summary>
    /// Summary description for ComentarioVO
    /// </summary>
    public class ComentarioVO
    {
        #region Atributos
        private int id;
        private string descricao;
        private DateTime dataCriacao;
        private UsuarioSistemaVO usuario;
        private PostagemVO postagem;
        #endregion

        #region Propriedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public DateTime DataCriacao
        {
            get { return dataCriacao; }
            set { dataCriacao = value; }
        }
        public UsuarioSistemaVO Usuario
        {
            get
            {
                if (usuario == null)
                    usuario = new UsuarioSistemaVO();
                return usuario; }
            set { usuario = value; }
        }

        public PostagemVO Postagem
        {
            get {
                if (postagem == null)
                    postagem = new PostagemVO();
                return postagem; }
            set
            {
                postagem = value;
            }
        }
        #endregion
        
    }
}