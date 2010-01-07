using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloProfessorDisciplinaSala.Processos
{
    /// <summary>
    /// Interface IProfessorDisciplinaSalaRepositorio
    /// </summary>
    public interface IProfessorDisciplinaSalaProcesso
    {
        /// <summary>
        /// Método responsável por incluir uma professorDisciplinaSala no sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser incluido.</param>
        void Incluir(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// Método responsável por excluir uma professorDisciplinaSala do sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser excluido.</param>
        void Excluir(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// Método reponsável por alterar uma professorDisciplinaSala do sistema.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala a ser alterado.</param>
        void Alterar(ProfessorDisciplinaSala professorDisciplinaSala);

        /// <summary>
        /// Método responsável por consultar professorDisciplinaSalas do sistema de acordo com os parametros informados.
        /// </summary>
        /// <param name="professorDisciplinaSala">Objeto do tipo professorDisciplinaSala que irá ser utilizado como parametro de pesquisa.</param>
        /// <param name="tipoPesquisa">Tipo de pesquisa a ser utilizada.</param>
        /// <returns>Lista contendo todas as professorDisciplinaSalas cadastradas.</returns>
        List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala, TipoPesquisa tipoPesquisa);

        /// <summary>
        /// Método responsável por consultar todas as professorDisciplinaSalas do sistema.
        /// </summary>
        /// <returns>Lista contendo todas as professorDisciplinaSalas cadastradas.</returns>
        List<ProfessorDisciplinaSala> Consultar();

        /// <summary>
        /// Método responsável por confirmar as alterações no sistema.
        /// </summary>       
        void Confirmar();
    }
}