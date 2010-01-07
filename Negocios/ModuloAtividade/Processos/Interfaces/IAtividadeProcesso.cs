using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAtividade.Processos
{
    /// <summary>
    /// Interface IAtividadeRepositorio
    /// </summary>
    public interface IAtividadeProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir uma atividade no sistema.
        /// </summary>
        /// <param name="atividade">Objeto do tipo atividade a ser incluido.</param>
        void Incluir(Atividade atividade);

        /// <summary>
        /// M�todo respons�vel por excluir uma atividade do sistema.
        /// </summary>
        /// <param name="atividade">Objeto do tipo atividade a ser excluido.</param>
        void Excluir(Atividade atividade);

        /// <summary>
        /// M�todo repons�vel por alterar uma atividade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo atividade a ser alterado.</param>
        void Alterar(Atividade atividade);

        /// <summary>
        /// M�todo respons�vel por consultar atividades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="atividade">Objeto do tipo atividade que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as atividades cadastradas.</returns>
        List<Atividade> Consultar(Atividade atividade, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todas as atividades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as atividades cadastradas.</returns>
        List<Atividade> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}