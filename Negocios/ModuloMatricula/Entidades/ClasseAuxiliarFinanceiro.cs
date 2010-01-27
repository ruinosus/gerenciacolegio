using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloMatricula.Entidades
{
    public enum selecaoMatriculaAtividade
    {
        Matricula = 1,
        Atividade = 2,
        Ambos = 3,
    }

    public enum selecaoMatriculaDesconto
    {
        Desconto = 1,
        SemDesconto = 2,
        Ambos = 3,
    }

    public enum selecaoPagamentoPendenteAtivo
    {
        Ativo = 1,
        Pendente = 2,
        Ambos = 3,
    }

    public class ClasseAuxiliarFinanceiro
    {
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public double desconto { get; set; }
        public string parcela { get; set; }
        public int matriculaId { get; set; }
        public int atividadeId { get; set; }
        public double valor { get; set; }
        public string serie { get; set; }
        public string atividade { get; set; }
        public string aluno { get; set; }

        public ClasseAuxiliarFinanceiro()
        { }

    }

    public class ClasseColetoraFinanceiro
    {
        public string aluno { get; set; }
        public int desconto { get; set; }
        public int tipo { get; set; }
        public int situacao { get; set; }
        public string serie { get; set; }
        public DateTime dataInicioPeriodo { get; set; }
        public DateTime dataFimPeriodo { get; set; }

        public ClasseColetoraFinanceiro()
        { }
    }

}
