using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloDisciplina.Repositorios
{
    /// <summary>
    /// Interface IDisciplinaRepositorio
    /// </summary>
    public interface IDisciplinaRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma disciplina no sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser incluido.</param>
        void Incluir(Disciplina disciplina);

        /// <summary>
        /// Método responsável por excluir uma disciplina do sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser excluido.</param>
        void Excluir(Disciplina disciplina);

        /// <summary>
        /// Método reponsável por alterar uma disciplina do sistema.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina a ser alterado.</param>
        void Alterar(Disciplina disciplina);

        /// <summary>
        /// Método responsável por consultar disciplinas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="disciplina">Objeto do tipo disciplina que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as disciplinas cadastradas.</returns>
        List<Disciplina> Consultar(Disciplina disciplina, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as disciplinas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as disciplinas cadastradas.</returns>
        List<Disciplina> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}