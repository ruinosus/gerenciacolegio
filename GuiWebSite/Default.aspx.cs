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

public partial class _Default : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.Colegio);
            if (postagemExibicao.PostagemEsquerdaUm != null)
            {
                lblTextoArtigoEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Corpo;
                lblTituloEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo;
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                lblTextoArtigoEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Corpo;
                lblTituloEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo;
            }

            if (postagemExibicao.PostagemMeioUm != null)
            {
                lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo;
                lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo;
            }            

        }


    }

}
