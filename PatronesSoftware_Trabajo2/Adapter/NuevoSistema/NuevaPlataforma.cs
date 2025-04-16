using PatronesSoftware_Trabajo2.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Adapter.NuevoSistema
{
    public class NuevaPlataforma
    {
        private INuevaPlataforma _plataforma;

        public NuevaPlataforma(INuevaPlataforma plataforma)
        {
            _plataforma = plataforma;
        }
        public void Mostrar()
        {
            _plataforma.ObtenerDatos();
        }
    }
}
