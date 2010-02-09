using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloAluno.Processos;

using GuiWindowsForms.Relatorios;
using Negocios.ModuloBasico.VOs;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace GuiWindowsForms
{
    public partial class telaLogin : Form
    {

        private static telaLogin telalogin;

        private static bool IsShown = false;

        public static telaLogin getInstancia()
        {
            if (telalogin == null)
            {
                telalogin = new telaLogin();
            }
            return telalogin;
        }

        public new void Show()
        {
            if (IsShown)
                base.Show();
            else
            {
                base.Show();
                IsShown = true;
            }
        }

        public telaLogin()
        {
            InitializeComponent();
        }

        #region EVENTOS
        private void btnLogar_Click(object sender, EventArgs e)
        {

            //Conexao abc = new Conexao();

            #region Validação dos campos de login e senha

            //try
            //{
            //    lblErro.Visible = false;

            //    if (String.IsNullOrEmpty(txtLogin.Text))
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("Favor digitar um login. O campo não pode estar vazio!");
            //    }
            //    else if (txtLogin.Text.Length < 8 || txtLogin.Text.Length > 20)
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("O login deve conter entre 8 e 20 dígitos.");
            //    }
            //    else
            //    {
            //        if(String.IsNullOrEmpty(txtSenha.Text))
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe a senha");
            //            throw new Exception("Favor digitar uma senha. O campo não pode estar vazio!");
            //        }
            //        else if (txtSenha.Text.Length < 8 || txtSenha.Text.Length > 20)
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe o login");
            //            throw new Exception("A senha deve conter entre 8 e 20 dígitos.");
            //        }
            //        else
            //        {
            //            if (txtLogin.Text == "conhecer" & txtSenha.Text == "conhecer")
            //            {
                            this.Hide();
                            Program.ultimaTela = 9;
                            Program.usuarioLogin = "Olá, Liane";
                            telaPrincipal telaalunoprincipal = telaPrincipal.getInstancia();
                            telaalunoprincipal.Show();
            //            }
            //            else
            //            {
            //                txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //                errorProviderTela.SetError(txtLogin, "Login errado");
            //                throw new Exception("Dados inexistentes, insira os dados corretamente.");
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    lblErro.Visible = true;
            //    lblErro.Text = ex.Message;
            //}

            #endregion
        }


        
        ///  Métodos que controlam a mudança de cor dos campos quando selecionados ou não
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Atualiza a cor da textbox ao ser ativada como controle principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        /// <summary>
        /// Altera a cor para a cor original do controle ao perder a seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = System.Drawing.Color.White;
        }

        private void telaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void btnLogar_Enter(object sender, EventArgs e)
        {
            //Conexao c = new Conexao();

            //c.Banco = "ColegioDB";
            //c.Caminho = "Localhost";
            //c.Senha = "123";
            //c.Usuario = "root";

            //SoapFormatter s = new SoapFormatter();
            //FileStream f = File.Create("config.xml");
            //s.Serialize(f, c);
            //f.Close();
            #region Validação dos campos de login e senha

            //try
            //{
            //    lblErro.Visible = false;

            //    if (String.IsNullOrEmpty(txtLogin.Text))
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("Favor digitar um login. O campo não pode estar vazio!");
            //    }
            //    else if (txtLogin.Text.Length < 8 || txtLogin.Text.Length > 20)
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("O login deve conter entre 8 e 20 dígitos.");
            //    }
            //    else
            //    {
            //        if (String.IsNullOrEmpty(txtSenha.Text))
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe a senha");
            //            throw new Exception("Favor digitar uma senha. O campo não pode estar vazio!");
            //        }
            //        else if (txtSenha.Text.Length < 8 || txtSenha.Text.Length > 20)
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe o login");
            //            throw new Exception("A senha deve conter entre 8 e 20 dígitos.");
            //        }
            //        else
            //        {
            //            if (txtLogin.Text == "conhecer" & txtSenha.Text == "conhecer" )
            //            {
                            this.Hide();
                            Program.ultimaTela = 9;
                            Program.usuarioLogin = "Olá, Liane";
                            telaPrincipal telaalunoprincipal = telaPrincipal.getInstancia();
                            telaalunoprincipal.Show();
        //                }
        //                else 
        //                {
        //                    txtLogin.BackColor = System.Drawing.Color.LawnGreen;
        //                    errorProviderTela.SetError(txtLogin, "Login errado");
        //                    throw new Exception("Dados inexistentes, insira os dados corretamente.");
        //                }
  
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblErro.Visible = true;
        //        lblErro.Text = ex.Message;
        //    }

            #endregion
        }

        private void txtLogin_TextChanged_1(object sender, EventArgs e)
        {
            errorProviderTela.Clear();
        }

        private void txtLogin_Enter_1(object sender, EventArgs e)
        {
            #region Validação dos campos de login e senha

            //try
            //{
            //    lblErro.Visible = false;

            //    if (String.IsNullOrEmpty(txtLogin.Text))
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("Favor digitar um login. O campo não pode estar vazio!");
            //    }
            //    else if (txtLogin.Text.Length < 8 || txtLogin.Text.Length > 20)
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("O login deve conter entre 8 e 20 dígitos.");
            //    }
            //    else
            //    {
            //        if (String.IsNullOrEmpty(txtSenha.Text))
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe a senha");
            //            throw new Exception("Favor digitar uma senha. O campo não pode estar vazio!");
            //        }
            //        else if (txtSenha.Text.Length < 8 || txtSenha.Text.Length > 20)
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe o login");
            //            throw new Exception("A senha deve conter entre 8 e 20 dígitos.");
            //        }
            //        else
            //        {
                        this.Hide();
                        Program.ultimaTela = 9;
                        Program.usuarioLogin = "Olá, Liane";
                        telaPrincipal telaalunoprincipal = telaPrincipal.getInstancia();
                        telaalunoprincipal.Show();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblErro.Visible = true;
        //        lblErro.Text = ex.Message;
        //    }

            #endregion
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            #region Validação dos campos de login e senha

            //try
            //{
            //    lblErro.Visible = false;

            //    if (String.IsNullOrEmpty(txtLogin.Text))
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("Favor digitar um login. O campo não pode estar vazio!");
            //    }
            //    else if (txtLogin.Text.Length < 8 || txtLogin.Text.Length > 20)
            //    {
            //        txtLogin.BackColor = System.Drawing.Color.LawnGreen;
            //        errorProviderTela.SetError(txtLogin, "Informe o login");
            //        throw new Exception("O login deve conter entre 8 e 20 dígitos.");
            //    }
            //    else
            //    {
            //        if (String.IsNullOrEmpty(txtSenha.Text))
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe a senha");
            //            throw new Exception("Favor digitar uma senha. O campo não pode estar vazio!");
            //        }
            //        else if (txtSenha.Text.Length < 8 || txtSenha.Text.Length > 20)
            //        {
            //            txtSenha.BackColor = System.Drawing.Color.LawnGreen;
            //            errorProviderTela.SetError(txtSenha, "Informe o login");
            //            throw new Exception("A senha deve conter entre 8 e 20 dígitos.");
            //        }
            //        else
            //        {
                        this.Hide();
                        Program.ultimaTela = 9;
                        Program.usuarioLogin = "Olá, Liane";
                        telaPrincipal telaalunoprincipal = telaPrincipal.getInstancia();
                        telaalunoprincipal.Show();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblErro.Visible = true;
        //        lblErro.Text = ex.Message;
        //    }

            #endregion
        }

        #endregion
    }
}
