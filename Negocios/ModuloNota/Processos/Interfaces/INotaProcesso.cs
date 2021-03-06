using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloNota.Processos
{
    /// <summary>
    /// Interface INotaRepositorio
    /// </summary>
    public interface INotaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma nota no sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser incluido.</param>
        void Incluir(Nota nota);

        /// <summary>
        /// M�todo respons�vel por excluir uma nota do sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser excluido.</param>
        void Excluir(Nota nota);

        /// <summary>
        /// M�todo repons�vel por alterar uma nota do sistema.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota a ser alterado.</param>
        void Alterar(Nota nota);

        /// <summary>
        /// M�todo respons�vel por consultar salas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="nota">Objeto do tipo nota que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Nota> Consultar(Nota nota, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as salas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as salas cadastradas.</returns>
        List<Nota> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}