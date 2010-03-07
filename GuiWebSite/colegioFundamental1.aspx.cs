using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloSite.VOs;

public partial class colegioFundamental1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarTela();
        }
    }


    private void CarregarTela()
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        List<Postagem> PostagemList = processo.Consultar();

        if (PostagemList.Count > 0)
        {
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.FundamentalI);

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 115)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 115);
                }
                else
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo;
                }

                if (postagemExibicao.PostagemMeioUm.Titulo.Length > 20)
                {
                    lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioDois != null)
            {
                if (postagemExibicao.PostagemMeioDois.Corpo.Length > 300)
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo.Substring(0, 300);
                }
                else
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo;

                }
            }

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 675)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 675);
                }
                else
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo;

                }
                if (postagemExibicao.PostagemDireitaUm.Titulo.Length > 20)
                {
                    lblTituloDireita1.Text = postagemExibicao.PostagemDireitaUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloDireita1.Text = postagemExibicao.PostagemDireitaUm.Titulo;
                }
            }

        }
    }
}
