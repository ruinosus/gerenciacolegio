using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Negocios.ModuloBasico.Constantes;
using Negocios.ModuloPerfil.Constantes;

namespace Negocios.ModuloPerfil.Excecoes
{
    /// <summary>
    /// Classe PerfilNaoAlteradoExcecao
    /// </summary>
    public class PerfilNaoAlteradoExcecao: Exception
    {
        /// <summary>
        /// Contrutor da classe de exception, 
        /// passando como mensagem a constante. 
        /// </summary>
        public PerfilNaoAlteradoExcecao()
            : base(PerfilConstantes.PERFIL_NAOALTERADO)
        { }
    }
}