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
using System.Data;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloMatriculaVinculo.VOs;
using Negocios.ModuloBoletoMensalidade.Processos;

namespace Negocios.ModuloMatriculaVinculo.Processos
{
    /// <summary>
    /// Classe MatriculaVinculoProcesso
    /// </summary>
    public class MatriculaVinculoProcesso : Negocios.ModuloAuxiliar.Singleton.Singleton<MatriculaVinculoProcesso>, IMatriculaVinculoProcesso
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
            List<MatriculaVinculo> listaMatricula = this.Consultar(matriculaVinculo, tipoPesquisa);

            CoreList<MatriculaVinculoBoleto> resultado = new CoreList<MatriculaVinculoBoleto>();

            if (listaMatricula.Count > 0)
            {
                //IBoletoMensalidadeProcesso processo = BoletoMensalidadeProcesso.Instance;
                //BoletoMensalidade boletoMensalidade = new BoletoMensalidade();
                //boletoMensalidade.MatriculaID = listaMatricula[0].MatriculaPrincipal.ID;
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
                //List<BoletoMensalidade> boletoMensalidadeLista = listaMatricula[0].MatriculaPrincipal.BoletoMensalidade.ToList();
                mvbBase.NomeAluno += listaMatricula[0].MatriculaPrincipal.Aluno.Nome;
                mvbBase.Ano += listaMatricula[0].MatriculaPrincipal.Ano;
                mvbBase.SerieAluno += listaMatricula[0].MatriculaPrincipal.Aluno.SerieAtual;
                mvbBase.Valor += listaMatricula[0].MatriculaPrincipal.Valor.Value;
                mvbBase.Vencimento = new DateTime(DateTime.Now.Year,1,listaMatricula[0].MatriculaPrincipal.DiaVencimento.Value);
                //mvb.Vencimento 
                foreach (MatriculaVinculo mv in listaMatricula)
                {
                    mvbBase.NomeAluno += ", " + mv.MatriculaVinculada.Aluno.Nome;
                    mvbBase.Ano += ", " + mv.MatriculaVinculada.Ano;
                    mvbBase.SerieAluno += ", " + mv.MatriculaVinculada.Aluno.SerieAtual;
                    mvbBase.Valor += mv.MatriculaVinculada.Valor.Value;
                }
                
                MatriculaVinculoBoleto mvbMes;
                for (int i = 0; i < 12; i++)
                {
                    mvbMes = new MatriculaVinculoBoleto();

                    mvbMes.NomeAluno = mvbBase.NomeAluno;
                    mvbMes.Ano = mvbBase.Ano;
                    mvbMes.SerieAluno = mvbBase.SerieAluno;
                    mvbMes.Valor= mvbBase.Valor;
                    mvbMes.Vencimento= mvbBase.Vencimento.AddMonths(i);

                    mvbMes.Parcela = meses[i];
                    resultado.Add(mvbMes);
                }


            }

            return (DataTable)resultado;
        }

        #endregion
    }
}