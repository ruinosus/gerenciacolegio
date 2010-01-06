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
        /// M�todo respons�vel por incluir um desconto no sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser incluido.</param>
        void Incluir(Desconto desconto);

        /// <summary>
        /// M�todo respons�vel por excluir um desconto do sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser excluido.</param>
        void Excluir(Desconto desconto);

        /// <summary>
        /// M�todo repons�vel por alterar um desconto do sistema.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto a ser alterado.</param>
        void Alterar(Desconto desconto);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="desconto">Objeto do tipo desconto que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Desconto> Consultar(Desconto desconto, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os descontos cadastrados.</returns>
        List<Desconto> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}