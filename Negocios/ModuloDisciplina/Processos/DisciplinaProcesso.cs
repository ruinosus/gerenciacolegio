using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloDisciplina.Repositorios;
using Negocios.ModuloDisciplina.Processos;
using Negocios.ModuloDisciplina.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloDisciplina.Processos
{
    /// <summary>
    /// Classe DisciplinaProcesso
    /// </summary>
    public class DisciplinaProcesso : Singleton<DisciplinaProcesso>, IDisciplinaProcesso
    {
        #region Atributos
        private IDisciplinaRepositorio disciplinaRepositorio = null;
        #endregion

        #region Construtor
        public DisciplinaProcesso()
        {
            disciplinaRepositorio = DisciplinaFabrica.IDisciplinaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Disciplina disciplina)
        {
            this.disciplinaRepositorio.Incluir(disciplina);

        }

        public void Excluir(Disciplina disciplina)
        {
            this.disciplinaRepositorio.Excluir(disciplina);
        }

        public void Alterar(Disciplina disciplina)
        {
            this.disciplinaRepositorio.Alterar(disciplina);
        }

        public List<Disciplina> Consultar(Disciplina disciplina, TipoPesquisa tipoPesquisa)
        {
            List<Disciplina> disciplinaList = this.disciplinaRepositorio.Consultar(disciplina, tipoPesquisa);           

            return disciplinaList;
        }

        public List<Disciplina> Consultar()
        {
            List<Disciplina> disciplinaList = this.disciplinaRepositorio.Consultar();

            return disciplinaList;
        }


        public void Confirmar()
        {
            this.disciplinaRepositorio.Confirmar();
        }

        #endregion
    }
}