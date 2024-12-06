using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keythi.Prototipos.Ejercicio03.DatosDeUnaDireccion
{
    internal class DatosDeUnaDireccionModelo
    {
        public string IngresarDireccion(Direccion direccion)
        {

            if (direccion.Calle.Length > 100)
            {
                return "El numero maximo de caracteres es de 100";
            }

            if (direccion.Numero <= 0 || direccion.Numero > 999999)
            {
                return "El número debe estar entre 1 y 999999.";
            }


            if (direccion.Piso.Length > 3)
            {
                return "El numero maximo de caracteres es de 3";
            }

            if(direccion.Departamento.Length > 3)
            {
                return "El numero maximo de caracteres es de 3";
            }

            return null;
        }
    }
}
