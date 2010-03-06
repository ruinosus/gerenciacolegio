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


}
