using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAluno.Repositorios;
using Negocios.ModuloAluno.Processos;
using Negocios.ModuloAluno.Fabricas;

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
            this.alunoRepositorio.Incluir(aluno);

        }

        public void Excluir(Aluno aluno)
        {
            this.alunoRepositorio.Excluir(aluno);
        }

        public void Alterar(Aluno aluno)
        {
            this.alunoRepositorio.Alterar(aluno);
        }

        public List<Aluno> Consultar(Aluno aluno)
        {
            List<Aluno> alunoList = this.alunoRepositorio.Consultar(aluno);           

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