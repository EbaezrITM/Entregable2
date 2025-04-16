using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Adapter.sistemaAntiguo
{
    public class SistemaAntiguo
    {
        public void DoOperation(string dato)
        {
            Console.WriteLine($"Procesando en el sistema antiguo: {dato}");
        }
    }
}
