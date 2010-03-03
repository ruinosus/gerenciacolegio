using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.Processos
{
    public interface IImagemProcesso
    {
        /// <summary>
        /// Método responsável por incluir uma imagem no sistema.
        /// </summary>
        /// <param name="imagem">Objeto do tipo imagem a ser incluido.</param>
        void Incluir(Imagem imagem);

        /// <summary>
        /// Método responsável por excluir uma imagem do sistema.
        /// </summary>
        /// <param name="imagem">Objeto do tipo imagem a ser excluido.</param>
        void Excluir(Imagem imagem);

        /// <summary>
        /// Método reponsável por alterar uma imagem do sistema.
        /// </summary>
        /// <param name="imagem">Objeto do tipo imagem a ser alterado.</param>
        void Alterar(Imagem imagem);

        /// <summary>
        /// Método responsável por consultar imagems do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="imagem">Objeto do tipo imagem que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as imagems cadastrados.</returns>
        List<Imagem> Consultar(Imagem imagem, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todos as imagems do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as imagems cadastrados.</returns>
        List<Imagem> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}