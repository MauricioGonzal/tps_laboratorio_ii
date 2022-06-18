using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartelera
    {
        public delegate void delegadoMuestraCartelera(string datos);
        public event delegadoMuestraCartelera emc;
        public CancellationToken cancellationToken;
        public CancellationTokenSource cancellationTokenSource;
        List<Libro> proximosIngresos;

        public Cartelera(List<Libro> proximos)
        {
            this.proximosIngresos = proximos;
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            Task.Run(() => MostrarCartelera(proximos), cancellationToken);
            
        }

        public void MostrarCartelera(List<Libro> l)
        {
            do
            {
                foreach (Libro libro in l)
                {
                    emc(libro.ToString());
                    Thread.Sleep(2000);
                }
            }
            while(!cancellationToken.IsCancellationRequested);
            
        }

        


    }
}
