using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavelAluno.Constantes;

namespace Negocios.ModuloResponsavelAluno.Excecoes
{
    /// <summary>
    /// Classe ResponsavelAlunoNaoExcluidoExcecao
    /// </summary>
    public class ResponsavelAlunoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ResponsavelAlunoNaoExcluidoExcecao()
            : base(ResponsavelAlunoConstantes.RESPONSAVELALUNO_NAOEXCLUIDO)
        { }
    }
}