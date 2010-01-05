using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAluno.Excecoes;

namespace Negocios.ModuloAluno.Repositorios
{
    public class AlunoRepositorio: IAlunoRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Aluno> Consultar()
        {
            return db.Aluno.ToList();
        }

        public List<Aluno> Consultar(Aluno aluno)
        {
           // return db.Alunos.SingleOrDefault(d => d.Id == id);
			return db.Aluno.ToList();
        }

        public void Incluir(Aluno aluno)
        {
            try
            {
                db.Aluno.InsertOnSubmit(aluno);
            }
            catch (Exception)
            {
                
                throw new AlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Aluno aluno)
        {
            try
            {
                db.Aluno.DeleteOnSubmit(aluno);
            }
            catch (Exception)
            {
                
               throw new AlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Aluno aluno)
        {
            try
            {
                db.Aluno.InsertOnSubmit(aluno);
            }
            catch (Exception)
            {
                
               throw new AlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}