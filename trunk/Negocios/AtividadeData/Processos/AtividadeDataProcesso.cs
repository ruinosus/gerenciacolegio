using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAtividadeData.Repositorios;
using Negocios.ModuloAtividadeData.Processos;
using Negocios.ModuloAtividadeData.Fabricas;

namespace Negocios.ModuloAtividadeData.Processos
{
    /// <summary>
    /// Classe AtividadeDataProcesso
    /// </summary>
    public class AtividadeDataProcesso : Singleton<AtividadeDataProcesso>, IAtividadeDataProcesso
    {
        #region Atributos
        private IAtividadeDataRepositorio atividadeDataRepositorio = null;
        #endregion

        #region Construtor
        public AtividadeDataProcesso()
        {
            atividadeDataRepositorio = AtividadeDataFabrica.IAtividadeDataInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(AtividadeData atividadeData)
        {
            this.atividadeDataRepositorio.Incluir(atividadeData);

        }

        public void Excluir(AtividadeData atividadeData)
        {
            this.atividadeDataRepositorio.Excluir(atividadeData);
        }

        public void Alterar(AtividadeData atividadeData)
        {
            this.atividadeDataRepositorio.Alterar(atividadeData);
        }

        public List<AtividadeData> Consultar(AtividadeData atividadeData)
        {
            List<AtividadeData> atividadeDataList = this.atividadeDataRepositorio.Consultar(atividadeData);           

            return atividadeDataList;
        }

        public List<AtividadeData> Consultar()
        {
            List<AtividadeData> atividadeDataList = this.atividadeDataRepositorio.Consultar();

            return atividadeDataList;
        }



        public void Confirmar()
        {
            this.atividadeDataRepositorio.Confirmar();
        }

        #endregion
    }
}