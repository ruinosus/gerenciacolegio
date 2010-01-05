using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavelAluno.Constantes;

namespace Negocios.ModuloResponsavelAluno.Excecoes
{
    /// <summary>
    /// Classe ResponsavelAlunoNaoIncluidoExcecao
    /// </summary>
    public class ResponsavelAlunoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ResponsavelAlunoNaoIncluidoExcecao()
            : base(ResponsavelAlunoConstantes.RESPONSAVELALUNO_NAOINCLUIDO)
        { }
    }
}