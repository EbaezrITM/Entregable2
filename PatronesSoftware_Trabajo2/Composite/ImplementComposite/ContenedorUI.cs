using PatronesSoftware_Trabajo2.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2.Composite.ImplementComposite
{
    public class ContenedorUI : IComponenteUI
    {
        private List<IComponenteUI> _elementos = new List<IComponenteUI>();
        public void AgregarElemento(IComponenteUI elemento)
        {
            _elementos.Add(elemento);
        }
        public void Renderizar()
        {
            Console.WriteLine("Renderizando contenedor:");
            foreach (var elemento in _elementos)
            {
                elemento.Renderizar();
            }
        }
    
    }
}
