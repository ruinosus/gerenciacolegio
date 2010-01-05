using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloSala.Repositorios;
using Negocios.ModuloSala.Processos;
using Negocios.ModuloSala.Fabricas;

namespace Negocios.ModuloSala.Processos
{
    /// <summary>
    /// Classe SalaProcesso
    /// </summary>
    public class SalaProcesso : Singleton<SalaProcesso>, ISalaProcesso
    {
        #region Atributos
        private ISalaRepositorio salaRepositorio = null;
        #endregion

        #region Construtor
        public SalaProcesso()
        {
            salaRepositorio = SalaFabrica.ISalaInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Sala sala)
        {
            this.salaRepositorio.Incluir(sala);

        }

        public void Excluir(Sala sala)
        {
            this.salaRepositorio.Excluir(sala);
        }

        public void Alterar(Sala sala)
        {
            this.salaRepositorio.Alterar(sala);
        }

        public List<Sala> Consultar(Sala sala)
        {
            List<Sala> salaList = this.salaRepositorio.Consultar(sala);           

            return salaList;
        }

        public List<Sala> Consultar()
        {
            List<Sala> salaList = this.salaRepositorio.Consultar();

            return salaList;
        }
        public void Confirmar()
        {
            this.salaRepositorio.Confirmar();
        }

        #endregion
    }
}