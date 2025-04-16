using PatronesSoftware_Trabajo2.Adapter.Interfaces;
using PatronesSoftware_Trabajo2.Adapter.sistemaAntiguo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Adapter.ImplementAdapter
{
    public class AdaptadorSistema : INuevaPlataforma
    {
        private SistemaAntiguo _sistemaAntiguo;

        public AdaptadorSistema(SistemaAntiguo sistemaAntiguo)
        {
            this._sistemaAntiguo = sistemaAntiguo;
        }

        public void ObtenerDatos()
        {
            string datoEjemplo = "Dato de prueba ejecutado desde el adapter";
            _sistemaAntiguo.DoOperation(datoEjemplo);
        }
    }
}
