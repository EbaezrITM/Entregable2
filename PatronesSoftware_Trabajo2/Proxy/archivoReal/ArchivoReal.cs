using PatronesSoftware_Trabajo2.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Proxy.archivoReal
{
    public class ArchivoReal : IArchivo
    {
        private string _nombre;

        public ArchivoReal(string nombre)
        {
            _nombre = nombre;            
        }

        public void Leer()
        {
            Console.WriteLine($"Leyendo archivo real:{_nombre} ");
        }
    }
}
