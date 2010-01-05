using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAluno.Constantes;

namespace Negocios.ModuloAluno.Excecoes
{
    /// <summary>
    /// Classe AlunoNaoExcluidoExcecao
    /// </summary>
    public class AlunoNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoNaoExcluidoExcecao()
            : base(AlunoConstantes.ALUNO_NAOEXCLUIDO)
        { }
    }
}