using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloDependencia.Excecoes;

namespace Negocios.ModuloDependencia.Repositorios
{
    public class DependenciaRepositorio: IDependenciaRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Dependencia> Consultar()
        {
            return db.Dependencia.ToList();
        }

        public List<Dependencia> Consultar(Dependencia dependencia)
        {
           // return db.Dependencias.SingleOrDefault(d => d.Id == id);
			return db.Dependencia.ToList();
        }

        public void Incluir(Dependencia dependencia)
        {
            try
            {
                db.Dependencia.InsertOnSubmit(dependencia);
            }
            catch (Exception)
            {
                
                throw new DependenciaNaoIncluidaExcecao();
            }
        }

        public void Excluir(Dependencia dependencia)
        {
            try
            {
                db.Dependencia.DeleteOnSubmit(dependencia);
            }
            catch (Exception)
            {
                
                throw new DependenciaNaoAlteradaExcecao();
            }
        }

        public void Alterar(Dependencia dependencia)
        {
            try
            {
                db.Dependencia.InsertOnSubmit(dependencia);
            }
            catch (Exception)
            {
                
                throw new DependenciaNaoAlteradaExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}