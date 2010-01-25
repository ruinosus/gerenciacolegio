using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatriculaVinculo.Constantes;

namespace Negocios.ModuloMatriculaVinculo.Excecoes
{
    /// <summary>
    /// Classe MatriculaVinculoNaoIncluidaExcecao
    /// </summary>
    public class MatriculaVinculoNaoIncluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public MatriculaVinculoNaoIncluidaExcecao()
            : base(MatriculaVinculoConstantes.MATRICULAVINCULO_NAOINCLUIDA)
        { }
    }
}