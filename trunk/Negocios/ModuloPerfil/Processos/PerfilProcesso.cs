using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloPerfil.Repositorios;
using Negocios.ModuloPerfil.Processos;
using Negocios.ModuloPerfil.Fabricas;
using Negocios.ModuloBasico.Enums;

namespace Negocios.ModuloPerfil.Processos
{
    /// <summary>
    /// Classe PerfilProcesso
    /// </summary>
    public class PerfilProcesso : Singleton<PerfilProcesso>, IPerfilProcesso
    {
        #region Atributos
        private IPerfilRepositorio perfilRepositorio = null;
        #endregion

        #region Construtor
        public PerfilProcesso()
        {
            perfilRepositorio = PerfilFabrica.IPerfilInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(Perfil perfil)
        {
            this.perfilRepositorio.Incluir(perfil);

        }

        public void Excluir(Perfil perfil)
        {
            //this.perfilRepositorio.Excluir(perfil);
        }

        public void Alterar(Perfil perfil)
        {
            this.perfilRepositorio.Alterar(perfil);
        }

        public List<Perfil> Consultar(Perfil perfil, TipoPesquisa tipoPesquisa)
        {
            List<Perfil> perfilList = this.perfilRepositorio.Consultar(perfil,tipoPesquisa);           

            return perfilList;
        }

        public List<Perfil> Consultar()
        {
            List<Perfil> perfilList = this.perfilRepositorio.Consultar();

            return perfilList;
        }

        public void Confirmar()
        {
            perfilRepositorio.Confirmar();
        }


        #endregion



       


      

     
    }
}