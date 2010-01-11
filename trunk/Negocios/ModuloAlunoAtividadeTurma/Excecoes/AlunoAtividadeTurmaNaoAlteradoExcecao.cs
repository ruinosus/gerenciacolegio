using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloAlunoAtividadeTurma.Constantes;

namespace Negocios.ModuloAlunoAtividadeTurma.Excecoes
{
    /// <summary>
    /// Classe AlunoAtividadeTurmaNaoAlteradoExcecao
    /// </summary>
    public class AlunoAtividadeTurmaNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public AlunoAtividadeTurmaNaoAlteradoExcecao()
            : base(AlunoAtividadeTurmaConstantes.ALUNOATIVIDADETURMA_NAOALTERADO)
        { }
    }
}