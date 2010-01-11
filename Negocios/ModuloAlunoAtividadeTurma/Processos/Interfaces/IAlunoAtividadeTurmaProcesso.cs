using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloAlunoAtividadeTurma.Processos
{
    /// <summary>
    /// Summary description for IAlunoAtividadeTurmaRepositorio
    /// </summary>
    public interface IAlunoAtividadeTurmaProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um alunoAtividadeTurma no sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser incluido.</param>
        void Incluir(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// M�todo respons�vel por excluir um alunoAtividadeTurma do sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser excluido.</param>
        void Excluir(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// M�todo repons�vel por alterar um alunoAtividadeTurma do sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser alterado.</param>
        void Alterar(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<AlunoAtividadeTurma> Consultar(AlunoAtividadeTurma alunoAtividadeTurma, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunoAtividadeTurmas cadastrados.</returns>
        List<AlunoAtividadeTurma> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}