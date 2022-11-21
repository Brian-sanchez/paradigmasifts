using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad2_Ej16
{
    class Informes
    {
        private string codSucursal;
        private string prodVendido;
        private int cantVendido;

        public Informes(string _codSucursal, string _prodVendido, int _cantVendido)
        {
            this.codSucursal = _codSucursal;
            this.prodVendido = _prodVendido;
            this.cantVendido = _cantVendido;
        }

        public string getCodSucursal()
        {
            return codSucursal;
        }

        public string getProdVendido()
        {
            return prodVendido;
        }

        public int getCantVendido()
        {
            return cantVendido;
        }
    }
}
