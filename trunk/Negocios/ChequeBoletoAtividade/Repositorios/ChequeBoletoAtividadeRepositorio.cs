using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloChequeBoletoAtividade.Excecoes;

namespace Negocios.ModuloChequeBoletoAtividade.Repositorios
{
    public class ChequeBoletoAtividadeRepositorio: IChequeBoletoAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<ChequeBoletoAtividade> Consultar()
        {
            return db.ChequeBoletoAtividade.ToList();
        }

        public List<ChequeBoletoAtividade> Consultar(ChequeBoletoAtividade chequeBoletoAtividade)
        {
           // return db.ChequeBoletoAtividades.SingleOrDefault(d => d.Id == id);
			return db.ChequeBoletoAtividade.ToList();
        }

        public void Incluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                db.ChequeBoletoAtividade.InsertOnSubmit(chequeBoletoAtividade);
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoAtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                db.ChequeBoletoAtividade.DeleteOnSubmit(chequeBoletoAtividade);
            }
            catch (Exception)
            {
                
                  throw new ChequeBoletoAtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(ChequeBoletoAtividade chequeBoletoAtividade)
        {
            try
            {
                db.ChequeBoletoAtividade.InsertOnSubmit(chequeBoletoAtividade);
            }
            catch (Exception)
            {
                
                  throw new ChequeBoletoAtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}