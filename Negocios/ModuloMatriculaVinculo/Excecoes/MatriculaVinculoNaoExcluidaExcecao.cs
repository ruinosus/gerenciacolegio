using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloMatriculaVinculo.Constantes;

namespace Negocios.ModuloMatriculaVinculo.Excecoes
{
    /// <summary>
    /// Classe MatriculaVinculoNaoExcluidaExcecao
    /// </summary>
    public class MatriculaVinculoNaoExcluidaExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public MatriculaVinculoNaoExcluidaExcecao()
            : base(MatriculaVinculoConstantes.MATRICULAVINCULO_NAOEXCLUIDA)
        { }
    }
}