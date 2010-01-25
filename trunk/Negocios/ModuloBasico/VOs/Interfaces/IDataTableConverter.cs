using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios.ModuloBasico.VOs
{
   public interface IDataTableConverter<T>
   {
      DataTable GetDataTable(List<T> items);
   }
}
