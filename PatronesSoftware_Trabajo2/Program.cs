using PatronesSoftware_Trabajo2.Adapter.ImplementAdapter;
using PatronesSoftware_Trabajo2.Adapter.Interfaces;
using PatronesSoftware_Trabajo2.Adapter.sistemaAntiguo;
using PatronesSoftware_Trabajo2.Composite.Elementos;
using PatronesSoftware_Trabajo2.Composite.ImplementComposite;
using PatronesSoftware_Trabajo2.Proxy.ImplementProxy;
using PatronesSoftware_Trabajo2.Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesSoftware_Trabajo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Execute Adapter
            INuevaPlataforma nuevaPlataforma = new AdaptadorSistema(new SistemaAntiguo());
            nuevaPlataforma.ObtenerDatos();

            //Execute Proxy
            IArchivo archivo = new ProxyArchivo("ArchivoSecret.txt", false);
            archivo.Leer();
            archivo = new ProxyArchivo("ArchivoSecret.txt", true);
            archivo.Leer();

            //Execute Composite
            ContenedorUI panel = new ContenedorUI();
            panel.AgregarElemento(new ElementoSimple("Botón"));
            panel.AgregarElemento(new ElementoSimple("Etiqueta"));
            panel.Renderizar();

        }
    }
}
