using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloTurno.Excecoes;

namespace Negocios.ModuloTurno.Repositorios
{
    public class TurnoRepositorio : ITurnoRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Turno> Consultar()
        {
            return db.Turno.ToList();
        }

        public List<Turno> Consultar(Turno turno)
        {
            // return db.Turnos.SingleOrDefault(d => d.Id == id);
            return db.Turno.ToList();
        }

        public void Incluir(Turno turno)
        {
            try
            {
                db.Turno.InsertOnSubmit(turno);
            }
            catch (Exception)
            {
                
                throw new TurnoNaoIncluidoExcecao();
            }
        }

        public void Excluir(Turno turno)
        {
            try
            {
                db.Turno.DeleteOnSubmit(turno);
            }
            catch (Exception)
            {
                
              throw new TurnoNaoExcluidoExcecao();
            }
        }

        public void Alterar(Turno turno)
        {
            try
            {
                db.Turno.InsertOnSubmit(turno);
            }
            catch (Exception)
            {
                
                throw new TurnoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}