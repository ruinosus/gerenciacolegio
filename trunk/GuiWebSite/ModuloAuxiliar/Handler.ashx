<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }


    #region IHttpHandler Members

    bool IHttpHandler.IsReusable
    {
        get { throw new NotImplementedException(); }
    }

    void IHttpHandler.ProcessRequest(HttpContext context)
    {

        if (context.Request.QueryString["postId"] != null)
        {

            Negocios.ModuloSite.Processos.IPostagemProcesso processo = Negocios.ModuloSite.Processos.PostagemProcesso.Instance;

            Negocios.ModuloBasico.VOs.Postagem postagem = new Negocios.ModuloBasico.VOs.Postagem();
            postagem.ID = Convert.ToInt32(context.Request.QueryString["postId"]);
            System.Collections.Generic.List<Negocios.ModuloBasico.VOs.Postagem> postagemList = processo.Consultar(postagem, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
            //write your handler implementation here.
            if (postagemList.Count > 0)
            {
                context.Response.ContentType = "imagem";
                if (postagemList[0].Imagem != null)
                    context.Response.BinaryWrite(postagemList[0].ImagemI);
            }
        }

        if (context.Request.QueryString["imgId"] != null)
        {

            Negocios.ModuloSite.Processos.IImagemProcesso processo = Negocios.ModuloSite.Processos.ImagemProcesso.Instance;

            Negocios.ModuloBasico.VOs.Imagem imagem = new Negocios.ModuloBasico.VOs.Imagem();
            imagem.ID = Convert.ToInt32(context.Request.QueryString["imgId"]);
            System.Collections.Generic.List<Negocios.ModuloBasico.VOs.Imagem> imagemList = processo.Consultar(imagem, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
            //write your handler implementation here.
            if (imagemList.Count > 0)
            {
                context.Response.ContentType = "imagem";
                if (imagemList[0].ImagemI != null)
                    context.Response.BinaryWrite(imagemList[0].ImagemI);
            }
        }
      


    }

    #endregion
}