using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using MySql.Data.MySqlClient;
using Negocios.ModuloResponsavelAluno.Excecoes;

namespace Negocios.ModuloResponsavelAluno.Repositorios
{
    public class ResponsavelAlunoRepositorio : IResponsavelAlunoRepositorio
    {
        #region Atributos

        ColegioDB db = new ColegioDB(new MySqlConnection(BasicoConstantes.CONEXAO));

        #endregion

        #region Métodos da Interface

        public List<ResponsavelAluno> Consultar()
        {
            return db.ResponsavelAluno.ToList();
        }

        public List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno)
        {
            // return db.ResponsavelAlunos.SingleOrDefault(d => d.Id == id);
            return db.ResponsavelAluno.ToList();
        }

        public void Incluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                db.ResponsavelAluno.InsertOnSubmit(responsavelAluno);
            }
            catch (Exception)
            {
                
                throw new ResponsavelAlunoNaoIncluidoExcecao();
            }
        }

        public void Excluir(ResponsavelAluno responsavelAluno)
        {
            try
            {
                db.ResponsavelAluno.DeleteOnSubmit(responsavelAluno);
            }
            catch (Exception)
            {
                
               throw new ResponsavelAlunoNaoExcluidoExcecao();
            }
        }

        public void Alterar(ResponsavelAluno responsavelAluno)
        {
            try
            {
                db.ResponsavelAluno.InsertOnSubmit(responsavelAluno);
            }
            catch (Exception)
            {
                
                 throw new ResponsavelAlunoNaoAlteradoExcecao();
            }
        }

        public void Confirmar()
        {
            db.SubmitChanges();
        }

        #endregion




    }
}