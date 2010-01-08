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
        /// Método responsável por incluir um funcionario no sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser incluido.</param>
        void Incluir(Funcionario funcionario);

        /// <summary>
        /// Método responsável por excluir um funcionario do sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser excluido.</param>
        void Excluir(Funcionario funcionario);

        /// <summary>
        /// Método reponsável por alterar um funcionario do sistema.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario a ser alterado.</param>
        void Alterar(Funcionario funcionario);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="funcionario">Objeto do tipo funcionario que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Funcionario> Consultar(Funcionario funcionario, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os funcionarios cadastrados.</returns>
        List<Funcionario> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}