using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDesconto.Excecoes;

namespace Negocios.ModuloDesconto.Repositorios
{
    public class DescontoRepositorio: IDescontoRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Desconto> Consultar()
        {
            return db.Desconto.ToList();
        }

        public List<Desconto> Consultar(Desconto desconto)
        {
           // return db.Descontos.SingleOrDefault(d => d.Id == id);
			return db.Desconto.ToList();
        }

        public void Incluir(Desconto desconto)
        {
            try
            {
                db.Desconto.InsertOnSubmit(desconto);
            }
            catch (Exception)
            {
                
                throw new DescontoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Desconto desconto)
        {
            try
            {
                db.Desconto.DeleteOnSubmit(desconto);
            }
            catch (Exception)
            {
                
                throw new DescontoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Desconto desconto)
        {
            try
            {
                db.Desconto.InsertOnSubmit(desconto);
            }
            catch (Exception)
            {
                
                throw new DescontoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}