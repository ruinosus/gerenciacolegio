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
    public class PostagemProcesso :Negocios.ModuloBasico.Singleton.Singleton<PostagemProcesso>, IPostagemProcesso
    {
        #region Atributos
        private IPostagemRepositorio postagemRepositorio = null;
        #endregion

        #region Construtor
        public PostagemProcesso()
        {
            postagemRepositorio = PostagemFabrica.IPostagemInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Postagem postagem)
        {
            try
            {
                this.postagemRepositorio.Incluir(postagem);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Postagem postagem)
        {
            try
            {
                this.postagemRepositorio.Excluir(postagem);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.postagemRepositorio.Excluir(postagem);
        }

        public void Alterar(Postagem postagem)
        {
            this.postagemRepositorio.Alterar(postagem);
        }

        public List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa)
        {
            List<Postagem> postagemList = this.postagemRepositorio.Consultar(postagem, tipoPesquisa);

            return postagemList;
        }

        public List<Postagem> Consultar()
        {
            List<Postagem> postagemList = postagemRepositorio.Consultar();

            return postagemList;
        }

        public void Confirmar()
        {
            postagemRepositorio.Confirmar();
        }

        #endregion
    }
        
}