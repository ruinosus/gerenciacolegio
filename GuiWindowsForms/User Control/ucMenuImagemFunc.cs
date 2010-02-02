using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Negocios.ModuloBasico.Enums;

namespace GuiWindowsForms.User_Control
{
    public partial class ucMenuImagemFunc : UserControl
    {
        public ucMenuImagemFunc()
        {
            InitializeComponent();
        }

        private Image imagemAuxiliar = null;

        /// <summary>
        /// Método para carregar dados do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void carregaFuncionario(Funcionario funcionario)
        {
            if (funcionario.Status == (int)Status.Ativo)
            {
                lblAtivo.Text = "Ativo";
            }
            else
            {
                lblAtivo.ForeColor = System.Drawing.Color.Red;
                lblAtivo.Text = "Inativo";
            }
            lblFone.Text = funcionario.FoneEmergencia;
            lblFuncao.Text = funcionario.Cargo;
            lblNomeFuncionario.Text = funcionario.Nome;
            //if (funcionario.Imagem != null && funcionario.Imagem.Length != 0)
            //{
            //    pctImagem.Image = arrayParaImagem(funcionario.Imagem);
            //}
        }

        public Funcionario retornaFuncionario(Funcionario funcionario)
        {
            //if (pctImagem.Image != null)
            //{
            //    funcionario.Imagem = imagemParaArray(imagemAuxiliar);
            //}

            return funcionario;
        }


        //private void btnAdicionarImagem_Click(object sender, EventArgs e)
        //{
        //    pctImagem.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pctImagem.Image = retornarImagem();
        //    if (pctImagem.Image != null)
        //    {
        //        imagemAuxiliar = pctImagem.Image;
        //    }
        //}

        /// <summary>
        /// Função que retorna a imagem e chama a caixa de diálogo para associação.
        /// </summary>
        /// <returns></returns>

        //private Image retornarImagem()
        //{
        //    Bitmap imagem = null;

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        try
        //        {
        //            if (openFileDialog1.OpenFile() != null)
        //            {
        //                imagem = new Bitmap(new Bitmap(openFileDialog1.OpenFile()));
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        openFileDialog1.Dispose();
        //    }
        //    else
        //    {
        //        openFileDialog1.Dispose();
        //    }

        //    return imagem;
        //}

        /// <summary>
        /// Função que converte de um array de byte para uma imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        //private Image arrayParaImagem(Byte[] imagem)
        //{

        //    MemoryStream ms = new MemoryStream(imagem, 0, imagem.Length);

        //    ms.Write(imagem, 0, imagem.Length);

        //    return Image.FromStream(ms, true);
        //}

        ///// <summary>
        ///// Função que converte de uma imagem para um array de byte
        ///// </summary>
        ///// <param name="imagem"></param>
        ///// <returns></returns>
        //private byte[] imagemParaArray(Image imageIn)
        //{

        //    MemoryStream ms = new MemoryStream();

        //    imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

        //    return ms.ToArray();

        //}


        #region OCULTAR BOTAO ADICIONAR IMAGEM
        public void ocultarBotaoAdicionarImagem()
        {
            btnAdicionarImagem.Visible = false;
        }
        #endregion

    }
}
