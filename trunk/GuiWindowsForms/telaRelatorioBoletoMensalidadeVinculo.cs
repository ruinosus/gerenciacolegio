using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloBasico.VOs;
using Negocios.ModuloMatriculaVinculo.Processos;

namespace GuiWindowsForms
{
    public partial class telaRelatorioBoletoMensalidadeVinculo : Form
    {
        public telaRelatorioBoletoMensalidadeVinculo()
        {
            InitializeComponent();
        }

        private void telaRelatorioBoletoMensalidadeVinculo_Load(object sender, EventArgs e)
        {

            
            if (Memoria.Instance.Matricula != null)
            {
                IMatriculaVinculoProcesso processo = MatriculaVinculoProcesso.Instance;

                MatriculaVinculo matriculaVinculo = new MatriculaVinculo();
                matriculaVinculo.MatriculaMestreID = Memoria.Instance.Matricula.ID;

                DataTable data = processo.GerarRelatorio(matriculaVinculo, Negocios.ModuloBasico.Enums.TipoPesquisa.E);
                BoletoMensalidadeRelatorioVinculo1.SetDataSource((DataTable)data);
                crystalReportViewer1.ReportSource = BoletoMensalidadeRelatorioVinculo1;
                BoletoMensalidadeRelatorioVinculo1.Refresh();
                crystalReportViewer1.Zoom(1);
            }
        }
    }
}
