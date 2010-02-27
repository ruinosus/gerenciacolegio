using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloAlunoAtividadeTurma.Repositorios;
using Negocios.ModuloAlunoAtividadeTurma.Processos;
using Negocios.ModuloAlunoAtividadeTurma.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloAlunoAtividadeTurma.Excecoes;

namespace Negocios.ModuloAlunoAtividadeTurma.Processos
{
    /// <summary>
    /// Classe AlunoAtividadeTurmaProcesso
    /// </summary>
    public class AlunoAtividadeTurmaProcesso : Singleton<AlunoAtividadeTurmaProcesso>, IAlunoAtividadeTurmaProcesso
    {
        #region Atributos
        private IAlunoAtividadeTurmaRepositorio alunoAtividadeTurmaRepositorio = null;
        #endregion

        #region Construtor
        public AlunoAtividadeTurmaProcesso()
        {
            alunoAtividadeTurmaRepositorio = AlunoAtividadeTurmaFabrica.IAlunoAtividadeTurmaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(AlunoAtividadeTurma alunoAtividadeTurma)
        {
            this.alunoAtividadeTurmaRepositorio.Incluir(alunoAtividadeTurma);

        }

        public void Excluir(AlunoAtividadeTurma alunoAtividadeTurma)
        {

            try
            {
                if (alunoAtividadeTurma.ID == 0)
                    throw new AlunoAtividadeTurmaNaoExcluidoExcecao();

                List<AlunoAtividadeTurma> resultado = alunoAtividadeTurmaRepositorio.Consultar(alunoAtividadeTurma,TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new AlunoAtividadeTurmaNaoExcluidoExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);

            }
            catch (Exception e)
            {

                throw e;
            }
            
            //this.alunoAtividadeTurmaRepositorio.Excluir(alunoAtividadeTurma);
        }

        public void Alterar(AlunoAtividadeTurma alunoAtividadeTurma)
        {
            this.alunoAtividadeTurmaRepositorio.Alterar(alunoAtividadeTurma);
        }

        public List<AlunoAtividadeTurma> Consultar(AlunoAtividadeTurma alunoAtividadeTurma, TipoPesquisa tipoPesquisa)
        {
            List<AlunoAtividadeTurma> alunoAtividadeTurmaList = this.alunoAtividadeTurmaRepositorio.Consultar(alunoAtividadeTurma,tipoPesquisa);           

            return alunoAtividadeTurmaList;
        }

        public List<AlunoAtividadeTurma> Consultar()
        {
            List<AlunoAtividadeTurma> alunoAtividadeTurmaList = alunoAtividadeTurmaRepositorio.Consultar();

            return alunoAtividadeTurmaList;
        }

        public void Confirmar()
        {
            alunoAtividadeTurmaRepositorio.Confirmar();
        }

        #endregion
    }
}