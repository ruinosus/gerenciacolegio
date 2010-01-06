using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloNota.Repositorios
{
    /// <summary>
    /// Interface ISalaRepositorio
    /// </summary>
    public interface INotaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma nota no sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser incluido.</param>
        void Incluir(Nota nota);

        /// <summary>
        /// Método responsável por excluir uma nota do sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser excluido.</param>
        void Excluir(Nota nota);

        /// <summary>
        /// Método reponsável por alterar uma nota do sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser alterado.</param>
        void Alterar(Nota nota);

        /// <summary>
        /// Método responsável por consultar salas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Nota> Consultar(Nota nota, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as salas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Nota> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}