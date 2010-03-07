using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.ComponentModel;
using System.Reflection;
using System.IO;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloBasico.Constantes;

/// <summary>
/// Summary description for ClasseAuxiliar
/// </summary>
public partial class ClasseAuxiliar
{

    private static Usuario usuarioLogado;

    /// <summary>
    /// Propriedade que representa um Usuario no sistema.
    /// </summary>
    public static Usuario UsuarioLogado
    {
        get
        {
            if (System.Web.HttpContext.Current.Session["UsuarioLogado"] != null)
                usuarioLogado = (Usuario)System.Web.HttpContext.Current.Session["UsuarioLogado"];
            else
                usuarioLogado = null;

            return usuarioLogado;
        }
        private set { usuarioLogado = value; }
    }

    /// <summary>
    /// Verifica se o Usuario está logado na aplicação.
    /// </summary>
    public static void ValidarUsuarioLogado()
    {
        if (UsuarioLogado == null)
            System.Web.HttpContext.Current.Response.Redirect(BasicoConstantes.PAGINA_PRINCIPAL, false);

    }

    /// <summary>
    /// Método responsável por montar um combo com um Enum.
    /// </summary>
    /// <typeparam name="T">Enum a ser exibido no combo.</typeparam>
    /// <param name="cbo">combo para montatem</param>
    public static void CarregarComboEnum<T>(DropDownList cbo)
    {
        cbo.Items.Clear();

        Type objType = typeof(T);
        FieldInfo[] propriedades = objType.GetFields();

        foreach (FieldInfo objField in propriedades)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])objField.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                cbo.Items.Add(new ListItem(attributes[0].Description, objField.GetRawConstantValue().ToString()));
        }
    }


    /// <summary>
    /// Método responsável por converter uma imagem em um array de bytes.
    /// </summary>
    /// <param name="imageIn">Imagem a ser convertida.</param>
    /// <returns>Array de Bytes que formam a imagem.</returns>
    public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
    {
        MemoryStream ms = new MemoryStream();
        imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
        return ms.ToArray();
    }
    
    /// <summary>
    /// Método responsável por converter um array de bytes em uma imagem.
    /// </summary>
    /// <param name="byteArrayIn">Array de bytes a ser convertido.</param>
    /// <returns>Imagem formada pelo array de bytes.</returns>
    public static System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
    {
        MemoryStream ms = new MemoryStream(byteArrayIn);
        System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
        return returnImage;

    }

    public static List<MapeamentoImagens> listaMapeamento = new List<MapeamentoImagens>();

    public static void CarregarMapeamentos()
    {
        MapeamentoImagens mapeamento1 = new MapeamentoImagens(4, 1, 1, 130, 270);
        MapeamentoImagens mapeamento2 = new MapeamentoImagens(7, 1, 1, 290, 165);
        MapeamentoImagens mapeamento3 = new MapeamentoImagens(7, 1, 2, 390, 130);
        MapeamentoImagens mapeamento4 = new MapeamentoImagens(4, 1, 4, 150, 80);
        MapeamentoImagens mapeamento5 = new MapeamentoImagens(5, 1, 4, 235, 80);
        MapeamentoImagens mapeamento6 = new MapeamentoImagens(7, 1, 4, 390, 130);
        MapeamentoImagens mapeamento7 = new MapeamentoImagens(4, 1, 3, 150, 80);
        MapeamentoImagens mapeamento8 = new MapeamentoImagens(5, 1, 3, 150, 160);
        MapeamentoImagens mapeamento9 = new MapeamentoImagens(7, 1, 3, 390, 130);

        listaMapeamento.Add(mapeamento1);
        listaMapeamento.Add(mapeamento2);
        listaMapeamento.Add(mapeamento3);
        listaMapeamento.Add(mapeamento4);
        listaMapeamento.Add(mapeamento5);
        listaMapeamento.Add(mapeamento6);
        listaMapeamento.Add(mapeamento7);
        listaMapeamento.Add(mapeamento8);
        listaMapeamento.Add(mapeamento9);

    }

    public static MapeamentoImagens obterImagemMapeada(Postagem postagem)
    {
        ClasseAuxiliar.CarregarMapeamentos();
        MapeamentoImagens imagemMapeada = new MapeamentoImagens();

        foreach (MapeamentoImagens map in ClasseAuxiliar.listaMapeamento)
        {
            if (map.LocalPostagem == postagem.Local &&
                map.PaginaPostagem == postagem.Pagina &&
                map.TipoPostagem == postagem.Tipo)
            {
                imagemMapeada = map;
            }
        }

        return imagemMapeada;
    }


}
