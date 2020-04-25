using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Deposito
    {
        private List<Producto> productos;

        public void agregarProducto(Monitor monitor)
        {
            productos.Add(monitor);
        }

        public void agregarProducto(Computadora computadora)
        {
            productos.Add(computadora);
        }

        public void eliminarProducto (string identificacion)
        {
            Producto nuevoProducto = productos.Find(x => x.identificacion == identificacion);
            if ( nuevoProducto!= null)
            {
                productos.Remove(nuevoProducto);
            }
        }

        public List<string> unicaLista()
        {
            List<string> ListaNueva = new List<string>();
            productos.ForEach(x => ListaNueva.Add(x.Descripcion()));
            ListaNueva.Sort();
            return ListaNueva;
        }
    }
}
