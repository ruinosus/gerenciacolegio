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
        [Description("Esquerda Um")]
        EsquerdaUm = 1,
        [Description("Esquerda Dois")]
        EsquerdaDois = 2,
        [Description("Esquerda Três")]
        EsquerdaTres = 3,
        [Description("Meio Um")]
        MeioUm = 4,
        [Description("Meio Dois")]
        MeioDois = 5,
        [Description("Meio Três")]
        MeioTres = 6,
        [Description("Direita Um")]
        DireitaUm = 7,
        [Description("Direita Dois")]
        DireitaDois = 8,
        [Description("Direita Três")]
        DireitaTres = 9
    }

    public enum LocalPostagemFundamental
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Meio Um")]
        MeioUm = 4,
        [Description("Meio Dois")]
        MeioDois = 5,
        [Description("Direita Um")]
        DireitaUm = 7
    }

    public enum LocalPostagemInfantil
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Meio Um")]
        MeioUm = 4,
        [Description("Meio Dois")]
        MeioDois = 5,
        [Description("Meio Três")]
        MeioTres = 6,
        [Description("Direita Um")]
        DireitaUm = 7
    }

    public enum LocalPostagemDefault
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Esquerda Um")]
        EsquerdaUm = 1,
        [Description("Esquerda Dois")]
        EsquerdaDois = 2,
        [Description("Meio Um")]
        MeioUm = 4,
        [Description("Direita Um")]
        DireitaUm = 7
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
        [Description("Atividades")]
        Atividades = 6,

    }

    public enum TipoPostagem
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Postagem")]
        Postagem = 1,
        [Description("Evento Educação Infantil")]
        EventoEducacaoInfantil = 2,
        [Description("Evento Ensino Fundamental I")]
        EventoEnsinoFundamentalI = 3,
        [Description("Evento Ensino Fundamental II")]
        EventoEnsinoFundamentalII = 4,
        [Description("Atividade")]
        Atividade = 6


    }


}
