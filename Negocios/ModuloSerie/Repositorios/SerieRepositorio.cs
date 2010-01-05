using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSerie.Excecoes;

namespace Negocios.ModuloSerie.Repositorios
{
    public class SerieRepositorio : ISerieRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Serie> Consultar()
        {
            return db.Serie.ToList();
        }

        public List<Serie> Consultar(Serie serie)
        {
            List<Serie> resultado = new List<Serie>();
            if (serie != null)
            {
                if (!string.IsNullOrEmpty(serie.Nome))
                {
                    resultado.AddRange((from s in db.Serie
                                        where s.Nome.Contains(serie.Nome)
                                        orderby s.Nome
                                        select s).ToList());
                }
            }

            // return db.Series.SingleOrDefault(d => d.Id == id);
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
                db.Serie.DeleteOnSubmit(serie);
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
                db.Serie.InsertOnSubmit(serie);
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


    }
}