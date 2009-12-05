using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWindowsForms
{
    public partial class telaAluno : Form
    {
        public telaAluno()
        {
            InitializeComponent();
        }

        private void btnResponsaveis_Click(object sender, EventArgs e)
        {
            telaAlunoResponsavel telaAlunoRespons = new telaAlunoResponsavel();
            telaAlunoRespons.Show();
        }
    }
}
