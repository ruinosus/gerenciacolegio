using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloResponsavel.Processos;
using Negocios.ModuloBasico.VOs;

namespace GuiWindowsForms
{
    public partial class telaAlunoResponsavelBusca : Form
    {
        public telaAlunoResponsavelBusca()
        {
            InitializeComponent();
            Pesquisar();
        }

        #region Eventos
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void dgvResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarResponsavel();
        }

        private void btnSelecionarResponsavel_Click(object sender, EventArgs e)
        {
            SelecionarResponsavel();
        } 
        #endregion

        #region Métodos Privados
        private void SelecionarResponsavel()
        {
            if (dgvResponsavel.CurrentRow != null)
            {
                Memoria.Instance.Responsavel = ((List<Responsavel>)dgvResponsavel.DataSource)[dgvResponsavel.CurrentRow.Index];
                this.Close();
            }
        }

        private void Pesquisar()
        {
            IResponsavelProcesso processo = ResponsavelProcesso.Instance;
            Responsavel responsavel = new Responsavel();
            responsavel.Nome = txtBusca.Text;
            dgvResponsavel.AutoGenerateColumns = false;
            List<Responsavel> resultado = processo.Consultar(responsavel, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
            dgvResponsavel.DataSource = resultado;
            AjustarBotoes();
        }

        private void AjustarBotoes()
        {
            btnSelecionarResponsavel.Enabled = ((List<Responsavel>)dgvResponsavel.DataSource).Count > 0;
        }
        #endregion
    }
}
