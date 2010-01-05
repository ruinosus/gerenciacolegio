using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDisciplina.Excecoes;

namespace Negocios.ModuloDisciplina.Repositorios
{
    public class DisciplinaRepositorio: IDisciplinaRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Disciplina> Consultar()
        {
            return db.Disciplina.ToList();
        }

        public List<Disciplina> Consultar(Disciplina disciplina)
        {
           // return db.Disciplinas.SingleOrDefault(d => d.Id == id);
			return db.Disciplina.ToList();
        }

        public void Incluir(Disciplina disciplina)
        {
            try
            {
                db.Disciplina.InsertOnSubmit(disciplina);
            }
            catch (Exception)
            {
                
                throw new DisciplinaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Disciplina disciplina)
        {
            try
            {
                db.Disciplina.DeleteOnSubmit(disciplina);
            }
            catch (Exception)
            {
                
                  throw new DisciplinaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Disciplina disciplina)
        {
            try
            {
                db.Disciplina.InsertOnSubmit(disciplina);
            }
            catch (Exception)
            {
                  throw new DisciplinaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}