using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloNota.Repositorios;
using Negocios.ModuloNota.Processos;
using Negocios.ModuloNota.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloNota.Processos
{
    /// <summary>
    /// Classe NotaProcesso
    /// </summary>
    public class NotaProcesso : Singleton<NotaProcesso>, INotaProcesso
    {
        #region Atributos
        private INotaRepositorio notaRepositorio = null;
        #endregion

        #region Construtor
        public NotaProcesso()
        {
            notaRepositorio = NotaFabrica.INotaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Nota nota)
        {
            this.notaRepositorio.Incluir(nota);

        }

        public void Excluir(Nota nota)
        {
            this.notaRepositorio.Excluir(nota);
        }

        public void Alterar(Nota nota)
        {
            this.notaRepositorio.Alterar(nota);
        }

        public List<Nota> Consultar(Nota nota, TipoPesquisa tipoPesquisa)
        {
            List<Nota> notaList = this.notaRepositorio.Consultar(nota,tipoPesquisa);           

            return notaList;
        }

        public List<Nota> Consultar()
        {
            List<Nota> notaList = this.notaRepositorio.Consultar();

            return notaList;
        }

        public void Confirmar()
        {
            this.notaRepositorio.Confirmar();
        }

        #endregion
    }
}