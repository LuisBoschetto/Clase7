using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Computadora : Producto
    {   
        private string descripcionProcesador { get; set; }
        private CapacidadMemoria capMemoria { get; set; }
        private string fabricante { get; set; }

        public Computadora(string _modelo, string _marca, double _nroserie, string _ident, string _descrip, CapacidadMemoria _capMem, string _fabricante) : base(_modelo, _marca, _nroserie, _ident)
        {
            this.descripcionProcesador = _descrip;
            this.capMemoria = _capMem;
            this.fabricante = _fabricante;
        }

        public override string Descripcion()
        {
            return $"PC {modelo} - {marca} - {capMemoria} RAM - {fabricante}";
        }
    }
}
