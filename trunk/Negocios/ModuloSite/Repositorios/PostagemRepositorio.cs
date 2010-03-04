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
			postagemAux.Titulo = postagem.Titulo;
            postagemAux.SubTitulo = postagem.SubTitulo;
			postagemAux.Corpo = postagem.Corpo;
            postagemAux.ImagemI = postagem.ImagemI;
            postagemAux.ImagemII = postagem.ImagemII;
			postagemAux.ImagemIII = postagem.ImagemIII;
			postagemAux.LegendaI = postagem.LegendaI;
            postagemAux.LegendaII = postagem.LegendaII;	
			postagemAux.LegendaIII = postagem.LegendaIII;
			postagemAux.Local = postagem.Local;
			postagemAux.Tipo = postagem.Tipo;
			postagemAux.Pagina = postagem.Pagina;
			postagemAux.EmDestaque = postagem.EmDestaque;
			

            Confirmar();
        }

        public List<Postagem> Consultar(Postagem postagem, TipoPesquisa tipoPesquisa)
        {
            List<Postagem> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (postagem.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == postagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(postagem.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(postagem.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                       }   
					   
					    if (postagem.Pagina != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Pagina  == postagem.Pagina 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.Local != 0)
                        {

                            resultado =((from p in resultado
                                          where
                                          p.Local  == postagem.Local 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.Tipo != 0)
                        {

                            resultado =((from p in resultado
                                          where
                                          p.Tipo  == postagem.Tipo 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.EmDestaque.HasValue)
                        {

                            resultado =((from p in resultado
                                          where
                                          p.EmDestaque.HasValue && p.EmDestaque.Value== postagem.EmDestaque 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
					   
					   
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (postagem.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == postagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(postagem.Titulo))
                        {

                            resultado.AddRange ((from p in resultado
                                          where
                                          p.Titulo.Contains(postagem.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                       }   
					   
					    if (postagem.Pagina != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Pagina  == postagem.Pagina 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.Local != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Local  == postagem.Local 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.Tipo != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Tipo  == postagem.Tipo 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
						
						if (postagem.EmDestaque.HasValue)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.EmDestaque.HasValue && p.EmDestaque.Value == postagem.EmDestaque 
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
					   
					   
                       break;
                    }
                #endregion
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
            ConexaoSite conexao = new ConexaoSite();
            db = new SiteColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}