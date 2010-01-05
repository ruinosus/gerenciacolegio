using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAluno.Constantes;

namespace Negocios.ModuloAluno.Excecoes
{
    /// <summary>
    /// Classe AlunoNaoAlteradoExcecao
    /// </summary>
    public class AlunoNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoNaoAlteradoExcecao()
            : base(AlunoConstantes.ALUNO_NAOALTERADO)
        { }
    }
}