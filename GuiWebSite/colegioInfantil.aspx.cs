using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.VOs;
using Negocios.ModuloBasico.Enums;

public partial class colegioInfantil : System.Web.UI.Page
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
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.EducacaoInfantil);

            if (postagemExibicao.PostagemMeioUm != null)
            {
                if (postagemExibicao.PostagemMeioUm.Corpo.Length > 260)
                {
                    lblTextoArtigoMeio1.Text = postagemExibicao.PostagemMeioUm.Corpo.Substring(0, 260);
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
                if (postagemExibicao.PostagemMeioDois.Corpo.Length > 260)
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo.Substring(0, 260);
                }
                else
                {
                    lblTextoArtigoMeio2.Text = postagemExibicao.PostagemMeioDois.Corpo;
                }
                if (postagemExibicao.PostagemMeioDois.Titulo.Length > 20)
                {
                    lblTituloMeio2.Text = postagemExibicao.PostagemMeioDois.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio2.Text = postagemExibicao.PostagemMeioDois.Titulo;
                }
            }

            if (postagemExibicao.PostagemMeioTres != null)
            {
                if (postagemExibicao.PostagemMeioTres.Corpo.Length > 265)
                {
                    lblTextoArtigoMeio3.Text = postagemExibicao.PostagemMeioTres.Corpo.Substring(0, 265);
                }
                else
                {
                    lblTextoArtigoMeio3.Text = postagemExibicao.PostagemMeioTres.Corpo;
                }
                if (postagemExibicao.PostagemMeioTres.Titulo.Length > 20)
                {
                    lblTituloMeio3.Text = postagemExibicao.PostagemMeioTres.Titulo.Substring(0, 20);
                }
                else
                {
                    lblTituloMeio3.Text = postagemExibicao.PostagemMeioTres.Titulo;
                }
            }

            if (postagemExibicao.PostagemDireitaUm != null)
            {
                if (postagemExibicao.PostagemDireitaUm.Corpo.Length > 790)
                {
                    lblTextoArtigoDireita1.Text = postagemExibicao.PostagemDireitaUm.Corpo.Substring(0, 790);
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
