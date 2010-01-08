using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloFuncionario.Processos
{
    /// <summary>
    /// Summary description for IFuncionarioRepositorio
    /// </summary>
    public interface IFuncionarioProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um funcionario no sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser incluido.</param>
        void Incluir(Funcionario funcionario);

        /// <summary>
        /// M�todo respons�vel por excluir um funcionario do sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser excluido.</param>
        void Excluir(Funcionario funcionario);

        /// <summary>
        /// M�todo repons�vel por alterar um funcionario do sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser alterado.</param>
        void Alterar(Funcionario funcionario);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Funcionario> Consultar(Funcionario funcionario, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os funcionarios cadastrados.</returns>
        List<Funcionario> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}