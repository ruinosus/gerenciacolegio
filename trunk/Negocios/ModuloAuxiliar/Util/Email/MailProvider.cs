using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Text;

/// <summary>
/// Summary description for MailProvider
/// </summary>
/// 
namespace Negocios.ModuloAuxiliar.Util.Email
{
    public class MailProvider
    {
        private MailProvider()
        {

        }

        public static void EnviarEmail(MailMessage mail)
        {
            //IConfiguracaoProcesso config = new ConfiguracaoProcesso();

            //SmtpClient cliente = new SmtpClient(config.GetConfiguracao("MAIL_HOST"), Convert.ToInt32(config.GetConfiguracao("MAIL_PORT")));

            SmtpClient cliente = new SmtpClient();

            if (cliente != null)
                cliente.Send(mail);
        }

        public static void EnviarEmail(string de, string para, string assunto, string corpo)
        {
            MailMessage message = new MailMessage(de, para, assunto, corpo);
            EnviarEmail(message);
        }
    }
}
