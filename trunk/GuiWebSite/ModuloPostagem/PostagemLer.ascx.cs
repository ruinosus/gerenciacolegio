using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;

public partial class ModuloPostagem_PostagemLer : System.Web.UI.UserControl
{
    #region Propriedades
    public int IdPostagem { get; set; }
    public TipoPostagem TipoPostagem { get; set; }
    
    #endregion

    #region Métodos Privados
    protected string GetImageUrl(object id)
    {
        if (id != null)
        {
            return "~/ModuloAuxiliar/Handler.ashx?postId=" + (int)id;
        }
        else return "";
    }

    protected string GetData(object dataCriacao)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        DateTimeFormatInfo dtfi = culture.DateTimeFormat;

        if (dataCriacao != null)
        {
            int dia = ((DateTime)dataCriacao).Day;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(((DateTime)dataCriacao).Month));

            string data = dia + "<br>" + mes.ToString().Substring(0, 3);
            return data;
        }
        else return "";
    }

    protected bool GetImage(object imagem)
    {
        if (imagem != null)
            return true;
        return false;
    }
    
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    #region Métodos Público
    public void CarregarPost()
    {
         IPostagemProcesso processo = PostagemProcesso.Instance;

            Postagem  postagem = new Postagem();
            postagem.ID = IdPostagem;

            GrdPostagem.DataSource = processo.Consultar(postagem,TipoPesquisa.E);
            GrdPostagem.DataBind();

            TipoPostagem tipo = this.TipoPostagem;
            
            switch (tipo)
            {
                //case TipoPostagem.Contato:
                //    {
                //        lkbVoltar.PostBackUrl = "~/contato.aspx";
                //        lkbVoltar.Text = "Voltar para Contato";
                //        break;
                //    }
                //    case TipoPostagem.Estado:
                //    {
                //        lkbVoltar.PostBackUrl = "~/estados.aspx";
                //        lkbVoltar.Text = "Voltar para Estados";
                //        break;
                //    }
                //    case TipoPostagem.Filiese:
                //    {
                //        lkbVoltar.PostBackUrl = "~/Filiese.aspx";
                //        lkbVoltar.Text = "Voltar para Filie-se";
                //        break;
                //    }

                //    case TipoPostagem.Legislacao:
                //    {
                //        lkbVoltar.PostBackUrl = "~/legislacao.aspx";
                //        lkbVoltar.Text = "Voltar para Legislação";
                //        break;
                //    }

                //    case TipoPostagem.Noticia:
                //    {
                //        lkbVoltar.PostBackUrl = "~/noticias.aspx";
                //        lkbVoltar.Text = "Voltar para Notícias";
                //        break;
                //    }

                //    case TipoPostagem.PaginaPrincipal:
                //    {
                //        lkbVoltar.PostBackUrl = "~/default.aspx";
                //        lkbVoltar.Text = "Voltar para Página Principal";
                //        break;
                //    }

                //    case TipoPostagem.Parceria:
                //    {
                //        lkbVoltar.PostBackUrl = "~/parcerias.aspx";
                //        lkbVoltar.Text = "Voltar para Parceria";
                //        break;
                //    }

                //    case TipoPostagem.QuemSomos:
                //    {
                //        lkbVoltar.PostBackUrl = "~/quemsomos.aspx";
                //        lkbVoltar.Text = "Voltar para Quem Somos";
                //        break;
                //    }
                //    case TipoPostagem.Sindicato:
                //    {
                //        lkbVoltar.PostBackUrl = "~/osindicato.aspx";
                //        lkbVoltar.Text = "Voltar para Sindicato";
                //        break;
                //    }

                //    case TipoPostagem.Vantagens:
                //    {
                //        lkbVoltar.PostBackUrl = "~/vantagens.aspx";
                //        lkbVoltar.Text = "Voltar para Vantagens";
                //        break;
                //    }
            }
    }

    #endregion
}
