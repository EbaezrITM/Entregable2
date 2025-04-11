using PatronesSoftware_Trabajo2.Proxy.archivoReal;
using PatronesSoftware_Trabajo2.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Proxy.ImplementProxy
{
    public class ProxyArchivo : IArchivo
    {
        private readonly ArchivoReal _archivoReal;
        private bool _tienePermiso;

        public ProxyArchivo(string Nombre, bool TienePermiso)
        {
            _archivoReal = new ArchivoReal(Nombre);
            _tienePermiso = TienePermiso;
        }
        public void Leer()
        {
            if (_tienePermiso)
                _archivoReal.Leer();
            else
                Console.WriteLine("No tiene permiso para leer el archivo");
        }
    }
}
