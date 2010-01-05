using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloAtividadeData.Excecoes;

namespace Negocios.ModuloAtividadeData.Repositorios
{
    public class AtividadeDataRepositorio: IAtividadeDataRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<AtividadeData> Consultar()
        {
            return db.AtividadeData.ToList();
        }

        public List<AtividadeData> Consultar(AtividadeData atividadeData)
        {
           // return db.AtividadeDatas.SingleOrDefault(d => d.Id == id);
			return db.AtividadeData.ToList();
        }

        public void Incluir(AtividadeData atividadeData)         
        {
            try
            {
                db.AtividadeData.InsertOnSubmit(atividadeData);
            }
            catch (Exception)
            {
                
                throw new AtividadeDataNaoIncluidaExcecao();
            }
        }

        public void Excluir(AtividadeData atividadeData)
        {
            try
            {
                db.AtividadeData.DeleteOnSubmit(atividadeData);
            }
            catch (Exception)
            {
                
                 throw new AtividadeDataNaoExcluidaExcecao();
            }
        }

        public void Alterar(AtividadeData atividadeData)
        {
            try
            {
                db.AtividadeData.InsertOnSubmit(atividadeData);
            }
            catch (Exception)
            {
                
                 throw new AtividadeDataNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    
    }
}