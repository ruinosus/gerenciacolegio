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
using Negocios.ModuloMatricula.Processos;

namespace GuiWindowsForms
{
    public partial class uMenuImagem : UserControl
    {
        public uMenuImagem()
        {
            InitializeComponent();
        }

        private Image imagemAuxiliar = null;
        private string numMatricula = null; 


        #region LIMPAR FIGURA
        public void limparFigura()
        {
            pctImagem.Image = global::GuiWindowsForms.Properties.Resources.simbolo_colegio;
        }
        #endregion

        //#region CARREGA RESPONSAVEL
        //public void carregaResponsavel(Responsavel responsavel)
        //{
        //    if (responsavel != null)
        //    {
        //        lblAtivo.Text = "Ativo - AINDA POR FAZER";
        //        lblFoneEmerg.Text = responsavel.Fone;
        //        lblMatricula.Text = "xxxx.xxx.xx.xxx - AINDA POR FAZER";
        //        lblNomeAluno.Text = responsavel.Nome;
        //        lblSerie.Text = "AINDA POR FAZER";
        //        if (responsavel.Imagem != null && responsavel.Imagem.Length != 0)
        //        {
        //            pctImagem.Image = arrayParaImagem(responsavel.Imagem);
        //        }
        //    }
        //    else
        //    {
        //        lblAtivo.Text = "";
        //        lblFoneEmerg.Text = "";
        //        lblMatricula.Text = "";
        //        lblNomeAluno.Text = "";
        //        lblSerie.Text = "";
        //    }
        //}
        //#endregion

        #region OCULTAR BOTAO ADICIONAR IMAGEM
        public void ocultarBotaoAdicionarImagem()
        {
            btnAdicionarImagem.Visible = false;
        }
        #endregion

        //#region RETORNA RESPONSAVEL
        //public Responsavel retornaResponsavel(Responsavel responsavel)
        //{
        //    if (pctImagem.Image != null)
        //    {
        //        responsavel.Imagem = imagemParaArray(imagemAuxiliar);
        //    }

        //    return responsavel;
        //}
        //#endregion

        #region CARREGA ALUNO
        /// <summary>
        /// Método para carregar dados do aluno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void carregaAluno(Aluno aluno)
        {
            if (aluno != null)
            {
                Matricula matricula = new Matricula();
                IMatriculaProcesso matriculaControlador = MatriculaProcesso.Instance;

                List<Matricula> matriculaAuxiliar = new List<Matricula>();

                matricula.Status = (int)Status.Ativo;
                matriculaAuxiliar = matriculaControlador.Consultar(matricula, TipoPesquisa.E);

                foreach (Matricula m in matriculaAuxiliar)
                {
                    if (m.AlunoID == aluno.ID)
                    {
                        numMatricula = m.NumMatricula;
                    }
                    else
                    {
                        numMatricula = null;
                    }
                }

                if (aluno.Status == (int)Status.Ativo)
                {
                    lblAtivo.Text = "Ativo";
                }
                else
                {
                    lblAtivo.ForeColor = System.Drawing.Color.Red;
                    lblAtivo.Text = "Inativo";
                }

                lblFoneEmerg.Text = aluno.FoneEmergencia;

                if (numMatricula != null)
                {
                    lblMatricula.Text = numMatricula;
                }
                else
                {
                    lblMatricula.ForeColor = System.Drawing.Color.Red;
                    lblMatricula.Text = "Aluno ainda não matriculado";
                }
                lblNomeAluno.Text = aluno.Nome;

                if (!String.IsNullOrEmpty(aluno.SerieAtual))
                {
                    lblSerie.Text = aluno.SerieAtual;
                }
                else
                {
                    lblSerie.ForeColor = System.Drawing.Color.Red;
                    lblSerie.Text = "Aluno ainda não matriculado em uma série";
                }
                if (aluno.Imagem != null && aluno.Imagem.Length > 0)
                {
                    pctImagem.Image = arrayParaImagem(aluno.Imagem);
                }
                else
                {
                    pctImagem.Image = null;
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
        #endregion

        #region RETORNA ALUNO
        public Aluno retornaAluno(Aluno aluno)
        {
            if (pctImagem.Image != null)
            {
                aluno.Imagem = imagemParaArray(imagemAuxiliar);
            }
            
            return aluno;
        }
        #endregion

        #region ADICIONAR IMAGEM
        /// <summary>
        /// Método para adicionar uma imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {

            pctImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            if (retornarImagem() != null)
            {
                pctImagem.Image = retornarImagem();
                imagemAuxiliar = pctImagem.Image;
            }
        }
        #endregion

        #region RETORNAR IMAGEM
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
        #endregion

        #region CONVERTE ARRAY DE BYTE PARA IMAGEM
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
        #endregion

        #region CONVERTE IMAGEM PARA ARRAY DE BYTE
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
        #endregion

    }
}
