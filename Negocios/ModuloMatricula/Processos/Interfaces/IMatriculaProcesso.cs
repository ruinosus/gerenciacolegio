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
        /// Método responsável por incluir uma matricula no sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser incluido.</param>
        void Incluir(Matricula matricula);

        /// <summary>
        /// Método responsável por excluir uma matricula do sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser excluido.</param>
        void Excluir(Matricula matricula);

        /// <summary>
        /// Método reponsável por alterar uma matricula do sistema.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula a ser alterado.</param>
        void Alterar(Matricula matricula);

        /// <summary>
        /// Método responsável por consultar matriculas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="matricula">Objeto do tipo matricula que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as matriculas cadastradas.</returns>
        List<Matricula> Consultar(Matricula matricula, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as matriculas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as matriculas cadastradas.</returns>
        List<Matricula> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}