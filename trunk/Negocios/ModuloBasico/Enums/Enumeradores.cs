using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;

namespace Negocios.ModuloBasico.Enums
{
    public enum TipoPesquisa
    {
        E = 0,
        Ou = 1
    }

    public enum Status
    {
        Inativo = 0,
        Ativo = 1
    }

    /// <summary>
    /// Enum que representa os status do Banco.
    /// </summary>
    public enum StatusBanco
    {
        Inativo = 1,
        Inclusao,
        Alteracao,
        Navegacao
    }

    public enum OperacoesDaTela
    {
        Incluir = 1,
        Alterar = 2,
        Excluir = 3,
        AbrirTela = 4,
        VoltarTela = 5,
        Navegar = 6,
        Bloquear = 7,
        Inativa = 8
    }


    public enum LocalPostagem
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Um")]
        Um = 1,
        [Description("Dois")]
        Dois = 2,
        [Description("Três")]
        Tres = 3,
        [Description("Quatro")]
        Quatro = 4,
        [Description("Cinco")]
        Cinco = 5,
        [Description("Seis")]
        Seis = 6,
        [Description("Sete")]
        Amapa = 7,
        [Description("Oito")]
        Oito = 8,
        [Description("Nove")]
        Nove = 9,
        [Description("Dez")]
        Dez = 10

    }

    public enum TipoPagina
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Colégio")]
        Colegio = 1,
        [Description("Educação Infantil")]
        EducacaoInfantil = 2,
        [Description("Fundamental I")]
        FundamentalI = 3,
        [Description("Fundamental II")]
        FundamentalII = 4,
        [Description("Ensino Médio")]
        EnsinoMedio = 5,
        [Description("Atividades")]
        Atividades = 6,
        [Description("Ex-Alunos")]
        ExAlunos = 7,
        [Description("Contato")]
        Contato = 8,

    }

    public enum TipoPostagem
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Postagem")]
        Postagem = 1,
        [Description("Evento")]
        Evento = 2,
        [Description("Atividade")]
        Atividade = 3


    }


}
