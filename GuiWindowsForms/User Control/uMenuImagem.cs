using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GuiWindowsForms
{
    public partial class uMenuImagem : UserControl
    {
        public uMenuImagem()
        {
            InitializeComponent();
        }

        private Image imagemAuxiliar = null;

        /// <summary>
        /// Método para carregar dados do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public void limparFigura()
        {
            pctImagem.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
        }
        
        public void carregaResponsavel(Responsavel responsavel)
        {
            if (responsavel != null)
            {
                lblAtivo.Text = "Ativo - AINDA POR FAZER";
                lblFoneEmerg.Text = responsavel.Fone;
                lblMatricula.Text = "xxxx.xxx.xx.xxx - AINDA POR FAZER";
                lblNomeAluno.Text = responsavel.Nome;
                lblSerie.Text = "AINDA POR FAZER";
                if (responsavel.Imagem != null && responsavel.Imagem.Length != 0)
                {
                    pctImagem.Image = arrayParaImagem(responsavel.Imagem);
                }
            }
            else
            {
                lblAtivo.Text = "";
                lblFoneEmerg.Text = "";
                lblMatricula.Text = "";
                lblNomeAluno.Text = "";
                lblSerie.Text = "";
            }
        }

        public void ocultarBotaoAdicionarImagem()
        {
            btnAdicionarImagem.Visible = false;
        }

        public Responsavel retornaResponsavel(Responsavel responsavel)
        {
            if (pctImagem.Image != null)
            {
                responsavel.Imagem = imagemParaArray(imagemAuxiliar);
            }

            return responsavel;
        }

        /// <summary>
        /// Método para carregar dados do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void carregaAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                lblAtivo.Text = "Ativo - AINDA POR FAZER";
                lblFoneEmerg.Text = aluno.FoneEmergencia;
                lblMatricula.Text = "xxxx.xxx.xx.xxx - AINDA POR FAZER";
                lblNomeAluno.Text = aluno.Nome;
                lblSerie.Text = "AINDA POR FAZER";
                if (aluno.Imagem != null && aluno.Imagem.Length != 0)
                {
                    pctImagem.Image = arrayParaImagem(aluno.Imagem);
                }
            }
            else
            {
                lblAtivo.Text = "";
                lblFoneEmerg.Text = "";
                lblMatricula.Text = "";
                lblNomeAluno.Text = "";
                lblSerie.Text = "";
            }
        }

        public Aluno retornaAluno(Aluno aluno)
        {
            if (pctImagem.Image != null)
            {
                aluno.Imagem = imagemParaArray(imagemAuxiliar);
            }
            
            return aluno;
        }

        /// <summary>
        /// Método para adicionar uma imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            pctImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pctImagem.Image = retornarImagem();
            imagemAuxiliar = pctImagem.Image;
        }

        /// <summary>
        /// Função que retorna a imagem e chama a caixa de diálogo para associação.
        /// </summary>
        /// <returns></returns>
        
        private Image retornarImagem()
        {
            Bitmap imagem = null;

            //openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        imagem = new Bitmap(new Bitmap(openFileDialog1.OpenFile()));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                openFileDialog1.Dispose();
            }
            else
            {
                openFileDialog1.Dispose();
            }

            return imagem;
        }

        /// <summary>
        /// Função que converte de um array de byte para uma imagem
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private Image arrayParaImagem(Byte[] imagem)
        {

            MemoryStream ms = new MemoryStream(imagem,0,imagem.Length);

            ms.Write(imagem, 0, imagem.Length);

            return Image.FromStream(ms, true);
        }

        /// <summary>
        /// Função que converte de uma imagem para um array de byte
        /// </summary>
        /// <param name="imagem"></param>
        /// <returns></returns>
        private byte[] imagemParaArray(Image imageIn)
        {

            MemoryStream ms = new MemoryStream();

            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();

        }
    }
}
