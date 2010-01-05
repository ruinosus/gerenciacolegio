using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloCheque.Excecoes;

namespace Negocios.ModuloCheque.Repositorios
{
    public class ChequeRepositorio: IChequeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Cheque> Consultar()
        {
            return db.Cheque.ToList();
        }

        public List<Cheque> Consultar(Cheque cheque)
        {
           // return db.Cheques.SingleOrDefault(d => d.Id == id);
			return db.Cheque.ToList();
        }

        public void Incluir(Cheque cheque)         
        {
            try
            {
                db.Cheque.InsertOnSubmit(cheque);
            }
            catch (Exception)
            {
                
                throw new ChequeNaoIncluidoExcecao();
            }
        }

        public void Excluir(Cheque cheque)
        {
            try
            {
                db.Cheque.DeleteOnSubmit(cheque);
            }
            catch (Exception)
            {
                
                 throw new ChequeNaoExcluidoExcecao();
            }
        }

        public void Alterar(Cheque cheque)
        {
            try
            {
                db.Cheque.InsertOnSubmit(cheque);
            }
            catch (Exception)
            {
                
                throw new ChequeNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}