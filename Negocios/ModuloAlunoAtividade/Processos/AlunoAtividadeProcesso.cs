using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloAlunoAtividade.Repositorios;
using Negocios.ModuloAlunoAtividade.Processos;
using Negocios.ModuloAlunoAtividade.Fabricas;

namespace Negocios.ModuloAlunoAtividade.Processos
{
    /// <summary>
    /// Classe AlunoAtividadeProcesso
    /// </summary>
    public class AlunoAtividadeProcesso : Singleton<AlunoAtividadeProcesso>, IAlunoAtividadeProcesso
    {
        #region Atributos
        private IAlunoAtividadeRepositorio alunoAtividadeRepositorio = null;
        #endregion

        #region Construtor
        public AlunoAtividadeProcesso()
        {
            alunoAtividadeRepositorio = AlunoAtividadeFabrica.IAlunoAtividadeInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(AlunoAtividade alunoAtividade)
        {
            this.alunoAtividadeRepositorio.Incluir(alunoAtividade);

        }

        public void Excluir(AlunoAtividade alunoAtividade)
        {
            this.alunoAtividadeRepositorio.Excluir(alunoAtividade);
        }

        public void Alterar(AlunoAtividade alunoAtividade)
        {
            this.alunoAtividadeRepositorio.Alterar(alunoAtividade);
        }

        public List<AlunoAtividade> Consultar(AlunoAtividade alunoAtividade)
        {
            List<AlunoAtividade> alunoAtividadeList = this.alunoAtividadeRepositorio.Consultar(alunoAtividade);           

            return alunoAtividadeList;
        }

        public List<AlunoAtividade> Consultar()
        {
            List<AlunoAtividade> alunoAtividadeList = alunoAtividadeRepositorio.Consultar();

            return alunoAtividadeList;
        }

        public void Confirmar()
        {
            alunoAtividadeRepositorio.Confirmar();
        }

        #endregion
    }
}