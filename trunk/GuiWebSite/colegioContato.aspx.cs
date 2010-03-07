using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class colegioContato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnEnviar_Click(object sender, EventArgs e)
    {
        MailMessage mensagem = new MailMessage();
        mensagem.To.Add(new MailAddress("secretaria@colegioconhecer.com.br"));
        mensagem.From = new MailAddress(txtEmail.Text); ;
        mensagem.Subject = "Email de: " + txtNome.Text;
        mensagem.Body =  " Tipo: " + DropDownList1.Text + "\n\n" + txtMensagem.Text;
        SmtpClient smtp = new SmtpClient("smtp.colegioconhecer.com.br");

        smtp.Send(mensagem);
    }
    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        txtNome.Text = null;
        txtEmail.Text = null;
        txtMensagem.Text = null;
        DropDownList1.SelectedIndex = 0;
    }
}
