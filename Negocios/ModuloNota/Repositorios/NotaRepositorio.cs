using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloNota.Excecoes;

namespace Negocios.ModuloNota.Repositorios
{
    public class NotaRepositorio: INotaRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Nota> Consultar()
        {
            return db.Nota.ToList();
        }

        public List<Nota> Consultar(Nota nota)
        {
           // return db.Notas.SingleOrDefault(d => d.Id == id);
			return db.Nota.ToList();
        }

        public void Incluir(Nota nota)
        {
            try
            {
                db.Nota.InsertOnSubmit(nota);
            }
            catch (Exception)
            {
                
                throw new NotaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Nota nota)
        {
            try
            {
                db.Nota.DeleteOnSubmit(nota);
            }
            catch (Exception)
            {
                
                 throw new NotaNaoExcluidaExcecao();
            }
        }

        public void Alterar(Nota nota)
        {
            try
            {
                db.Nota.InsertOnSubmit(nota);
            }
            catch (Exception)
            {
                
                  throw new NotaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}