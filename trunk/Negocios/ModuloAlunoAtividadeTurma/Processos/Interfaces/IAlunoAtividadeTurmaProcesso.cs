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
        /// Método responsável por incluir um alunoAtividadeTurma no sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser incluido.</param>
        void Incluir(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// Método responsável por excluir um alunoAtividadeTurma do sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser excluido.</param>
        void Excluir(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// Método reponsável por alterar um alunoAtividadeTurma do sistema.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma a ser alterado.</param>
        void Alterar(AlunoAtividadeTurma alunoAtividadeTurma);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="alunoAtividadeTurma">Objeto do tipo alunoAtividadeTurma que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<AlunoAtividadeTurma> Consultar(AlunoAtividadeTurma alunoAtividadeTurma, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os alunoAtividadeTurmas cadastrados.</returns>
        List<AlunoAtividadeTurma> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}