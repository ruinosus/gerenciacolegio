using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloMatriculaVinculo.Repositorios;
using Negocios.ModuloMatriculaVinculo.Processos;
using Negocios.ModuloMatriculaVinculo.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloMatriculaVinculo.Excecoes;
using System.Data;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloMatriculaVinculo.VOs;
using Negocios.ModuloBoletoMensalidade.Processos;
using Negocios.ModuloMatricula.Processos;

namespace Negocios.ModuloMatriculaVinculo.Processos
{
    /// <summary>
    /// Classe MatriculaVinculoProcesso
    /// </summary>
    public class MatriculaVinculoProcesso : Negocios.ModuloBasico.Singleton.Singleton<MatriculaVinculoProcesso>, IMatriculaVinculoProcesso
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
            List<MatriculaVinculo> matriculaVinculoList = this.matriculaVinculoRepositorio.Consultar(matriculaVinculo, tipoPesquisa);

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

        public DataTable GerarRelatorio(MatriculaVinculo matriculaVinculo, TipoPesquisa tipoPesquisa)
        {
            List<MatriculaVinculo> listaMatricula = ConsultarMatriculaMestre(matriculaVinculo, tipoPesquisa);

            CoreList<MatriculaVinculoBoleto> resultado = new CoreList<MatriculaVinculoBoleto>();

            if (listaMatricula.Count == 0)
            {
                IMatriculaProcesso processo = MatriculaProcesso.Instance;
                Matricula m = new Matricula();
                m.Status = (int)Status.Ativo;
                m.ID = matriculaVinculo.MatriculaMestreID;
                List<Matricula> matriculaMestreLista = processo.Consultar(m,tipoPesquisa);

                if (matriculaMestreLista.Count > 0)
                {
                    MatriculaVinculo matriculaVinculoUnica = new MatriculaVinculo();
                    matriculaVinculoUnica.MatriculaMestre = matriculaMestreLista[0];
                    matriculaVinculoUnica.MatriculaMestreID = matriculaMestreLista[0].ID;
                    listaMatricula.Add(matriculaVinculoUnica);
                }
            }

            if (listaMatricula.Count > 0)
            {
                MatriculaVinculoBoleto mvbBase = new MatriculaVinculoBoleto();
                List<String> meses = new List<String>();
                meses.Add("Janeiro");
                meses.Add("Fevereiro");
                meses.Add("Março");
                meses.Add("Abril");
                meses.Add("Maio");
                meses.Add("Junho");
                meses.Add("Julho");
                meses.Add("Agosto");
                meses.Add("Setembro");
                meses.Add("Outubro");
                meses.Add("Novembro");
                meses.Add("Dezembro");

                mvbBase.NomeAluno1 = listaMatricula[0].MatriculaMestre.Aluno.Nome;
                mvbBase.NumeroMatriculaAluno1 = listaMatricula[0].MatriculaMestre.NumMatricula;
                mvbBase.Ano = listaMatricula[0].MatriculaMestre.Ano.Value.ToString();
                mvbBase.SerieAluno += listaMatricula[0].MatriculaMestre.Aluno.SerieAtual;
                mvbBase.Valor += listaMatricula[0].MatriculaMestre.Valor.Value;
                mvbBase.Vencimento = new DateTime(DateTime.Now.Year, 1, listaMatricula[0].MatriculaMestre.DiaVencimento.Value);

                if (listaMatricula.Count == 2)
                {
                    mvbBase.NomeAluno2 = listaMatricula[0].MatriculaDependente.Aluno.Nome;
                    mvbBase.NumeroMatriculaAluno2 = listaMatricula[0].MatriculaDependente.NumMatricula;
                    mvbBase.NomeAluno3 = listaMatricula[1].MatriculaDependente.Aluno.Nome;
                    mvbBase.NumeroMatriculaAluno3 = listaMatricula[1].MatriculaDependente.NumMatricula;
                }
                else if (listaMatricula.Count == 1 && listaMatricula[0].MatriculaDependente!= null && listaMatricula[0].MatriculaDependente.AlunoID.Value!= 0 )
                {
                    mvbBase.NomeAluno2 = listaMatricula[0].MatriculaDependente.Aluno.Nome;
                    mvbBase.NumeroMatriculaAluno2 = listaMatricula[0].MatriculaDependente.NumMatricula;
                    mvbBase.NomeAluno3 = "";
                    mvbBase.NumeroMatriculaAluno3 = "";
                }
                else if (listaMatricula[0].MatriculaDependente == null)
                {
                    mvbBase.NomeAluno2 = "";
                    mvbBase.NumeroMatriculaAluno2 = "";
                    mvbBase.NomeAluno3 = "";
                    mvbBase.NumeroMatriculaAluno3 = "";
                }

                foreach (MatriculaVinculo mv in listaMatricula)
                {
                    if (mv.MatriculaDependente != null)
                    {
                        mvbBase.SerieAluno += ", " + mv.MatriculaDependente.Aluno.SerieAtual;
                        mvbBase.Valor += mv.MatriculaDependente.Valor.Value;
                    }
                }

                MatriculaVinculoBoleto mvbMes;
                for (int i = 0; i < 12; i++)
                {
                    mvbMes = new MatriculaVinculoBoleto();

                    mvbMes.NomeAluno1 = mvbBase.NomeAluno1;
                    mvbMes.NomeAluno2 = mvbBase.NomeAluno2;
                    mvbMes.NomeAluno3 = mvbBase.NomeAluno3;

                    mvbMes.NumeroMatriculaAluno1 = mvbBase.NumeroMatriculaAluno1;
                    mvbMes.NumeroMatriculaAluno2 = mvbBase.NumeroMatriculaAluno2;
                    mvbMes.NumeroMatriculaAluno3 = mvbBase.NumeroMatriculaAluno3;

                    mvbMes.Ano = mvbBase.Ano;
                    mvbMes.SerieAluno = mvbBase.SerieAluno;
                    mvbMes.Valor = mvbBase.Valor;
                    mvbMes.Vencimento = mvbBase.Vencimento.AddMonths(i);

                    mvbMes.Parcela = meses[i];
                    resultado.Add(mvbMes);
                }


            }


            return (DataTable)resultado;
        }

        #endregion

        private List<MatriculaVinculo> ConsultarMatriculaMestre(MatriculaVinculo matriculaVinculo, TipoPesquisa tipoPesquisa)
        {
            List<MatriculaVinculo> resultado = new List<MatriculaVinculo>();
            matriculaVinculo.Status = (int)Status.Ativo;
            resultado = this.Consultar(matriculaVinculo, tipoPesquisa);

            if (resultado.Count == 0)
            {
                MatriculaVinculo mv = new MatriculaVinculo();
                mv.Status = (int)Status.Ativo;
                mv.MatriculaDependenteID = matriculaVinculo.MatriculaMestreID;
                List<MatriculaVinculo> listaMatricula = this.Consultar(mv, tipoPesquisa);
                if (listaMatricula.Count > 0)
                {
                    resultado = new List<MatriculaVinculo>();
                    MatriculaVinculo matriculaVinculo2 = new MatriculaVinculo();
                    matriculaVinculo2.MatriculaMestreID = listaMatricula[0].MatriculaMestreID;
                    resultado = this.Consultar(matriculaVinculo2, tipoPesquisa);
                }

            }


            return resultado;
        }
    }
}