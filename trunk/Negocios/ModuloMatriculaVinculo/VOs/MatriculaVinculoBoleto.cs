using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ModuloBasico.VOs;

namespace Negocios.ModuloMatriculaVinculo.VOs
{
    public class MatriculaVinculoBoleto
    {
        [Conversion(AllowDbNull = true, DataTableConversion = true, KeyField = false)]
        public string NomeAluno{ get; set; }
        [Conversion(AllowDbNull = true, DataTableConversion = true, KeyField = false)]
        public string SerieAluno { get; set; }
        [Conversion(AllowDbNull = true, DataTableConversion = true, KeyField = false)]
        public double Valor { get; set; }
        [Conversion(AllowDbNull = true, DataTableConversion = true, KeyField = false)]
        public string Parcela { get; set; }
        [Conversion(AllowDbNull = true, DataTableConversion = true, KeyField = false)]
        public string Ano { get; set; }
        [Conversion(AllowDbNull = true, DataTableConversion=true, KeyField=false)] 
        public DateTime Vencimento{ get; set; }

        public MatriculaVinculoBoleto()
        {

        }


    }
}
