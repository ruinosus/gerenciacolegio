using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloMatricula.Repositorios;
using Negocios.ModuloMatricula.Processos;
using Negocios.ModuloMatricula.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloMatricula.Excecoes;

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
            try
            {
                if (matricula.ID == 0)
                    throw new MatriculaNaoExcluidaExcecao();

                List<Matricula> resultado = matriculaRepositorio.Consultar(matricula, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new MatriculaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.matriculaRepositorio.Excluir(matricula);
        }

        public void Alterar(Matricula matricula)
        {
            this.matriculaRepositorio.Alterar(matricula);
        }

        public List<Matricula> Consultar(Matricula matricula, TipoPesquisa tipoPesquisa)
        {
            List<Matricula> matriculaList = this.matriculaRepositorio.Consultar(matricula,tipoPesquisa);           

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