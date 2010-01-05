using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloTurma.Excecoes;

namespace Negocios.ModuloTurma.Repositorios
{
    public class TurmaRepositorio : ITurmaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Turma> Consultar()
        {
            return db.Turma.ToList();
        }

        public List<Turma> Consultar(Turma turma)
        {
            // return db.Turmas.SingleOrDefault(d => d.Id == id);
            return db.Turma.ToList();
        }

        public void Incluir(Turma turma)
        {
            try
            {
                db.Turma.InsertOnSubmit(turma);
            }
            catch (Exception)
            {

                throw new TurmaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Turma turma)
        {
            try
            {
                db.Turma.DeleteOnSubmit(turma);
            }
            catch (Exception)
            {

                throw new TurmaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Turma turma)
        {
            try
            {
                db.Turma.InsertOnSubmit(turma);
            }
            catch (Exception)
            {

                throw new TurmaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}