using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        /// <summary>
        /// verifica si un Dni es valido para cargarlo en el nuevo cliente
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true si es valido</returns>
        public static bool VerificarDni(this string dni)
        {
            return dni.Length>8;
        }
    }
}
