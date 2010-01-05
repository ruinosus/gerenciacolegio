using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloProfessorDisciplinaSala.Excecoes;

namespace Negocios.ModuloProfessorDisciplinaSala.Repositorios
{
    public class ProfessorDisciplinaSalaRepositorio : IProfessorDisciplinaSalaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<ProfessorDisciplinaSala> Consultar()
        {
            return db.ProfessorDisciplinaSala.ToList();
        }

        public List<ProfessorDisciplinaSala> Consultar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            // return db.ProfessorDisciplinaSalas.SingleOrDefault(d => d.Id == id);
            return db.ProfessorDisciplinaSala.ToList();
        }

        public void Incluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                db.ProfessorDisciplinaSala.InsertOnSubmit(professorDisciplinaSala);
            }
            catch (Exception)
            {
                
                throw new ProfessorDisciplinaSalaNaoIncluidaExcecao();
            }
        }

        public void Excluir(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                db.ProfessorDisciplinaSala.DeleteOnSubmit(professorDisciplinaSala);
            }
            catch (Exception)
            {
                
              throw new ProfessorDisciplinaSalaNaoExcluidaExcecao();
            }
        }

        public void Alterar(ProfessorDisciplinaSala professorDisciplinaSala)
        {
            try
            {
                db.ProfessorDisciplinaSala.InsertOnSubmit(professorDisciplinaSala);
            }
            catch (Exception)
            {
                
                 throw new ProfessorDisciplinaSalaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion



    }
}