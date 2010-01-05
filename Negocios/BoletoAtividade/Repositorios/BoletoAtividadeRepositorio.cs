using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloBoletoAtividade.Excecoes;

namespace Negocios.ModuloBoletoAtividade.Repositorios
{
    public class BoletoAtividadeRepositorio: IBoletoAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<BoletoAtividade> Consultar()
        {
            return db.BoletoAtividade.ToList();
        }

        public List<BoletoAtividade> Consultar(BoletoAtividade boletoAtividade)
        {
           // return db.BoletoAtividades.SingleOrDefault(d => d.Id == id);
			return db.BoletoAtividade.ToList();
        }

        public void Incluir(BoletoAtividade boletoAtividade)         
        {
            try
            {
                db.BoletoAtividade.InsertOnSubmit(boletoAtividade);
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(BoletoAtividade boletoAtividade)
        {
            try
            {
                db.BoletoAtividade.DeleteOnSubmit(boletoAtividade);
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(BoletoAtividade boletoAtividade)
        {
            try
            {
                db.BoletoAtividade.InsertOnSubmit(boletoAtividade);
            }
            catch (Exception)
            {
                
                throw new BoletoAtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}