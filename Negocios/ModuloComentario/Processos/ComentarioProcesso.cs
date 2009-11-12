using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloComentario.Processos;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloComentario.Fabricas;
using Negocios.ModuloComentario.Repositorios;
using Negocios.ModuloComentario.VOs;
using Negocios.ModuloComentario.Filtro;
using Negocios.ModuloControleAcesso.Processos;
using Negocios.ModuloControleAcesso.Filtros;
using Negocios.ModuloPostagem.VOs;
using Negocios.ModuloPostagem.Processos;
using Negocios.ModuloPostagem.Filtros;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloComentario.Processos
{
    /// <summary>
    /// Summary description for ComentarioProcesso
    /// </summary>
    public class ComentarioProcesso : Singleton<ComentarioProcesso>, IComentarioProcesso
    {
        #region Atributos
        private IComentarioRepositorio comentarioRepositorio = null;
        #endregion

        #region Construtor
        public ComentarioProcesso()
        {
            comentarioRepositorio = ModuloComentarioFabrica.IComentarioInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ComentarioVO comentario)
        {
            comentario.DataCriacao = DateTime.Now;
            this.comentarioRepositorio.Incluir(comentario);

        }

        public void Excluir(ComentarioVO comentario)
        {
            this.comentarioRepositorio.Excluir(comentario);
        }

        public void Alterar(ComentarioVO comentario)
        {
            this.comentarioRepositorio.Alterar(comentario);
        }

        public List<ComentarioVO> Consultar(ComentarioVO comentario, ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy)
        {
            List<ComentarioVO> comentarioList = this.comentarioRepositorio.Consultar(comentario, comentarioFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (ComentarioVO c in comentarioList)
                {
                    c.Usuario = (this.MontarUsuario(c.Usuario.ID));
                    c.Postagem = (this.MontarPostagem(c.Postagem.ID));
                }

            }

            return comentarioList;
        }

        public List<ComentarioVO> Consultar(ComentarioFiltroConsulta comentarioFiltroConsulta, bool lazy)
        {
            List<ComentarioVO> comentarioList = this.comentarioRepositorio.Consultar(comentarioFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (ComentarioVO c in comentarioList)
                {
                    c.Usuario = (this.MontarUsuario(c.Usuario.ID));
                    c.Postagem = (this.MontarPostagem(c.Postagem.ID));
                }

            }

            return comentarioList;
        }

        #endregion

        #region Métodos Utilitários
        private UsuarioSistemaVO MontarUsuario(int UsuarioId)
        {
            UsuarioSistemaVO usuario = new UsuarioSistemaVO();
            IUsuarioSistemaProcesso processo = UsuarioSistemaProcesso.Instance;
            UsuarioSistemaFiltroConsulta filtro = new UsuarioSistemaFiltroConsulta();
            filtro.HabilitaTudo();
            usuario.ID = UsuarioId;
            List<UsuarioSistemaVO> usuarioList = processo.Consultar(usuario, filtro, true);

            if (usuarioList.Count > 0)
            {
                usuario = usuarioList[0];

            }
            return usuario;
        }
        private PostagemVO MontarPostagem(int PostagemId)
        {
            PostagemVO postagem = new PostagemVO();
            IPostagemProcesso processo = PostagemProcesso.Instance;
            PostagemFiltroConsulta filtro = new PostagemFiltroConsulta();
            filtro.HabilitaTudo();
            postagem.ID = PostagemId;
            List<PostagemVO> postagemList = processo.Consultar(postagem, filtro, true);

            if (postagemList.Count > 0)
            {
                postagem = postagemList[0];

            }
            return postagem;
        }
        #endregion
    }
}