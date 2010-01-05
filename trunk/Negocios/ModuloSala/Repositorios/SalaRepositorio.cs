using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloSala.Excecoes;

namespace Negocios.ModuloSala.Repositorios
{
    public class SalaRepositorio : ISalaRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Sala> Consultar()
        {
            return db.Sala.ToList();
        }

        public List<Sala> Consultar(Sala sala)
        {
            // return db.Salas.SingleOrDefault(d => d.Id == id);
            return db.Sala.ToList();
        }

        public void Incluir(Sala sala)
        {
            try
            {
                db.Sala.InsertOnSubmit(sala);
            }
            catch (Exception)
            {
                
                throw new SalaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Sala sala)
        {
            try
            {
                db.Sala.DeleteOnSubmit(sala);
            }
            catch (Exception)
            {
                
                throw new SalaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Sala sala)
        {
            try
            {
                db.Sala.InsertOnSubmit(sala);
            }
            catch (Exception)
            {
                
               throw new SalaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}