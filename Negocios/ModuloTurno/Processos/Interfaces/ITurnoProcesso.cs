using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloTurno.Processos
{
    /// <summary>
    /// Summary description for ITurnoRepositorio
    /// </summary>
    public interface ITurnoProcesso
    {
        /// <summary>
        /// M�todo respons�vel por incluir um turno no sistema.
        /// </summary>
        /// <param name="turno">Objeto do tipo turno a ser incluido.</param>
        void Incluir(Turno turno);

        /// <summary>
        /// M�todo respons�vel por excluir um turno do sistema.
        /// </summary>
        /// <param name="turno">Objeto do tipo turno a ser excluido.</param>
        void Excluir(Turno turno);

        /// <summary>
        /// M�todo repons�vel por alterar um turno do sistema.
        /// </summary>
        /// <param name="turno">Objeto do tipo turno a ser alterado.</param>
        void Alterar(Turno turno);

        /// <summary>
        /// M�todo respons�vel por consultar turnos do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="turno">Objeto do tipo turno que ir� ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todos os perfis cadastrados.</returns>
        List<Turno> Consultar(Turno turno, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// M�todo respons�vel por consultar todos os coment�rios do sistema.
        /// </summary>
        /// <returns>Lista contendo todos os turnos cadastrados.</returns>
        List<Turno> Consultar();

        /// <summary>
        /// M�todo respons�vel por confirmar as altera��es no sistema.
        /// </summary>       
        void Confirmar();
    }
}