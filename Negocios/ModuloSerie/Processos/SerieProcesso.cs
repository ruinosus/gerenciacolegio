using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloSerie.Repositorios;
using Negocios.ModuloSerie.Processos;
using Negocios.ModuloSerie.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSerie.Excecoes;

namespace Negocios.ModuloSerie.Processos
{
    /// <summary>
    /// Classe SerieProcesso
    /// </summary>
    public class SerieProcesso : Singleton<SerieProcesso>, ISerieProcesso
    {
        #region Atributos
        private ISerieRepositorio serieRepositorio = null;
        #endregion

        #region Construtor
        public SerieProcesso()
        {
            serieRepositorio = SerieFabrica.ISerieInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Serie serie)
        {
            this.serieRepositorio.Incluir(serie);

        }

        public void Excluir(Serie serie)
        {

            try
            {
                if (serie.ID == 0)
                    throw new SerieNaoExcluidaExcecao();

                List<Serie> resultado = serieRepositorio.Consultar(serie, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new SerieNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.serieRepositorio.Excluir(serie);
        }

        public void Alterar(Serie serie)
        {
            this.serieRepositorio.Alterar(serie);
        }

        public List<Serie> Consultar(Serie serie, TipoPesquisa tipoPesquisa)
        {
            List<Serie> serieList = this.serieRepositorio.Consultar(serie,tipoPesquisa);           

            return serieList;
        }

        public List<Serie> Consultar()
        {
            List<Serie> serieList = this.serieRepositorio.Consultar();

            return serieList;
        }

        public void Confirmar()
        {
            this.serieRepositorio.Confirmar();
        }

        #endregion
    }
}