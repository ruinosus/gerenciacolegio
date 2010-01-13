using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloDependencia.Repositorios;
using Negocios.ModuloDependencia.Processos;
using Negocios.ModuloDependencia.Fabricas;
using Negocios.ModuloBasico.Enums;

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