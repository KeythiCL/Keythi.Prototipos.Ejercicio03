using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicio03.DatosDeUnaDireccion
{
    internal class Direccion
    {
        public TiposPais Pais {  get; set; }
        public TiposProvincia Provincia { get; set; }
        public TiposLocalidad Localidad { get; set; }
        public string Calle {  get; set; }
        public int Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
    }
}
