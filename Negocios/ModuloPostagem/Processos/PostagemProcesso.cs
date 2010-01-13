using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloPostagem.Fabricas;
using Negocios.ModuloPostagem.Repositorios;
using Negocios.ModuloPostagem.VOs;
using Negocios.ModuloPostagem.Filtros;
using Negocios.ModuloControleAcesso.Processos;
using Negocios.ModuloControleAcesso.Filtros;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloPostagem.Processos
{
    /// <summary>
    /// Summary description for PostagemProcesso
    /// </summary>
    public class PostagemProcesso : Singleton<PostagemProcesso>, IPostagemProcesso
    {
        #region Atributos
        private IPostagemRepositorio postagemRepositorio = null;
        #endregion

        #region Construtor
        public PostagemProcesso()
        {
            postagemRepositorio = ModuloPostagemFabrica.IPostagemInstance;
        }

        #endregion

        #region Métodos da Interface

        public void Incluir(PostagemVO postagemVO)
        {
            postagemVO.DataCriacao = DateTime.Now;
            this.postagemRepositorio.Incluir(postagemVO);
        }

        public void Excluir(PostagemVO postagemVO)
        {
            //this.postagemRepositorio.Excluir(postagemVO);
        }

        public void Alterar(PostagemVO postagemVO)
        {
            this.postagemRepositorio.Alterar(postagemVO);
        }

        public List<PostagemVO> Consultar(PostagemVO postagemVO, PostagemFiltroConsulta postagemFiltroConsulta, bool lazy)
        {
            List<PostagemVO> postagemList = this.postagemRepositorio.Consultar(postagemVO,postagemFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (PostagemVO p in postagemList)
                {
                    p.Usuario = (this.MontarUsuario(p.Usuario.ID));
                }

            }

            return postagemList;
        }

        public List<PostagemVO> Consultar(PostagemFiltroConsulta postagemFiltroConsulta, bool lazy)
        {
            List<PostagemVO> postagemList = this.postagemRepositorio.Consultar(postagemFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (PostagemVO p in postagemList)
                {
                    p.Usuario = (this.MontarUsuario(p.Usuario.ID));
                }

            }

            return postagemList;
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
        #endregion
    }
}