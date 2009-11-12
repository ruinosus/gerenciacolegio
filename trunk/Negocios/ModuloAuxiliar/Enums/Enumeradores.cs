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

namespace Negocios.ModuloAuxuliar.Enuns
{

    public enum StatusUsuarioSistema
    {
        UsuarioAtivo = 0,
        UsuarioPendente = 1,
        UsuarioCancelado = 2,
        UsuarioExcluido = 3,
        NaoAlterar = 4
    }

    public enum StatusPostagem
    {
        Ativa = 0,
        Inativa = 1,
        Excluida = 2,
        NaoAlterar = 3
    }

    public enum LocalPostagem
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Topo")]
        Topo = 1,
        [Description("Post")]
        Post = 2,
        [Description("Recado")]
        Recado = 3,
        [Description("Rodapé")]
        Rodape = 4,
        [Description("Acre")]
        Acre = 5,
        [Description("Alagoas")]
        Alagoas = 6,
        [Description("Amapá")]
        Amapa = 7,
        [Description("Amazonas")]
        Amazonas = 8,
        [Description("Bahia")]
        Bahia = 9,
        [Description("Ceará")]
        Ceara = 10,
        [Description("Distrito Federal")]
        DistritoFederal = 11,
        [Description("Espírito Santo")]
        EspiritoSanto = 12,
        [Description("Goiás")]
        Goias = 13,
        [Description("Maranhão")]
        Maranhao = 14,
        [Description("Mato Grosso")]
        MatoGrosso = 15,
        [Description("Mato Grosso do Sul")]
        MatoGrossoDoSul = 16,
        [Description("Minas Gerais")]
        MinasGerais = 17,
        [Description("Pará")]
        Para = 18,
        [Description("Paraíba")]
        Paraiba = 19,
        [Description("Paraná")]
        Parana = 20,
        [Description("Pernambuco")]
        Pernambuco = 21,
        [Description("Piauí")]
        Piaui = 22,
        [Description("Rio de Janeiro")]
        RioDeJaneiro = 23,
        [Description("Rio Grande do Norte")]
        RioGrandeDoNorte = 24,
        [Description("Rio Grande do Sul")]
        RioGrandeDoSul = 25,
        [Description("Rondônia")]
        Rondonia = 26,
        [Description("Roraima")]
        Roraima = 27,
        [Description("Santa Catarina")]
        SantaCatarina = 28,
        [Description("São Paulo")]
        SaoPaulo = 29,
        [Description("Sergipe")]
        Sergipe = 30,
        [Description("Tocantins")]
        Tocantins = 31
    }

    public enum TipoPostagem
    {
        [Description("")]
        NaoAlterar = 0,
        [Description("Página Principal")]
        PaginaPrincipal = 1,
        [Description("Quem Somos")]
        QuemSomos = 2,
        [Description("Sindicato")]
        Sindicato = 3,
        [Description("Estado")]
        Estado = 4,
        [Description("Filie-se")]
        Filiese = 5,
        [Description("Notícia")]
        Noticia = 6,
        [Description("Legislação")]
        Legislacao = 7,
        [Description("Parceria")]
        Parceria = 8,
        [Description("Contato")]
        Contato = 9,
        [Description("Vantagens")]
        Vantagens = 10,
        [Description("Anuncie Aqui")]
        AnuncieAqui = 11

    }

}