using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModuloAuxiliar.Excecoes;

namespace Negocios.ModuloAuxiliar.Excecoes
{
    /// <summary>
    /// Summary description for NenhumCriterioInformadoExcecao
    /// </summary>
    public class NenhumCriterioInformadoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem.
        /// </summary>
        public NenhumCriterioInformadoExcecao()
            : base(ConstantesAuxiliar.NENHUM_CRITERIO_INFORMADO)
        { }   //
        
    }
}