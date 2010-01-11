using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAlunoAtividadeTurma.Repositorios;
using Negocios.ModuloAlunoAtividadeTurma.Processos;
using Negocios.ModuloAlunoAtividadeTurma.Fabricas;
using Negocios.ModuloBasico.Enums;

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
            this.alunoAtividadeTurmaRepositorio.Excluir(alunoAtividadeTurma);
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