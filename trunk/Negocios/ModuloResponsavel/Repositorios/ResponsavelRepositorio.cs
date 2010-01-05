using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavel.Excecoes;

namespace Negocios.ModuloResponsavel.Repositorios
{
    public class ResponsavelRepositorio : IResponsavelRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<Responsavel> Consultar()
        {
            return db.Responsavel.ToList();
        }

        public List<Responsavel> Consultar(Responsavel responsavel)
        {
            // return db.Responsavels.SingleOrDefault(d => d.Id == id);
            return db.Responsavel.ToList();
        }

        public void Incluir(Responsavel responsavel)
        {
            try
            {
                db.Responsavel.InsertOnSubmit(responsavel);
            }
            catch (Exception)
            {

                throw new ResponsavelNaoIncluidoExcecao();
            }
        }

        public void Excluir(Responsavel responsavel)
        {
            try
            {
                db.Responsavel.DeleteOnSubmit(responsavel);
            }
            catch (Exception)
            {

                throw new ResponsavelNaoExcluidoExcecao();
            }
        }

        public void Alterar(Responsavel responsavel)
        {
            try
            {
                db.Responsavel.InsertOnSubmit(responsavel);
            }
            catch (Exception)
            {

                throw new ResponsavelNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion


    }
}