using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloDependencia.Repositorios;
using Negocios.ModuloDependencia.Processos;
using Negocios.ModuloDependencia.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloDependencia.Excecoes;

namespace Negocios.ModuloDependencia.Processos
{
    /// <summary>
    /// Classe DependenciaProcesso
    /// </summary>
    public class DependenciaProcesso : Singleton<DependenciaProcesso>, IDependenciaProcesso
    {
        #region Atributos
        private IDependenciaRepositorio dependenciaRepositorio = null;
        #endregion

        #region Construtor
        public DependenciaProcesso()
        {
            dependenciaRepositorio = DependenciaFabrica.IDependenciaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Dependencia dependencia)
        {
            this.dependenciaRepositorio.Incluir(dependencia);

        }

        public void Excluir(Dependencia dependencia)
        {

            try
            {
                if (dependencia.ID == 0)
                    throw new DependenciaNaoExcluidaExcecao();

                List<Dependencia> resultado = dependenciaRepositorio.Consultar(dependencia, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new DependenciaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.dependenciaRepositorio.Excluir(dependencia);
        }

        public void Alterar(Dependencia dependencia)
        {
            this.dependenciaRepositorio.Alterar(dependencia);
        }

        public List<Dependencia> Consultar(Dependencia dependencia, TipoPesquisa tipoPesquisa)
        {
            List<Dependencia> dependenciaList = this.dependenciaRepositorio.Consultar(dependencia,tipoPesquisa);           

            return dependenciaList;
        }

        public List<Dependencia> Consultar()
        {
            List<Dependencia> dependenciaList = this.dependenciaRepositorio.Consultar();

            return dependenciaList;
        }


        public void Confirmar()
        {
            this.dependenciaRepositorio.Confirmar();
        }

        #endregion
    }
}