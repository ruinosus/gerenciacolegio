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
                if (postagemExibicao.PostagemEsquerdaUm.Corpo.Length > 230)
                {
                    lblTextoArtigoEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Corpo.Substring(0, 230);
                }
                else
                {
                    lblTextoArtigoEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Corpo;
                }

                if (postagemExibicao.PostagemEsquerdaUm.Titulo.Length > 20)
                {
                    lblTituloEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloEsquerda1.Text = postagemExibicao.PostagemEsquerdaUm.Titulo;
                }
            }

            if (postagemExibicao.PostagemEsquerdaDois != null)
            {
                if (postagemExibicao.PostagemEsquerdaDois.Corpo.Length > 160)
                {
                    lblTextoArtigoEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Corpo.Substring(0, 160);
                }
                else
                {
                    lblTextoArtigoEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Corpo;
                }

                if (postagemExibicao.PostagemEsquerdaDois.Titulo.Length > 20)
                {
                    lblTituloEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloEsquerda2.Text = postagemExibicao.PostagemEsquerdaDois.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.ImagemI != null &&
                    postagemExibicao.PostagemMeioUm.ImagemI.Length > 0)
                {
                    imgArtigoMeio1.Visible = true;
                    imgArtigoMeio1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemMeioUm.ID;
                }
                else
                {
                    imgArtigoMeio1.Visible = false;
                }

                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 320)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 320);
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

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.ImagemI != null &&
                    postagemExibicao.PostagemDireitaUm.ImagemI.Length > 0)
                {
                    imgArtigoDireita1.Visible = true;
                    imgArtigoDireita1.ImageUrl = "~/ModuloAuxiliar/Handler.ashx?postId=" + postagemExibicao.PostagemDireitaUm.ID;
                }
                else
                {
                    imgArtigoDireita1.Visible = false;
                }


                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 284)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 284);
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
