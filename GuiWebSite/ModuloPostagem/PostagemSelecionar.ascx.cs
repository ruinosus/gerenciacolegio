using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloSite.Processos;


public partial class ModuloPostagem_PostagemSelecionar : System.Web.UI.UserControl, System.Web.UI.IPostBackEventHandler
{
    #region Atributos

    private int idPostagem;
    private List<Postagem> postagemList;
    private bool check = false;


    #endregion

    #region Propriedades
    public int IdPostagem
    {
        get
        {
            if (Session["idPostagem"] != null)
                idPostagem = Convert.ToInt32(Session["idPostagem"]);

            return idPostagem;
        }
        set
        {
            Session.Add("idPostagem", value);
        }
    }

    public List<Postagem> PostagemList
    {
        get
        {
            if (Session["PostagemList"] != null)
                postagemList = (List<Postagem>)Session["PostagemList"];

            return postagemList;
        }
        set
        {
            Session.Add("PostagemList", value);
        }
    }
    #endregion

    #region Eventos

    public event EventHandler OnSelect;

    #endregion

    #region IPostBackEventHandler Members

    void IPostBackEventHandler.RaisePostBackEvent(string eventArgument)
    {
        IdPostagem = Convert.ToInt32(eventArgument);

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
    /// <param name="idPostagem">O ID do ProdutoVO que será passado como parâmetro para o evento</param>
    /// <returns>O JavaScript</returns>
    protected string GetOnSelectEvent(object idPostagem)
    {
        if (OnSelect != null && idPostagem != null)
        {
            PostBackOptions options = new PostBackOptions(this);

            options.Argument = idPostagem.ToString();

            string postBackReference = Page.ClientScript.GetPostBackEventReference(options);

            return "checkOnlyOne(this,'idPostagem');" + postBackReference + ";";
        }

        return "checkOnlyOne(this,'idPostagem');";
    }

    #region Métodos Privados
    /// <summary>
    /// Método para exibir o gridView com valores em branco.
    /// </summary>
    private void PreencherGridVazio()
    {
        PostagemList = new List<Postagem>();

        Postagem PostagemInicial = new Postagem();

        PostagemList.Add(PostagemInicial);

        GrdPostagem.DataSource = PostagemList;
        GrdPostagem.DataBind();

        foreach (TableCell cell in GrdPostagem.Rows[0].Cells)
        {
            cell.Text = "&nbsp;";
        }
    }

    private void ClearSession()
    {
        Session.Remove("idPostagem");
        Session.Remove("PostagemList");
    }

    #endregion

    #region Métodos Públicos
    public void Consultar()
    {
        try
        {
            PostagemList = new List<Postagem>();
            TipoPostagem tipo = (TipoPostagem)Convert.ToInt32(ddlTipoPostagem.SelectedValue);
            if (!string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                IPostagemProcesso processo = PostagemProcesso.Instance;
                Postagem postagem = new Postagem();
                postagem.Titulo = txtTitulo.Text.Trim();
                postagem.Tipo = (int)tipo;
                
                

                PostagemList = processo.Consultar(postagem,TipoPesquisa.E);

                GrdPostagem.DataSource = PostagemList;
                GrdPostagem.DataBind();
            }
            else
            {
                IPostagemProcesso processo = PostagemProcesso.Instance;
                Postagem postagem = new Postagem();
                postagem.Tipo = (int)tipo;



                PostagemList = processo.Consultar(postagem, TipoPesquisa.E);


                GrdPostagem.DataSource = PostagemList;
                GrdPostagem.DataBind();
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
            ClasseAuxiliar.CarregarComboEnum<TipoPostagem>(ddlTipoPostagem);
            //PreencherGridVazio();
            Consultar();
        }
    }

    protected void grdPostagem_RowCreated(object sender, GridViewRowEventArgs e)
    {
        foreach (TableCell cell in e.Row.Cells)
        {
            Control control = cell.FindControl("idPostagem");

            if (check && control != null && control is RadioButton)
            {
                ((RadioButton)control).Checked = check;
            }
        }
    }

    protected void grdPostagem_PreRender(object sender, EventArgs e)
    {
        if (PostagemList == null || PostagemList.Count == 0)
        {
            PreencherGridVazio();
        }
    }

    protected void grdPostagem_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdPostagem.DataSource = PostagemList;
        if (GrdPostagem.DataSource != null)
        {
            GrdPostagem.PageIndex = e.NewPageIndex;
            GrdPostagem.DataBind();
        }
    }

    protected void btnPesquisar_OnClick(object sender, EventArgs e)
    {
        Consultar();
    }
}
