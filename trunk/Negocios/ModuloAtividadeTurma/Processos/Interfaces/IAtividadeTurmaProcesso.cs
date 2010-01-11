using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAtividadeTurma.Processos
{
    /// <summary>
    /// Interface IAtividadeTurmaRepositorio
    /// </summary>
    public interface IAtividadeTurmaProcesso
    {
        /// <summary>
        /// Método responsável por incluir uma atividadeTurma no sistema.
        /// </summary>
        /// <param name="atividadeTurma">Objeto do tipo atividadeTurma a ser incluido.</param>
        void Incluir(AtividadeTurma atividadeTurma);

        /// <summary>
        /// Método responsável por excluir uma atividadeTurma do sistema.
        /// </summary>
        /// <param name="atividadeTurma">Objeto do tipo atividadeTurma a ser excluido.</param>
        void Excluir(AtividadeTurma atividadeTurma);

        /// <summary>
        /// Método reponsável por alterar uma atividadeTurma do sistema.
        /// </summary>
        /// <param name="atividadeTurma">Objeto do tipo atividadeTurma a ser alterado.</param>
        void Alterar(AtividadeTurma atividadeTurma);

        /// <summary>
        /// Método responsável por consultar atividadeTurmas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="atividadeTurma">Objeto do tipo atividadeTurma que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as atividadeTurmas cadastradas.</returns>
        List<AtividadeTurma> Consultar(AtividadeTurma atividadeTurma, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as atividadeTurmas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as atividadeTurmas cadastradas.</returns>
        List<AtividadeTurma> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}