using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloSite.Repositorios;
using Negocios.ModuloSite.Fabricas;

namespace Negocios.ModuloSite.Processos
{
    public class UsuarioProcesso :Negocios.ModuloBasico.Singleton.Singleton<UsuarioProcesso>, IUsuarioProcesso
    {
        #region Atributos
        private IUsuarioRepositorio usuarioRepositorio = null;
        #endregion

        #region Construtor
        public UsuarioProcesso()
        {
            usuarioRepositorio = UsuarioFabrica.IUsuarioInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Usuario usuario)
        {
            try
            {
                this.usuarioRepositorio.Incluir(usuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Usuario usuario)
        {
            try
            {
                this.usuarioRepositorio.Excluir(usuario);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.usuarioRepositorio.Excluir(usuario);
        }

        public void Alterar(Usuario usuario)
        {
            this.usuarioRepositorio.Alterar(usuario);
        }

        public List<Usuario> Consultar(Usuario usuario, TipoPesquisa tipoPesquisa)
        {
            List<Usuario> usuarioList = this.usuarioRepositorio.Consultar(usuario, tipoPesquisa);

            return usuarioList;
        }

        public List<Usuario> Consultar()
        {
            List<Usuario> usuarioList = usuarioRepositorio.Consultar();

            return usuarioList;
        }

        public void Confirmar()
        {
            usuarioRepositorio.Confirmar();
        }

        #endregion
    }
        
}