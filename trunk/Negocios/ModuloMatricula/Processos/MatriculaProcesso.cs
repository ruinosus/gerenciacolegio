using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloMatricula.Repositorios;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloMatricula.Fabricas;

namespace Negocios.ModuloMatricula.Processos
{
    /// <summary>
    /// Classe MatriculaProcesso
    /// </summary>
    public class MatriculaProcesso : Singleton<MatriculaProcesso>, IMatriculaProcesso
    {
        #region Atributos
        private IMatriculaRepositorio matriculaRepositorio = null;
        #endregion

        #region Construtor
        public MatriculaProcesso()
        {
            matriculaRepositorio = MatriculaFabrica.IMatriculaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Matricula matricula)
        {
            this.matriculaRepositorio.Incluir(matricula);

        }

        public void Excluir(Matricula matricula)
        {
            this.matriculaRepositorio.Excluir(matricula);
        }

        public void Alterar(Matricula matricula)
        {
            this.matriculaRepositorio.Alterar(matricula);
        }

        public List<Matricula> Consultar(Matricula matricula)
        {
            List<Matricula> matriculaList = this.matriculaRepositorio.Consultar(matricula);           

            return matriculaList;
        }

        public List<Matricula> Consultar()
        {
            List<Matricula> matriculaList = this.matriculaRepositorio.Consultar();

            return matriculaList;
        }

     
        public void Confirmar()
        {
            this.matriculaRepositorio.Confirmar();
        }

        #endregion
    }
}