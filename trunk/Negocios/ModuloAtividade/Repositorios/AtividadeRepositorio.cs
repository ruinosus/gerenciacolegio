using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAtividade.Excecoes;

namespace Negocios.ModuloAtividade.Repositorios
{
    public class AtividadeRepositorio: IAtividadeRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Atividade> Consultar()
        {
            return db.Atividade.ToList();
        }

        public List<Atividade> Consultar(Atividade atividade)
        {
           // return db.Atividades.SingleOrDefault(d => d.Id == id);
			return db.Atividade.ToList();
        }

        public void Incluir(Atividade atividade)
        {
            try
            {
                db.Atividade.InsertOnSubmit(atividade);
            }
            catch (Exception)
            {
                
                throw new AtividadeNaoIncluidaExcecao();
            }
        }

        public void Excluir(Atividade atividade)
        {
            try
            {
                db.Atividade.DeleteOnSubmit(atividade);
            }
            catch (Exception)
            {
                throw new AtividadeNaoExcluidaExcecao();
            }
        }

        public void Alterar(Atividade atividade)
        {
            try
            {
                db.Atividade.InsertOnSubmit(atividade);
            }
            catch (Exception)
            {
                
                 throw new AtividadeNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}