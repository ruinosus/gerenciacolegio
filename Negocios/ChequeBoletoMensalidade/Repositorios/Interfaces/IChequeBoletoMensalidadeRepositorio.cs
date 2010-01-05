using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloChequeBoletoMensalidade.Repositorios
{
    /// <summary>
    /// Interface IChequeBoletoMensalidadeRepositorio
    /// </summary>
    public interface IChequeBoletoMensalidadeRepositorio
    {
        /// <summary>
        /// Método responsável por incluir uma chequeBoletoMensalidade no sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo chequeBoletoMensalidade a ser incluido.</param>
        void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método responsável por excluir uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo chequeBoletoMensalidade a ser excluido.</param>
        void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método reponsável por alterar uma chequeBoletoMensalidade do sistema.
        /// </summary>
        /// <param name="turma">Objeto do tipo chequeBoletoMensalidade a ser alterado.</param>
        void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método responsável por consultar chequeBoletoMensalidades do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turma">Objeto do tipo turma que irá ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade);

        /// <summary>
        /// Método responsável por consultar todas as chequeBoletoMensalidades do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as chequeBoletoMensalidades cadastradas.</returns>
        List<ChequeBoletoMensalidade> Consultar();
		
		/// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
		void Confirmar();
    }
}