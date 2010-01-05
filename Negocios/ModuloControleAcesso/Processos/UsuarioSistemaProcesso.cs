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
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloControleAcesso.Repositorios;
using Negocios.ModuloControleAcesso.Fabricas;
using System.Collections.Generic;
using Negocios.ModuloControleAcesso.Filtros;
using Negocios.ModuloControleAcesso.Excecoes;
using Negocios.ModuloAuxuliar.VOs;
using Negocios.ModuloAuxiliar.Processos;
using Negocios.ModuloAuxuliar.Filtros;
using Negocios.ModuloControleAcesso.VOs;

namespace Negocios.ModuloControleAcesso.Processos
{
    /// <summary>
    /// Summary description for UsuarioSistemaProcesso
    /// </summary>
    public class UsuarioSistemaProcesso : Singleton<UsuarioSistemaProcesso>, IUsuarioSistemaProcesso
    {
        #region Atributos
        private IUsuarioSistemaRepositorio usuarioSistemaRepositorio = null;
        #endregion

        #region Construtor
        public UsuarioSistemaProcesso()
        {
            usuarioSistemaRepositorio = ModuloControleAcessoFabrica.IUsuarioSistemaRepositorioInstance;
        }

        #endregion

        #region Métodos da Interface

        public void Incluir(UsuarioSistemaVO usuarioSistemaVO)
        {
            UsuarioSistemaVO usuarioPesquisa = new UsuarioSistemaVO();
            usuarioPesquisa.Login = usuarioSistemaVO.Login;
            UsuarioSistemaFiltroConsulta filtro = new UsuarioSistemaFiltroConsulta();
            filtro.Login = true;
            List<UsuarioSistemaVO> usuarioLista = this.Consultar(usuarioPesquisa, filtro, false);

            if (usuarioLista.Count > 0)
                throw new UsuarioSistemaLoginJaInformadoExcecao();

            if (!usuarioSistemaVO.IsAdministrador)
                usuarioSistemaVO.StatusUsuarioSistema = Negocios.ModuloAuxuliar.Enums.StatusUsuarioSistema.UsuarioPendente;
            else
                usuarioSistemaVO.StatusUsuarioSistema = Negocios.ModuloAuxuliar.Enums.StatusUsuarioSistema.UsuarioAtivo;

            usuarioSistemaRepositorio.Incluir(usuarioSistemaVO);
        }

        public void Excluir(UsuarioSistemaVO usuarioSistemaVO)
        {
            this.usuarioSistemaRepositorio.Excluir(usuarioSistemaVO);
        }

        public void Alterar(UsuarioSistemaVO usuarioSistemaVO)
        {
            this.usuarioSistemaRepositorio.Alterar(usuarioSistemaVO);
        }

        public List<UsuarioSistemaVO> Consultar(UsuarioSistemaVO usuarioSistemaVO, UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy)
        {
            List<UsuarioSistemaVO> usuarioList = usuarioSistemaRepositorio.Consultar(usuarioSistemaVO, usuarioSistemaFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (UsuarioSistemaVO usuario in usuarioList)
                {
                    usuario.Endereco.Cidade = this.MontarCidade(usuario.Endereco.Cidade.ID);
                    usuario.EnderecoAtua.Cidade = this.MontarCidade(usuario.EnderecoAtua.Cidade.ID);
                }
            }

            return usuarioList;
        }

        public List<UsuarioSistemaVO> Consultar(UsuarioSistemaFiltroConsulta usuarioSistemaFiltroConsulta, bool lazy)
        {
            List<UsuarioSistemaVO> usuarioList = usuarioSistemaRepositorio.Consultar(usuarioSistemaFiltroConsulta, lazy);

            if (lazy)
            {
                foreach (UsuarioSistemaVO usuario in usuarioList)
                {
                    usuario.Endereco.Cidade = this.MontarCidade(usuario.Endereco.Cidade.ID);
                    usuario.EnderecoAtua.Cidade = this.MontarCidade(usuario.Endereco.Cidade.ID);
                }
            }

            return usuarioList;
        }

        #endregion

        #region Métodos Utilitários
        private Cidade MontarCidade(int CidadeId)
        {
            Cidade cidade = new Cidade();
            ICidadeEstadoRegiaoProcesso processo = CidadeEstadoRegiaoProcesso.Instance;
            CidadeFiltroConsulta filtro = new CidadeFiltroConsulta();
            filtro.HabilitaTudo();
            cidade.ID = CidadeId;
            List<Cidade> cidadeList = processo.ConsultarCidades(cidade, filtro, true);

            if (cidadeList.Count > 0)
            {
                cidade = cidadeList[0];

            }
            return cidade;
        }

        private Estado MontarEstado(int EstadoId)
        {
            Estado estado = new Estado();
            ICidadeEstadoRegiaoProcesso processo = CidadeEstadoRegiaoProcesso.Instance;
            EstadoFiltroConsulta filtro = new EstadoFiltroConsulta();
            filtro.HabilitaTudo();
            estado.ID = EstadoId;
            List<Estado> estadoList = processo.ConsultarEstados(estado, filtro, true);

            if (estadoList.Count > 0)
            {
                estado = estadoList[0];

            }


            return estado;
        }
       
        #endregion
    }
}