using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAluno.Constantes;

namespace Negocios.ModuloAluno.Excecoes
{
    /// <summary>
    /// Classe AlunoNaoIncluidoExcecao
    /// </summary>
    public class AlunoNaoIncluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoNaoIncluidoExcecao()
            : base(AlunoConstantes.ALUNO_NAOINCLUIDO)
        { }
    }
}