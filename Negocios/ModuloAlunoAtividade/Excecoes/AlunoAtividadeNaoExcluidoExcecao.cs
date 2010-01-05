using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividade.Constantes;

namespace Negocios.ModuloAlunoAtividade.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeNaoExcluidoExcecao
    /// </summary>
    public class AlunoAtividadeNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeNaoExcluidoExcecao()
            : base(AlunoAtividadeConstantes.ALUNOATIVIDADE_NAOALTERADO)
        { }
    }
}