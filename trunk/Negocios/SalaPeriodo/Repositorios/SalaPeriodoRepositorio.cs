using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSalaPeriodo.Excecoes;

namespace Negocios.ModuloSalaPeriodo.Repositorios
{
    public class SalaPeriodoRepositorio : ISalaPeriodoRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<SalaPeriodo> Consultar()
        {
            return db.SalaPeriodo.ToList();
        }

        public List<SalaPeriodo> Consultar(SalaPeriodo salaPeriodo)
        {
            // return db.SalaPeriodos.SingleOrDefault(d => d.Id == id);
            return db.SalaPeriodo.ToList();
        }

        public void Incluir(SalaPeriodo salaPeriodo)
        {
            try
            {
                db.SalaPeriodo.InsertOnSubmit(salaPeriodo);
            }
            catch (Exception)
            {
                
                throw new SalaPeriodoNaoIncluidaExcecao();
            }
        }

        public void Excluir(SalaPeriodo salaPeriodo)
        {
            try
            {
                db.SalaPeriodo.DeleteOnSubmit(salaPeriodo);
            }
            catch (Exception)
            {
                
             throw new SalaPeriodoNaoExcluidaExcecao();
            }
        }

        public void Alterar(SalaPeriodo salaPeriodo)
        {
            try
            {
                db.SalaPeriodo.InsertOnSubmit(salaPeriodo);
            }
            catch (Exception)
            {
                
               throw new SalaPeriodoNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion



    }
}