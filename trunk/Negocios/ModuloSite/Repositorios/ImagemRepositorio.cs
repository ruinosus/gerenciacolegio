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
    public class ImagemRepositorio : IImagemRepositorio
    {
        #region Atributos

        SiteColegioDB db;

        #endregion

        #region Métodos da Interface

        public void Incluir(Imagem imagem)
        {
            db.Imagem.InsertOnSubmit(imagem);
        }

        public void Excluir(Imagem imagem)
        {
            Imagem imagemAux = new Imagem();
            imagemAux.ID = imagem.ID;
            List<Imagem> resultado = this.Consultar(imagemAux, TipoPesquisa.E);
            imagemAux = resultado[0];

            db.Imagem.DeleteOnSubmit(imagemAux);
        }

        public void Alterar(Imagem imagem)
        {
            Imagem imagemAux = new Imagem();
            imagemAux.ID = imagem.ID;
            List<Imagem> resultado = this.Consultar(imagemAux, TipoPesquisa.E);
            imagemAux = resultado[0];


            imagemAux = resultado[0];
            imagemAux.Titulo = imagem.Titulo;
            imagemAux.SubTitulo = imagem.SubTitulo;
            imagemAux.Corpo = imagem.Corpo;
            imagemAux.ImagemI = imagem.ImagemI;
            imagemAux.ImagemII = imagem.ImagemII;
			imagemAux.ImagemIII = imagem.ImagemIII;
			imagemAux.LegendaI = imagem.LegendaI;
            imagemAux.LegendaII = imagem.LegendaII;	
			imagemAux.LegendaIII = imagem.LegendaIII;
			imagemAux.PostagemID = imagem.PostagemID;

            Confirmar();
        }

        public List<Imagem> Consultar(Imagem imagem, TipoPesquisa tipoPesquisa)
        {
            List<Imagem> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {                      
					
                        if (imagem.ID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.ID == imagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(imagem.Titulo))
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.Titulo.Contains(imagem.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                       }   
					   
					    if (imagem.PostagemID != 0)
                        {

                            resultado = ((from p in resultado
                                          where
                                          p.PostagemID == imagem.PostagemID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
					   
					   
                       break;
                    } 
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
					 if (imagem.ID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.ID == imagem.ID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(imagem.Titulo))
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.Titulo.Contains(imagem.Titulo)
                                          select p).ToList());


                            resultado = resultado.Distinct().ToList();
                       }   
					   
					    if (imagem.PostagemID != 0)
                        {

                            resultado.AddRange((from p in resultado
                                          where
                                          p.PostagemID == imagem.PostagemID
                                          select p).ToList());

                            resultado = resultado.Distinct().ToList();
                        }
                       break;
                    }
                #endregion
            }

            return resultado;
        }

        public List<Imagem> Consultar()
        {
            return db.Imagem.ToList();
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public ImagemRepositorio()
        {
            ConexaoSite conexao = new ConexaoSite();
            db = new SiteColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion
    }
}