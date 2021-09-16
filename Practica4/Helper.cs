using System;
using System.Collections.Generic;

namespace Practica4
{
    public static class Helper
    {
        public static List<int> Pares(this List<int> lista)
        {
            return lista.FindAll(x => x % 2 == 0);
        }
    }
}
