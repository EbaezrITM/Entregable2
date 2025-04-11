using PatronesSoftware_Trabajo2.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Composite.Elementos
{
    public class ElementoSimple : IComponenteUI
    {
        private string _nombre;

        public ElementoSimple(string nombre)
        {
            _nombre = nombre;
        }

        public void Renderizar()
        {
            Console.WriteLine($"Renderizando elemento: {this._nombre}");
        }  
    
    }
}
