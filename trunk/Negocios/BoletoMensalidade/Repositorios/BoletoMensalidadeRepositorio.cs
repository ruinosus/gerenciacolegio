using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloBoletoMensalidade.Excecoes;

namespace Negocios.ModuloBoletoMensalidade.Repositorios
{
    public class BoletoMensalidadeRepositorio: IBoletoMensalidadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<BoletoMensalidade> Consultar()
        {
            return db.BoletoMensalidade.ToList();
        }

        public List<BoletoMensalidade> Consultar(BoletoMensalidade boletoMensalidade)
        {
           // return db.BoletoMensalidades.SingleOrDefault(d => d.Id == id);
			return db.BoletoMensalidade.ToList();
        }

        public void Incluir(BoletoMensalidade boletoMensalidade)         
        {
            try
            {
                db.BoletoMensalidade.InsertOnSubmit(boletoMensalidade);
            }
            catch (Exception)
            {

                throw new BoletoMensalidadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(BoletoMensalidade boletoMensalidade)
        {
            try
            {
                db.BoletoMensalidade.DeleteOnSubmit(boletoMensalidade);
            }
            catch (Exception)
            {
                
                 throw new BoletoMensalidadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(BoletoMensalidade boletoMensalidade)
        {
            try
            {
                db.BoletoMensalidade.InsertOnSubmit(boletoMensalidade);
            }
            catch (Exception)
            {
                
                  throw new BoletoMensalidadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}