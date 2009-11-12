using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Negocios.ModuloPostagem.Excecoes
{
    /// <summary>
    /// Summary description for ConstantesPostagem
    /// </summary>
    public static class ConstantesPostagem
    {
        //Postagem
        public static readonly String POSTAGEM_INCLUIDACOMSUCESSO = "Postagem incluida com sucesso.";
        public static readonly String POSTAGEM_EXCLUIDACOMSUCESSO = "Postagem excluida com sucesso.";
        public static readonly String POSTAGEM_ALTERADACOMSUCESSO = "Postagem alterada com sucesso.";
        public static readonly String POSTAGEM_NAOINCLUIDA = "Não foi possível Incluir a Postagem.";
        public static readonly String POSTAGEM_NAOEXCLUIDA = "Não foi possível Excluir a Postagem.";
        public static readonly String POSTAGEM_NAOALTERADA = "Não foi possível Alterar a Postagem.";

        public static readonly String POSTAGEM_DADONAOINFORMADO = "Os campos com * são obrigatorios.";
    }
}