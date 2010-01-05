using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloChequeBoletoMensalidade.Excecoes;

namespace Negocios.ModuloChequeBoletoMensalidade.Repositorios
{
    public class ChequeBoletoMensalidadeRepositorio: IChequeBoletoMensalidadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<ChequeBoletoMensalidade> Consultar()
        {
            return db.ChequeBoletoMensalidade.ToList();
        }

        public List<ChequeBoletoMensalidade> Consultar(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
           // return db.ChequeBoletoMensalidades.SingleOrDefault(d => d.Id == id);
			return db.ChequeBoletoMensalidade.ToList();
        }

        public void Incluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                db.ChequeBoletoMensalidade.InsertOnSubmit(chequeBoletoMensalidade);
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoMensalidadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                db.ChequeBoletoMensalidade.DeleteOnSubmit(chequeBoletoMensalidade);
            }
            catch (Exception)
            {
                throw new ChequeBoletoMensalidadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(ChequeBoletoMensalidade chequeBoletoMensalidade)
        {
            try
            {
                db.ChequeBoletoMensalidade.InsertOnSubmit(chequeBoletoMensalidade);
            }
            catch (Exception)
            {
                
                throw new ChequeBoletoMensalidadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}