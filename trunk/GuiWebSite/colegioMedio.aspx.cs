using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;
using Negocios.ModuloSite.VOs;

public partial class colegioMedio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void CarregarTela()
    {
        IPostagemProcesso processo = PostagemProcesso.Instance;
        List<Postagem> PostagemList = processo.Consultar();

        if (PostagemList.Count > 0)
        {
            PostagemExibicao postagemExibicao = processo.Consultar(TipoPagina.Colegio);
            if (postagemExibicao.PostagemMeioUm != null)
            {
                lblArtigoUnico1.Text = postagemExibicao.PostagemMeioUm.Corpo;
                lblTituloMeio1.Text = postagemExibicao.PostagemMeioUm.Titulo;
            }
        }
    }
}
