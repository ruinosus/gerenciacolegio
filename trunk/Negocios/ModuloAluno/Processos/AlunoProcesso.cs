using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloAluno.Repositorios;
using Negocios.ModuloAluno.Processos;
using Negocios.ModuloAluno.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAluno.Excecoes;

namespace Negocios.ModuloAluno.Processos
{
    /// <summary>
    /// Classe AlunoProcesso
    /// </summary>
    public class AlunoProcesso : Singleton<AlunoProcesso>, IAlunoProcesso
    {
        #region Atributos
        private IAlunoRepositorio alunoRepositorio = null;
        #endregion

        #region Construtor
        public AlunoProcesso()
        {
            alunoRepositorio = AlunoFabrica.IAlunoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Aluno aluno)
        {
            try
            {
                this.alunoRepositorio.Incluir(aluno);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Aluno aluno)
        {
            try
            {
                if (aluno.ID == 0)
                    throw new AlunoNaoExcluidoExcecao();

                List<Aluno> resultado = alunoRepositorio.Consultar(aluno,TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new AlunoNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.alunoRepositorio.Excluir(aluno);
        }

        public void Alterar(Aluno aluno)
        {
            this.alunoRepositorio.Alterar(aluno);
        }

        public List<Aluno> Consultar(Aluno aluno, TipoPesquisa tipoPesquisa)
        {
            List<Aluno> alunoList = this.alunoRepositorio.Consultar(aluno, tipoPesquisa);

            return alunoList;
        }

        public List<Aluno> Consultar()
        {
            List<Aluno> alunoList = alunoRepositorio.Consultar();

            return alunoList;
        }

        public void Confirmar()
        {
            alunoRepositorio.Confirmar();
        }

        #endregion
    }
}