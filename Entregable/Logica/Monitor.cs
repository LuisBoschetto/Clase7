using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Monitor : Producto
    {
        private int anio { get; set; }
        private int? pulgadas { get; set; }

        public Monitor(string _modelo, string _marca, double _nroserie, string _ident, int _anio, int _pulgadas) : base(_modelo, _marca, _nroserie, _ident)
        {
            this.anio = _anio;
            this.pulgadas = _pulgadas;

        }

        public override string Descripcion()
        {
            return $"MONITOR: {marca} - {modelo} {pulgadas}";
        }
    }
}
