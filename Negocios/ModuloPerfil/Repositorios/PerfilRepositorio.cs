using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloPerfil.Excecoes;

namespace Negocios.ModuloPerfil.Repositorios
{
    public class PerfilRepositorio: IPerfilRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Perfil> Consultar()
        {
            return db.Perfil.ToList();
        }

        public List<Perfil> Consultar(Perfil perfil)
        {
           // return db.Perfils.SingleOrDefault(d => d.Id == id);
			return db.Perfil.ToList();
        }

        public void Incluir(Perfil perfil)
        {
            try
            {
                db.Perfil.InsertOnSubmit(perfil);
            }
            catch (Exception)
            {
                
                throw new PerfilNaoIncluidoExcecao();
            }
        }

        public void Excluir(Perfil perfil)
        {
            try
            {
                db.Perfil.DeleteOnSubmit(perfil);
            }
            catch (Exception)
            {
                
               throw new PerfilNaoExcluidoExcecao();
            }
        }

        public void Alterar(Perfil perfil)
        {
            try
            {
                db.Perfil.InsertOnSubmit(perfil);
            }
            catch (Exception)
            {
                
               throw new PerfilNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}