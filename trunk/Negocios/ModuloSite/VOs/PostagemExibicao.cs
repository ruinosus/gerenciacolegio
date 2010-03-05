using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloSite.VOs
{
    public class PostagemExibicao
    {
        public Postagem PostagemEsquerdaUm{ get; set; }
        public Postagem PostagemEsquerdaDois { get; set; }
        public Postagem PostagemEsquerdaTres { get; set; }
        public Postagem PostagemMeioUm { get; set; }
        public Postagem PostagemMeioDois { get; set; }
        public Postagem PostagemMeioTres { get; set; }
        public Postagem PostagemDireitaUm { get; set; }
        public Postagem PostagemDireitaDois { get; set; }
        public Postagem PostagemDireitaTres { get; set; }

    }
}
