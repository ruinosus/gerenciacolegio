using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class ucMenuInferior : UserControl
    {

        //public string TituloCadastrar { get; set; }
        public ucMenuInferior()
        {
            InitializeComponent();
            //TituloCadastrar = "Salvar Informações";
        }


        #region BUTTON VOLTAR

        public delegate void delegateVoltar();
        public event delegateVoltar EventoVoltar;


        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Voltar";
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (EventoVoltar != null) 
                EventoVoltar();
        }


        #endregion

        #region BUTTON SALVAR

        public delegate void delegateCadastrar();
        public event delegateCadastrar EventoCadastrar;

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ESCREVER O CODIGO SALVAR AQUI");
            if (EventoCadastrar != null)
                EventoCadastrar();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            lblInfoControles.Visible = true;
            lblInfoControles.Text = "Salvar Informações";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblInfoControles.Visible = false;
        }

        #endregion
    }
}
