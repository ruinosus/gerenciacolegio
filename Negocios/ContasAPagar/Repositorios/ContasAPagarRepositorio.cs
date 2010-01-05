using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloContasAPagar.Excecoes;

namespace Negocios.ModuloContasAPagar.Repositorios
{
    public class ContasAPagarRepositorio: IContasAPagarRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<ContasAPagar> Consultar()
        {
            return db.ContasAPagar.ToList();
        }

        public List<ContasAPagar> Consultar(ContasAPagar contasAPagar)
        {
           // return db.ContasAPagars.SingleOrDefault(d => d.Id == id);
			return db.ContasAPagar.ToList();
        }

        public void Incluir(ContasAPagar contasAPagar)
        {
            try
            {
                db.ContasAPagar.InsertOnSubmit(contasAPagar);
            }
            catch (Exception)
            {
                
                throw new ContasAPagarNaoIncluidaExcecao();
            }
        }

        public void Excluir(ContasAPagar contasAPagar)
        {
            try
            {
                db.ContasAPagar.DeleteOnSubmit(contasAPagar);
            }
            catch (Exception)
            {
                
               throw new ContasAPagarNaoExcluidaExcecao();
            }
        }

        public void Alterar(ContasAPagar contasAPagar)
        {
            try
            {
                db.ContasAPagar.InsertOnSubmit(contasAPagar);
            }
            catch (Exception)
            {
                
            throw new ContasAPagarNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}