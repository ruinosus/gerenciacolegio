using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloDependencia.Repositorios
{
    /// <summary>
    /// Interface ISalaRepositorio
    /// </summary>
    public interface IDependenciaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma dependencia no sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser incluido.</param>
        void Incluir(Dependencia dependencia);

        /// <summary>
        /// Método responsável por excluir uma dependencia do sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser excluido.</param>
        void Excluir(Dependencia dependencia);

        /// <summary>
        /// Método reponsável por alterar uma dependencia do sistema.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia a ser alterado.</param>
        void Alterar(Dependencia dependencia);

        /// <summary>
        /// Método responsável por consultar salas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="dependencia">Objeto do tipo dependencia que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Dependencia> Consultar(Dependencia dependencia, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as salas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Dependencia> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}