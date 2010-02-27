using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ModuloBasico.Singleton
{
    /// <summary>
    /// Classe Básica para implementação de classes singleton
    /// </summary>
    /// <typeparam name="T">Classe da qual será gerado uma instância</typeparam>
    public class Singleton<T> where T : class, new()
    {
        public static T Instance
        {
            get
            {
               // return SingletonCreator.instance;
                return  new T();;
            }
        }

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }
}
