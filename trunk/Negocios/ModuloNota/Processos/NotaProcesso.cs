using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloBasico.Singleton;
using Negocios.ModuloNota.Repositorios;
using Negocios.ModuloNota.Processos;
using Negocios.ModuloNota.Fabricas;
using Negocios.ModuloBasico.Enums;
using Negocios.ModuloNota.Excecoes;

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
            try
            {
                if (nota.ID == 0)
                    throw new NotaNaoExcluidaExcecao();

                List<Nota> resultado = notaRepositorio.Consultar(nota, TipoPesquisa.E);

                if (resultado == null || resultado.Count <= 0 || resultado.Count > 1)
                    throw new NotaNaoExcluidaExcecao();

                resultado[0].Status = (int)Status.Inativo;
                this.Alterar(resultado[0]);
            }
            catch (Exception e)
            {

                throw e;
            }
            //this.notaRepositorio.Excluir(nota);
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