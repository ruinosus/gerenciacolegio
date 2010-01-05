using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloSerie.Repositorios;
using Negocios.ModuloSerie.Processos;
using Negocios.ModuloSerie.Fabricas;

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
            this.serieRepositorio.Excluir(serie);
        }

        public void Alterar(Serie serie)
        {
            this.serieRepositorio.Alterar(serie);
        }

        public List<Serie> Consultar(Serie serie)
        {
            List<Serie> serieList = this.serieRepositorio.Consultar(serie);           

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