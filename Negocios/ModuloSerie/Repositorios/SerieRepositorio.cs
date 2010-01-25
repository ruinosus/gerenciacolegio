using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSerie.Excecoes;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSerie.Repositorios
{
    public class SerieRepositorio : ISerieRepositorio
    {
        #region Atributos

        ColegioDB db;

        #endregion

        #region Métodos da Interface

        public List<Serie> Consultar()
        {
            return db.Serie.ToList();
        }

        public List<Serie> Consultar(Serie serie, TipoPesquisa tipoPesquisa)
        {
            List<Serie> resultado = Consultar();

            switch (tipoPesquisa)
            {
                #region Case E
                case TipoPesquisa.E:
                    {
                        if (serie.ID != 0)
                        {

                            resultado = ((from s in resultado
                                          where
                                          s.ID == serie.ID
                                          select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(serie.Nome))
                        {

                            resultado = ((from s in resultado
                                          where
                                          s.Nome.Contains(serie.Nome)
                                          select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (serie.Status.HasValue)
                        {

                            resultado = ((from s in resultado
                                          where
                                          s.Status.HasValue && s.Status.Value == serie.Status.Value
                                          select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }


                        break;
                    }
                #endregion
                #region Case Ou
                case TipoPesquisa.Ou:
                    {
                        if (serie.ID != 0)
                        {

                            resultado.AddRange((from s in Consultar()
                                                where
                                                s.ID == serie.ID
                                                select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (!string.IsNullOrEmpty(serie.Nome))
                        {

                            resultado.AddRange((from s in Consultar()
                                                where
                                                s.Nome.Contains(serie.Nome)
                                                select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }

                        if (serie.Status.HasValue)
                        {

                            resultado.AddRange((from s in Consultar()
                                                where
                                                s.Status.HasValue && s.Status.Value == serie.Status.Value
                                                select s).ToList());

                            resultado = resultado.Distinct().ToList();
                        }



                        break;
                    }
                #endregion
                default:
                    break;
            }

            return resultado;
        }

        public void Incluir(Serie serie)
        {
            try
            {
                db.Serie.InsertOnSubmit(serie);
            }
            catch (Exception)
            {

                throw new SerieNaoIncluidaExcecao();
            }
        }

        public void Excluir(Serie serie)
        {
            try
            {
                Serie serieAux = new Serie();
                serieAux.ID = serie.ID;

                List<Serie> resultado = this.Consultar(serieAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SerieNaoExcluidaExcecao();

                serieAux = resultado[0];

                db.Serie.DeleteOnSubmit(serieAux);
            }
            catch (Exception)
            {

                throw new SerieNaoExcluidaExcecao();
            }
        }

        public void Alterar(Serie serie)
        {
            try
            {
                Serie serieAux = new Serie();
                serieAux.ID = serie.ID;

                List<Serie> resultado = this.Consultar(serieAux, TipoPesquisa.E);

                if (resultado == null || resultado.Count == 0)
                    throw new SerieNaoAlteradaExcecao();

                serieAux = resultado[0];
                serieAux.Nome = serie.Nome;
                serieAux.Status = serie.Status;
                Confirmar();
            }
            catch (Exception)
            {
                throw new SerieNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion

        #region Construtor
        public SerieRepositorio()
        {
            Conexao conexao = new Conexao();
            db = new ColegioDB(new MySqlConnection(conexao.ToString()));

        }
        #endregion


    }
}