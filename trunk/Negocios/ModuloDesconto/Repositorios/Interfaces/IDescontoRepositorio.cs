using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloDesconto.Repositorios
{
    /// <summary>
    /// Summary description for IDescontoRepositorio
    /// </summary>
    public interface IDescontoRepositorio
    {
        /// <summary>
        /// Método responsável por incluir um desconto no sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser incluido.</param>
        void Incluir(Desconto desconto);

        /// <summary>
        /// Método responsável por excluir um desconto do sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser excluido.</param>
        void Excluir(Desconto desconto);

        /// <summary>
        /// Método reponsável por alterar um desconto do sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser alterado.</param>
        void Alterar(Desconto desconto);

        /// <summary>
        /// Método responsável por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Desconto> Consultar(Desconto desconto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos os comentários do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os descontos cadastrados.</returns>
        List<Desconto> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}