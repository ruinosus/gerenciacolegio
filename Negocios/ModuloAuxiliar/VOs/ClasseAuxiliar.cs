using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloAuxiliar.Excecoes;
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
using Negocios.ModuloControleAcesso.VOs;

/// <summary>
/// Summary description for ClasseAuxiliar
/// </summary>
public partial class ClasseAuxiliar
{

    private static UsuarioSistemaVO usuarioLogado;

    public static UsuarioSistemaVO UsuarioLogado
    {
        get
        {
            if (System.Web.HttpContext.Current.Session["UsuarioLogado"] != null)
                usuarioLogado = (UsuarioSistemaVO)System.Web.HttpContext.Current.Session["UsuarioLogado"];

            return usuarioLogado;
        }
        private set { usuarioLogado = value; }
    }

    public static void ValidarUsuarioLogado(bool validarAdministrador)
    {
        if (UsuarioLogado != null)
        {
            if (validarAdministrador)
            {
               if (!UsuarioLogado.IsAdministrador)
                    System.Web.HttpContext.Current.Response.Redirect(ConstantesAuxiliar.PAGINA_PRINCIPAL, false);
            }
        }
        else
            System.Web.HttpContext.Current.Response.Redirect(ConstantesAuxiliar.PAGINA_PRINCIPAL, false);

    }

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

    

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;

        }
        
    
}
