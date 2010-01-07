using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloMatricula.Processos
{
    /// <summary>
    /// Interface IMatriculaRepositorio
    /// </summary>
    public interface IMatriculaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma matricula no sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser incluido.</param>
        void Incluir(Matricula matricula);

        /// <summary>
        /// M�todo respons�vel por excluir uma matricula do sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser excluido.</param>
        void Excluir(Matricula matricula);

        /// <summary>
        /// M�todo repons�vel por alterar uma matricula do sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser alterado.</param>
        void Alterar(Matricula matricula);

        /// <summary>
        /// M�todo respons�vel por consultar matriculas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as matriculas cadastradas.</returns>
        List<Matricula> Consultar(Matricula matricula, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as matriculas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as matriculas cadastradas.</returns>
        List<Matricula> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}