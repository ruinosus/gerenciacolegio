using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ModuloBasico.VOs;

namespace GuiWindowsForms
{
    public partial class telaRelatorioBoletoMensalidade : Form
    {
        public telaRelatorioBoletoMensalidade()
        {
            InitializeComponent();
        }

        private void telaRelatorioBoletoMensalidade_Load(object sender, EventArgs e)
        {
            Memoria memoria = Memoria.Instance;
            if (memoria.Aluno != null)
            {
                //BoletoMensalidadeDataTableTableAdapter ta = new BoletoMensalidadeDataTableTableAdapter();
                //GuiWindowsForms.Relatorios.BoletoMensalidadeDataSet.BoletoMensalidadeDataTableDataTable dataTable = ta.GetData(memoria.Aluno.ID);
                //BoletoMensalidadeRelatorio1.SetDataSource((DataTable)dataTable);
                //crystalReportViewer1.ReportSource = BoletoMensalidadeRelatorio1;
                //BoletoMensalidadeRelatorio1.Refresh();
                //crystalReportViewer1.Zoom(1);
            }
        }
    }
}
