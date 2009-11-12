using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Negocios.ModuloComentario.Excecoes
{
    /// <summary>
    /// Summary description for ConstantesPostagem
    /// </summary>
    public static class ConstantesComentario
    {
        //Postagem
        public static readonly String COMENTARIO_INCLUIDOCOMSUCESSO = "Comentário incluido com sucesso.";
        public static readonly String COMENTARIO_EXCLUIDOCOMSUCESSO = "Comentário excluido com sucesso.";
        public static readonly String COMENTARIO_ALTERADOCOMSUCESSO = "Comentário alterado com sucesso.";
        public static readonly String COMENTARIO_NAOINCLUIDO = "Não foi possível Incluir o Comentário.";
        public static readonly String COMENTARIO_NAOEXCLUIDO = "Não foi possível Excluir o Comentário.";
        public static readonly String COMENTARIO_NAOALTERADO = "Não foi possível Alterar o Comentário.";

        public static readonly String COMENTARIO_DADONAOINFORMADO = "Os campos com * são obrigatorios.";
    }
}