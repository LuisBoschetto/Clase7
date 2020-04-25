using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public abstract class Producto
    {
        //modelo, marca, número de serie, 
        //identificador (este valor no puede cargarse, ya que es el resultado de unir modelo-marca-número serie).
        protected string modelo { get; set; }
        protected string marca { get; set; }
        protected double numeroSerie { get; set; }
        public string identificacion { get; set; }


        public Producto(string _modelo, string _marca, double _nroserie, string _ident)
        {
            this.modelo = _modelo;
            this.marca = _marca;
            this.numeroSerie = _nroserie;
            this.identificacion = _ident;
        }

        public abstract string Descripcion()
        {
            return;
        }

    }
}
