
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloTurma.Repositorios;
using Negocios.ModuloTurma.Processos;
using Negocios.ModuloTurma.Fabricas;
namespace Negocios.ModuloTurma.Processos
{
    /// <summary>
    /// Classe TurmaProcesso
    /// </summary>
    public class TurmaProcesso : Singleton<TurmaProcesso>, ITurmaProcesso
    {
        #region Atributos
        private ITurmaRepositorio turmaRepositorio = null;
        #endregion

        #region Construtor
        public TurmaProcesso()
        {
            turmaRepositorio = TurmaFabrica.ITurmaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Turma turma)
        {
            this.turmaRepositorio.Incluir(turma);

        }

        public void Excluir(Turma turma)
        {
            this.turmaRepositorio.Excluir(turma);
        }

        public void Alterar(Turma turma)
        {
            this.turmaRepositorio.Alterar(turma);
        }

        public List<Turma> Consultar(Turma turma)
        {
            List<Turma> turmaList = this.turmaRepositorio.Consultar(turma);           

            return turmaList;
        }

        public List<Turma> Consultar()
        {
            List<Turma> turmaList = this.turmaRepositorio.Consultar();

            return turmaList;
        }

        public void Confirmar()
        {
            this.turmaRepositorio.Confirmar();
        }

        #endregion
    }
}