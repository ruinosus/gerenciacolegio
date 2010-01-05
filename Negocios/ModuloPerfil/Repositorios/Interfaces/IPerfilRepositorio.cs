using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;

namespace Negocios.ModuloPerfil.Repositorios
{
    /// <summary>
    /// Summary description for IPerfilRepositorio
    /// </summary>
    public interface IPerfilRepositorio
    {
        /// <summary>
        /// M�todo respons�vel por incluir um perfil no sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser incluido.</param>
        void Incluir(Perfil perfil);

        /// <summary>
        /// M�todo respons�vel por excluir um perfil do sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser excluido.</param>
        void Excluir(Perfil perfil);

        /// <summary>
        /// M�todo repons�vel por alterar um perfil do sistema.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil a ser alterado.</param>
        void Alterar(Perfil perfil);

        /// <summary>
        /// M�todo respons�vel por consultar perfis do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="perfil">Objeto do tipo perfil que ir� ser utilizado como parametro de pesquisa.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Perfil> Consultar(Perfil perfil);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os perfils cadastrados.</returns>
        List<Perfil> Consultar();
		
		/// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
		void Confirmar();
    }
}