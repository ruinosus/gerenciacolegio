using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloSala.Processos
{
    /// <summary>
    /// Interface ISalaRepositorio
    /// </summary>
    public interface ISalaProcesso
    {
        /// <summary>
        /// Método responsável por incluir uma sala no sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser incluido.</param>
        void Incluir(Sala sala);

        /// <summary>
        /// Método responsável por excluir uma sala do sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser excluido.</param>
        void Excluir(Sala sala);

        /// <summary>
        /// Método reponsável por alterar uma sala do sistema.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala a ser alterado.</param>
        void Alterar(Sala sala);

        /// <summary>
        /// Método responsável por consultar salas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="sala">Objeto do tipo sala que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>       
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Sala> Consultar(Sala sala, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as salas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Sala> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}