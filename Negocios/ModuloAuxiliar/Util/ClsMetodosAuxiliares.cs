using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Negocios.ModuloAuxiliar.Util
{
    /// <summary>
    /// Biblioteca de métodos comuns.
    /// </summary>
    public class ClsMetodosAuxiliares
    {

        /// <summary>
        /// Retorna o valor enviado no POST.
        /// </summary>
        /// <param name="IdControl">Id do controle na página.</param>
        /// <returns>O Valor atribuído ao controle antes do form.submit().</returns>
        public static string GetValueForm(string IdControl)
        {
            string strReturn = "";
            try
            {
                for (int i = 0; i < System.Web.HttpContext.Current.Request.Form.Count; i++)
                {
                    string[] strKeys = System.Web.HttpContext.Current.Request.Form.AllKeys[i].ToString().Split('$');
                    if (strKeys.Length > -1)
                    {
                        string strKey = strKeys[strKeys.Length - 1];
                        if (IdControl.ToUpper().Trim() == strKey.ToUpper().Trim())
                        {
                            strReturn = System.Web.HttpContext.Current.Request.Form[i].ToString();
                            break;
                        }
                    }
                }
            }
            catch { }
            return strReturn;
        }

        /// <summary>
        /// Verifica se deve limpar todos os elementos de SESSION utilizados na página em questão.
        /// </summary>
        /// <returns>True se houver 'load=1' na querystring.</returns>
        public static bool IsClearSessionOnLoad()
        {
            bool IsClear = false;
            try
            {
                IsClear = (System.Web.HttpContext.Current.Request["load"] != null &&
                    Convert.ToString(System.Web.HttpContext.Current.Request["load"]) == "1");
            }
            catch { IsClear = false; }
            return IsClear;
        }

        /// <summary>
        /// Verifica se o Load() da página deve ser igual ao IsPostBack.
        /// </summary>
        /// <returns>True se houver 'load=2' na querystring.</returns>
        public static bool IsPageReturned()
        {
            bool IsReturned = false;
            try
            {
                IsReturned = (System.Web.HttpContext.Current.Request["load"] != null &&
                    Convert.ToString(System.Web.HttpContext.Current.Request["load"]) == "2");
            }
            catch { IsReturned = false; }
            return IsReturned;
        }

        /// <summary>
        /// Verifica se uma data informada é válida.
        /// </summary>
        /// <param name="strDate">A data informada.</param>
        /// <returns>TRUE se a data for válida.</returns>
        public static bool IsDate(string strDate)
        {
            DateTime DateValue = default(DateTime);
            bool IsValid = DateTime.TryParse(strDate, out DateValue);
            return (IsValid & DateValue != default(DateTime));
        }

        /// <summary>
        /// Verifica se um valor informado é numérico.
        /// </summary>
        /// <param name="strValue">O valor informado</param>
        /// <returns>TRUE se o valor for numérico.</returns>
        public static bool IsNumeric(string strValue)
        {
            double dblValue = 0;
            return double.TryParse(strValue, out dblValue);
        }

        /// <summary>
        /// Redirect para uso quando necessário dentro de UpdatePanel.
        /// </summary>
        /// <param name="url">Url a ser redirecionada.</param>
        /// <param name="Page">Page (This.page)</param>
        public static void Redirect_Ajax(string url, System.Web.UI.Page Page)
        {
            string strRedirect = @"window.location='" + url + "'";
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "redirect", strRedirect, true);
        }

        /// <summary>
        /// Retorna a instância do objeto UsuarioSistemaVO referente ao usuário logado no sistema.
        /// </summary>
        /// <returns>Objeto UsuarioSistemaVO instanciado com os dados.</returns>
        /*  public static Negocios.ModuloControleAcesso.VOs.UsuarioSistemaVO UsuarioLogado()
          {
              Negocios.ModuloControleAcesso.VOs.UsuarioSistemaVO Usuario = new Negocios.ModuloControleAcesso.VOs.UsuarioSistemaVO();
              try
              {
                  if (System.Web.HttpContext.Current.Session["usuarioLogado"] == null)
                  {
                      Negocios.ModuloPedido.Fachadas.IFachadaServicos fachada = new Negocios.ModuloPedido.Fachadas.FachadaServicos();
                      MembershipUser memberShipUser = Membership.GetUser(true);
                      Usuario = fachada.GetSinteseUser(memberShipUser);
                  }
                  else
                  {
                      Usuario = (Negocios.ModuloControleAcesso.VOs.UsuarioSistemaVO)System.Web.HttpContext.Current.Session["usuarioLogado"];
                  }
              }
              catch { Usuario = null; }
              return Usuario;
          }*/



    }
}