﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color): base(chasis,marca,color) 
        {

        }

        /// <summary>
        /// metodo sobreescrito mostrar que invoca al metodo de la clase base y la extiende con sus propias caracteristicas
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\r\n", this.Tamanio);
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
