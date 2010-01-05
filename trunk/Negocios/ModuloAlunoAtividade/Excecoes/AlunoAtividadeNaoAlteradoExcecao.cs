using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividade.Constantes;

namespace Negocios.ModuloAlunoAtividade.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeNaoAlteradoExcecao
    /// </summary>
    public class AlunoAtividadeNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeNaoAlteradoExcecao()
            : base(AlunoAtividadeConstantes.ALUNOATIVIDADE_NAOALTERADO)
        { }
    }
}