using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloMatriculaVinculo.Repositorios;
using Negocios.ModuloMatriculaVinculo.Processos;
using Negocios.ModuloMatriculaVinculo.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloMatriculaVinculo.Excecoes;

namespace Negocios.ModuloMatriculaVinculo.Processos
{
    /// <summary>
    /// Classe MatriculaVinculoProcesso
    /// </summary>
    public class MatriculaVinculoProcesso : Singleton<MatriculaVinculoProcesso>, IMatriculaVinculoProcesso
    {
        #region Atributos
        private IMatriculaVinculoRepositorio matriculaVinculoRepositorio = null;
        #endregion

        #region Construtor
        public MatriculaVinculoProcesso()
        {
            matriculaVinculoRepositorio = MatriculaVinculoFabrica.IMatriculaVinculoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(MatriculaVinculo matriculaVinculo)
        {
            this.matriculaVinculoRepositorio.Incluir(matriculaVinculo);

        }

        public void Excluir(MatriculaVinculo matriculaVinculo)
        {
            try
            {
                if (matriculaVinculo.ID == 0)
                    throw new MatriculaVinculoNaoExcluidaExcecao();

                List<MatriculaVinculo> resultado = matriculaVinculoRepositorio.Consultar(matriculaVinculo, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new MatriculaVinculoNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.matriculaVinculoRepositorio.Excluir(matriculaVinculo);
        }

        public void Alterar(MatriculaVinculo matriculaVinculo)
        {
            this.matriculaVinculoRepositorio.Alterar(matriculaVinculo);
        }

        public List<MatriculaVinculo> Consultar(MatriculaVinculo matriculaVinculo, TipoPesquisa tipoPesquisa)
        {
            List<MatriculaVinculo> matriculaVinculoList = this.matriculaVinculoRepositorio.Consultar(matriculaVinculo,tipoPesquisa);           

            return matriculaVinculoList;
        }

        public List<MatriculaVinculo> Consultar()
        {
            List<MatriculaVinculo> matriculaVinculoList = this.matriculaVinculoRepositorio.Consultar();

            return matriculaVinculoList;
        }

     
        public void Confirmar()
        {
            this.matriculaVinculoRepositorio.Confirmar();
        }

        #endregion
    }
}