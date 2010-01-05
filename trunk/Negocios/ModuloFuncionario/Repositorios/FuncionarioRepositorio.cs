using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloFuncionario.Excecoes;

namespace Negocios.ModuloFuncionario.Repositorios
{
    public class FuncionarioRepositorio: IFuncionarioRepositorio
    {
		#region Atributos
		
        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));
		
		#endregion      
		
        #region Métodos da Interface

        public List<Funcionario> Consultar()
        {
            return db.Funcionario.ToList();
        }

        public List<Funcionario> Consultar(Funcionario funcionario)
        {
           // return db.Funcionarios.SingleOrDefault(d => d.Id == id);
			return db.Funcionario.ToList();
        }

        public void Incluir(Funcionario funcionario)
        {
            try
            {
                db.Funcionario.InsertOnSubmit(funcionario);
            }
            catch (Exception)
            {
                
                throw new FuncionarioNaoIncluidoExcecao();
            }
        }

        public void Excluir(Funcionario funcionario)
        {
            try
            {
                db.Funcionario.DeleteOnSubmit(funcionario);
            }
            catch (Exception)
            {
                
             throw new FuncionarioNaoExcluidoExcecao();
            }
        }

        public void Alterar(Funcionario funcionario)
        {
            try
            {
                db.Funcionario.InsertOnSubmit(funcionario);
            }
            catch (Exception)
            {
                
               throw new FuncionarioNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion      


    }
}