using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloMatriculaVinculo.Processos
{
    /// <summary>
    /// Interface IMatriculaVinculoRepositorio
    /// </summary>
    public interface IMatriculaVinculoProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma matriculaVinculo no sistema.
        /// </summary>
        /// <param name="matriculaVinculo">Objeto do tipo matriculaVinculo a ser incluido.</param>
        void Incluir(MatriculaVinculo matriculaVinculo);

        /// <summary>
        /// M�todo respons�vel por excluir uma matriculaVinculo do sistema.
        /// </summary>
        /// <param name="matriculaVinculo">Objeto do tipo matriculaVinculo a ser excluido.</param>
        void Excluir(MatriculaVinculo matriculaVinculo);

        /// <summary>
        /// M�todo repons�vel por alterar uma matriculaVinculo do sistema.
        /// </summary>
        /// <param name="matriculaVinculo">Objeto do tipo matriculaVinculo a ser alterado.</param>
        void Alterar(MatriculaVinculo matriculaVinculo);

        /// <summary>
        /// M�todo respons�vel por consultar matriculaVinculos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="matriculaVinculo">Objeto do tipo matriculaVinculo que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as matriculaVinculos cadastradas.</returns>
        List<MatriculaVinculo> Consultar(MatriculaVinculo matriculaVinculo, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as matriculaVinculos do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as matriculaVinculos cadastradas.</returns>
        List<MatriculaVinculo> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}