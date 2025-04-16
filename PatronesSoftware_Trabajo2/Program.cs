using PatronesSoftware_Trabajo2.Adapter.ImplementAdapter;
using PatronesSoftware_Trabajo2.Adapter.Interfaces;
using PatronesSoftware_Trabajo2.Adapter.NuevoSistema;
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
            Console.WriteLine("::::::::::::::::::::::: Ejecutando Adapter ::::::::::::::::::::::::::::::::::\n");
            INuevaPlataforma adaptador = new AdaptadorSistema(new SistemaAntiguo());
            NuevaPlataforma nuevaPlataforma = new NuevaPlataforma(adaptador);
            nuevaPlataforma.Mostrar();
            Console.WriteLine("<---------------------------------------------------------------------------->\n");

            //Execute Proxy
            Console.WriteLine("::::::::::::::::::::::: Ejecutando Proxy ::::::::::::::::::::::::::::::::::\n");
            IArchivo archivo = new ProxyArchivo("ArchivoSecret.txt", false);
            archivo.Leer();
            archivo = new ProxyArchivo("ArchivoSecret.txt", true);
            archivo.Leer();
            Console.WriteLine("<---------------------------------------------------------------------------->\n");

            //Execute Composite
            Console.WriteLine("::::::::::::::::::::::: Ejecutando Proxy ::::::::::::::::::::::::::::::::::\n");
            ContenedorUI panel = new ContenedorUI();
            panel.AgregarElemento(new ElementoSimple("Botón"));
            panel.AgregarElemento(new ElementoSimple("Etiqueta"));
            panel.Renderizar();
            Console.WriteLine("<---------------------------------------------------------------------------->\n");

        }
    }
}
