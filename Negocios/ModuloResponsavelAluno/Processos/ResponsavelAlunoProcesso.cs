using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloAuxiliar.Singleton;
using Negocios.ModuloResponsavelAluno.Repositorios;
using Negocios.ModuloResponsavelAluno.Processos;
using Negocios.ModuloResponsavelAluno.Fabricas;

namespace Negocios.ModuloResponsavelAluno.Processos
{
    /// <summary>
    /// Classe ResponsavelAlunoProcesso
    /// </summary>
    public class ResponsavelAlunoProcesso : Singleton<ResponsavelAlunoProcesso>, IResponsavelAlunoProcesso
    {
        #region Atributos
        private IResponsavelAlunoRepositorio responsavelAlunoRepositorio = null;
        #endregion

        #region Construtor
        public ResponsavelAlunoProcesso()
        {
            responsavelAlunoRepositorio = ResponsavelAlunoFabrica.IResponsavelAlunoInstance;
        }

        #endregion


        #region Métodos da Interface

        public void Incluir(ResponsavelAluno responsavelAluno)
        {
            this.responsavelAlunoRepositorio.Incluir(responsavelAluno);

        }

        public void Excluir(ResponsavelAluno responsavelAluno)
        {
            this.responsavelAlunoRepositorio.Excluir(responsavelAluno);
        }

        public void Alterar(ResponsavelAluno responsavelAluno)
        {
            this.responsavelAlunoRepositorio.Alterar(responsavelAluno);
        }

        public List<ResponsavelAluno> Consultar(ResponsavelAluno responsavelAluno)
        {
            List<ResponsavelAluno> responsavelAlunoList = this.responsavelAlunoRepositorio.Consultar(responsavelAluno);           

            return responsavelAlunoList;
        }

        public List<ResponsavelAluno> Consultar()
        {
            List<ResponsavelAluno> responsavelAlunoList = this.responsavelAlunoRepositorio.Consultar();

            return responsavelAlunoList;
        }

        public void Confirmar()
        {
            this.responsavelAlunoRepositorio.Confirmar();
        }

        #endregion
    }
}