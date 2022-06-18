using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtendido
    {
        public static bool VerificarDni(this string dni)
        {
            return dni.Length>8;
        }
    }
}
