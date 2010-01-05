using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloResponsavelAluno.Constantes;

namespace Negocios.ModuloResponsavelAluno.Excecoes
{
    /// <summary>
    /// Classe ResponsavelAlunoNaoAlteradoExcecao
    /// </summary>
    public class ResponsavelAlunoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public ResponsavelAlunoNaoAlteradoExcecao()
            : base(ResponsavelAlunoConstantes.RESPONSAVELALUNO_NAOALTERADO)
        { }
    }
}