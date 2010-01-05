using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloMatricula.Excecoes;

namespace Negocios.ModuloMatricula.Repositorios
{
    public class MatriculaRepositorio: IMatriculaRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Matricula> Consultar()
        {
            return db.Matricula.ToList();
        }

        public List<Matricula> Consultar(Matricula matricula)
        {
           // return db.Matriculas.SingleOrDefault(d => d.Id == id);
			return db.Matricula.ToList();
        }

        public void Incluir(Matricula matricula)
        {
            try
            {
                db.Matricula.InsertOnSubmit(matricula);
            }
            catch (Exception)
            {
                
                throw new MatriculaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Matricula matricula)
        {
            try
            {
                db.Matricula.DeleteOnSubmit(matricula);
            }
            catch (Exception)
            {
                
                 throw new MatriculaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Matricula matricula)
        {
            try
            {
                db.Matricula.InsertOnSubmit(matricula);
            }
            catch (Exception)
            {
                
                  throw new MatriculaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}