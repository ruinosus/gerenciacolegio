using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloResponsavelAluno.Repositorios;
using Negocios.ModuloResponsavelAluno.Processos;
using Negocios.ModuloResponsavelAluno.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloResponsavelAluno.Excecoes;

namespace Negocios.ModuloResponsavelAluno.Processos
{
    /// <summary>
    /// Classe ResponsavelAlunoProcesso
    /// </summary>
    public class ResponsavelAlunoProcesso : Singleton<ResponsavelAlunoProcesso>, IResponsavelAlunoProcesso
    {
        #region Atributos
        private IResponsavelAlunoRepositorio responsavelAlunoRepositorio = null;
        #endregion

        #region Construtor
        public ResponsavelAlunoProcesso()
        {
            responsavelAlunoRepositorio = ResponsavelAlunoFabrica.IResponsavelAlunoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ResponsavelAluno responsavelAluno)
        {
            this.responsavelAlunoRepositorio.Incluir(responsavelAluno);

        }

        public void Excluir(ResponsavelAluno responsavelAluno)
        {

            try
            {
                if (responsavelAluno.ID == 0)
                    throw new ResponsavelAlunoNaoExcluidoExcecao();

                List<ResponsavelAluno> resultado = responsavelAlunoRepositorio.Consultar(responsavelAluno, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new ResponsavelAlunoNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);

            }
            catch (Exception e)
            {

                throw e;
            }
            //this.responsavelAlunoRepositorio.Excluir(responsavelAluno);
        }

        public void Alterar(ResponsavelAluno responsavelAluno)
        {
            this.responsavelAlunoRepositorio.Alterar(responsavelAluno);
        }

        public List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno, TipoPesquisa tipoPesquisa)
        {
            List<ResponsavelAluno> responsavelAlunoList = this.responsavelAlunoRepositorio.Consultar(responsavelAluno,tipoPesquisa);           

            return responsavelAlunoList;
        }

        public List<ResponsavelAluno> Consultar()
        {
            List<ResponsavelAluno> responsavelAlunoList = this.responsavelAlunoRepositorio.Consultar();

            return responsavelAlunoList;
        }

        public void Confirmar()
        {
            this.responsavelAlunoRepositorio.Confirmar();
        }

        #endregion
    }
}