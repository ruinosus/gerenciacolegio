using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividadeTurma.Constantes;

namespace Negocios.ModuloAlunoAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeTurmaNaoExcluidoExcecao
    /// </summary>
    public class AlunoAtividadeTurmaNaoExcluidoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeTurmaNaoExcluidoExcecao()
            : base(AlunoAtividadeTurmaConstantes.ALUNOATIVIDADETURMA_NAOEXCLUIDO)
        { }
    }
}