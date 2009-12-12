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
    public partial class telaAlunoResponsavelBusca : Form
    {

        /*
         * Atributo para o Singleton da tela
         * Atributo para controle de exibição da tela
         * */

        private static telaAlunoResponsavelBusca telaalunoresponsavelbusca;

        private static bool IsShown = false;

        /// <summary>
        /// Padrão Singleton, verifica se a instância já esta em uso. Evita abertura de múltiplas instâncias
        /// </summary>
        /// <returns>retorna a instância da tela em uso ou uma nova</returns>

        public static telaAlunoResponsavelBusca getInstancia()
        {
            if (telaalunoresponsavelbusca == null)
            {
                telaalunoresponsavelbusca = new telaAlunoResponsavelBusca();
            }
            return telaalunoresponsavelbusca;
        }

        /// <summary>
        /// Construtor da tela
        /// </summary>

        public telaAlunoResponsavelBusca()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para verificar se a tela já esta sendo exibida ou não, avita que a tela seja descarregada da memória
        /// </summary>

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

        /// <summary>
        /// Evento para o fechamento da tela, não fecha de verdade, só a esconde, garantindo a usabilidade da tela
        /// pelo singleton
        /// </summary>
        /// <param name="sender">Tela</param>
        /// <param name="e">Cancela seu fechamento, permite só que seja ocultada</param>

        private void telaAlunoResponsavelBusca_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            IsShown = false;
            this.Hide();

            telaAlunoPrincipal telaalunoprincipal = telaAlunoPrincipal.getInstancia();
            telaalunoprincipal.Show();
        }
    }
}
