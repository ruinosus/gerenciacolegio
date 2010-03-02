using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using MySql.Data.MySqlClient;
using Negocios.ModuloBasico.Singleton;

namespace Negocios.ModuloSite.Repositorios
{
    public class PostagemRepositorio : IPostagemRepositorio
    {
        #region Atributos

        SiteColegioDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Postagem postagem)
        {
            db.Postagem.InsertOnSubmit(postagem);
        }

        public void Excluir(Postagem postagem)
        {
            Postagem postagemAux = new Postagem();
            postagemAux.ID = postagem.ID;
            List<Postagem> resultado = this.Consultar(postagemAux, TipoPesquisa.E);
            postagemAux = resultado[0];

            db.Postagem.DeleteOnSubmit(postagemAux);
        }

        public void Alterar(Postagem postagem)
        {
            Postagem postagemAux = new Postagem();
            postagemAux.ID = postagem.ID;
            List<Postagem> resultado = this.Consultar(postagemAux, TipoPesquisa.E);
            postagemAux = resultado[0];


            postagemAux = resultado[0];
            //postagemAux.Descricao = postagem.Descricao;
            //postagemAux.Nome = postagem.Nome;
            //postagemAux.DataPostagem = postagem.DataPostagem;
            //postagemAux.PontoID = postagem.PontoID;
            //postagemAux.UsuarioID = postagem.UsuarioID;
            //postagemAux.ImagemGrande = postagem.ImagemGrande;
            //postagemAux.ImagemMedia = postagem.ImagemMedia;
            //postagemAux.ImagemPequena = postagem.ImagemPequena;

            Confirmar();
        }

        public List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa)
        {
            List<Postagem> resultado = Consultar();

            switch (tipoPesquisa)
            {
                //#region Case E
                //case TipoPesquisa.E:
                //    {
                //        if (postagem.ID != 0)
                //        {

                //            resultado = ((from p in resultado
                //                          where
                //                          p.ID == postagem.ID
                //                          select p).ToList());

                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (!string.IsNullOrEmpty(postagem.Descricao))
                //        {

                //            resultado = ((from p in resultado
                //                          where
                //                          p.Descricao.Contains(postagem.Descricao)
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }                        

                //        if (postagem.DataPostagem.HasValue)
                //        {

                //            resultado = ((from p in resultado
                //                          where
                //                            p.DataPostagem.HasValue && p.DataPostagem.Value == postagem.DataPostagem.Value
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }					
						

                //        if (!string.IsNullOrEmpty(postagem.Nome))
                //        {

                //            resultado = ((from p in resultado
                //                          where
                //                          p.Nome.Contains(postagem.Nome)
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }
						
                //        if(postagem.PontoID!=null && postagem.PontoID!=0)
                //        {
                //             resultado = ((from p in resultado
                //                          where
                //                          p.PontoID == postagem.PontoID
                //                          select p).ToList());

                //            resultado = resultado.Distinct().ToList();
                //        }
                //       break;
                //    } 
                //#endregion
                //#region Case Ou
                //case TipoPesquisa.Ou:
                //    {
                //         if (postagem.ID != 0)
                //        {

                //            resultado.AddRange((from p in resultado
                //                          where
                //                          p.ID == postagem.ID
                //                          select p).ToList());

                //            resultado = resultado.Distinct().ToList();
                //        }

                //        if (!string.IsNullOrEmpty(postagem.Descricao))
                //        {

                //            resultado.AddRange((from p in resultado
                //                          where
                //                          p.Descricao.Contains(postagem.Descricao)
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }                        

                //        if (postagem.DataPostagem.HasValue)
                //        {

                //            resultado.AddRange((from p in resultado
                //                          where
                //                            p.DataPostagem.HasValue && p.DataPostagem.Value == postagem.DataPostagem.Value
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }					
						

                //        if (!string.IsNullOrEmpty(postagem.Nome))
                //        {

                //            resultado.AddRange((from p in resultado
                //                          where
                //                          p.Nome.Contains(postagem.Nome)
                //                          select p).ToList());


                //            resultado = resultado.Distinct().ToList();
                //        }
						
                //        if(postagem.PontoID!=null && postagem.PontoID!=0)
                //        {
                //             resultado.AddRange((from p in resultado
                //                          where
                //                          p.PontoID == postagem.PontoID
                //                          select p).ToList());

                //            resultado = resultado.Distinct().ToList();
                //        }
                //       break;
                //    }
                //#endregion
            }

            return resultado;
        }

        public List<Postagem> Consultar()
        {
            return db.Postagem.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public PostagemRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new SiteColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}