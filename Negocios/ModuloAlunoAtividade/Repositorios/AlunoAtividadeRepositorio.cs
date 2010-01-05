using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAlunoAtividade.Excecoes;

namespace Negocios.ModuloAlunoAtividade.Repositorios
{
    public class AlunoAtividadeRepositorio: IAlunoAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<AlunoAtividade> Consultar()
        {
            return db.AlunoAtividade.ToList();
        }

        public List<AlunoAtividade> Consultar(AlunoAtividade alunoAtividade)
        {
           // return db.AlunoAtividades.SingleOrDefault(d => d.Id == id);
			return db.AlunoAtividade.ToList();
        }

        public void Incluir(AlunoAtividade alunoAtividade)
        {
            try
            {
                db.AlunoAtividade.InsertOnSubmit(alunoAtividade);
            }
            catch (Exception)
            {
                
                throw new AlunoAtividadeNaoIncluidoExcecao();
            }
        }

        public void Excluir(AlunoAtividade alunoAtividade)
        {
            try
            {
                db.AlunoAtividade.DeleteOnSubmit(alunoAtividade);
            }
            catch (Exception)
            {
                
                  throw new AlunoAtividadeNaoExcluidoExcecao();
            }
        }

        public void Alterar(AlunoAtividade alunoAtividade)
        {
            try
            {
                db.AlunoAtividade.InsertOnSubmit(alunoAtividade);
            }
            catch (Exception)
            {
                
                 throw new AlunoAtividadeNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}