using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatriculaVinculo.Constantes;

namespace Negocios.ModuloMatriculaVinculo.Excecoes
{
    /// <summary>
    /// Classe MatriculaVinculoNaoAlteradaExcecao
    /// </summary>
    public class MatriculaVinculoNaoAlteradaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public MatriculaVinculoNaoAlteradaExcecao()
            : base(MatriculaVinculoConstantes.MATRICULAVINCULO_NAOALTERADA)
        { }
    }
}