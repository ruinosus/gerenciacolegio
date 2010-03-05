using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;


public partial class ModuloImagem_ImagemSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idImagem;
    private List<Imagem> imagemList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdImagem
    {
        get
        {
            if (Session["idImagem"] != null)
                idImagem = Convert.ToInt32(Session["idImagem"]);

            return idImagem;
        }
        set
        {
            Session.Add("idImagem", value);
        }
    }

    public List<Imagem> ImagemList
    {
        get
        {
            if (Session["ImagemList"] != null)
                imagemList = (List<Imagem>)Session["ImagemList"];

            return imagemList;
        }
        set
        {
            Session.Add("ImagemList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdImagem = Convert.ToInt32(eventArgument);

        // Verifica se existe algum Evento relacionado
        if (OnSelect != null)
        {

            OnSelect.Invoke(this, new EventArgs());
        }
    }

    #endregion

    /// <summary>
    /// Retorna o JavaScript necessário para invocar o evento OnSelect
    /// </summary>
    /// <param name="idImagem">O ID da Imagem que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idImagem)
    {
        if (OnSelect != null && idImagem != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idImagem.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idImagem');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idImagem');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        ImagemList = new List<Imagem>();

        Imagem PostagemInicial = new Imagem();

        ImagemList.Add(PostagemInicial);

        GrdImagem.DataSource = ImagemList;
        GrdImagem.DataBind();

        foreach (TableCell cell in GrdImagem.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idImagem");
        Session.Remove("ImagemList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            ImagemList = new List<Imagem>();
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IImagemProcesso processo = ImagemProcesso.Instance;
                Imagem imagem = new Imagem();
                imagem.Titulo = txtTitulo.Text.Trim();




                ImagemList = processo.Consultar(imagem, TipoPesquisa.E);

                GrdImagem.DataSource = ImagemList;
                GrdImagem.DataBind();
            }
            else
            {
                IImagemProcesso processo = ImagemProcesso.Instance;
                Imagem imagem = new Imagem();




                ImagemList = processo.Consultar(imagem, TipoPesquisa.E);


                GrdImagem.DataSource = ImagemList;
                GrdImagem.DataBind();
            }
        }
        catch (Exception ex)
        {
            cvaAvisoDeErro.ErrorMessage = ex.Message;
            cvaAvisoDeErro.IsValid = false;
        }

    }

    //public StatusPostagem GetStatusPostagem(int id)
    //{
    //    StatusPostagem status = StatusPostagem.NaoAlterar;
    //    foreach (Postagem post in PostagemList)
    //    {
    //        if (post.ID == id)
    //            status = post.StatusPostagem;
    //    }

    //    return status;
    //}
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        //ClasseAuxiliar.ValidarUsuarioLogado(true);
        if (!IsPostBack)
        {
            //ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdPostagem_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idImagem");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdPostagem_PreRender(object sender, EventArgs e)
    {
        if (ImagemList  == null || ImagemList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdPostagem_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdImagem.DataSource = ImagemList;
        if (GrdImagem.DataSource != null)
        {
            GrdImagem.PageIndex = e.NewPageIndex;
            GrdImagem.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}
