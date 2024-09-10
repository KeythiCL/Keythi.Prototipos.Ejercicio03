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
            var paisesValidos = new[] { "Argentina", "Peru" };
            var provinciasValidasArgentina = new[] { "Buenos Aires", "Cordoba" };
            var provinciasValidasPeru = new[] { "Lima", "La libertad" };
            var localidadesValidasBuenosAires = new[] { "La plata", "Mar del plata" };
            var localidadesValidasCordoba = new[] { "Achiras", "Agua de oro" };
            var localidadesValidasLaLibertad = new[] { "La libertad", "Trujillo" };
            var localidadesValidasLima = new[] { "San Isidro", "Miraflores" };

            if (string.IsNullOrWhiteSpace(direccion.Pais))
            {
                return "Debe seleccionar una marca";
            }
            if (!paisesValidos.Contains(direccion.Pais))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Provincia))
            {
                return "Debe seleccionar una marca";
            }
            if (!provinciasValidasArgentina.Contains(direccion.Provincia))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Provincia))
            {
                return "Debe seleccionar una marca";
            }
            if (!provinciasValidasPeru.Contains(direccion.Provincia))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Localidad))
            {
                return "Debe seleccionar una marca";
            }
            if (!localidadesValidasCordoba.Contains(direccion.Localidad))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Localidad))
            {
                return "Debe seleccionar una marca";
            }
            if (!localidadesValidasBuenosAires.Contains(direccion.Localidad))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Localidad))
            {
                return "Debe seleccionar una marca";
            }
            if (!localidadesValidasLaLibertad.Contains(direccion.Localidad))
            {
                return "La marca seleccionada no es válida";
            }

            if (string.IsNullOrWhiteSpace(direccion.Localidad))
            {
                return "Debe seleccionar una marca";
            }
            if (!localidadesValidasLima.Contains(direccion.Localidad))
            {
                return "La marca seleccionada no es válida";
            }


            if (direccion.Calle.Length > 100)
            {
                return "El numero maximo de caracteres es de 100";
            }

            if(direccion.Numero > 999999)
            {
                return "Solo se puede ingresar 6 digitos";
            }


            if(direccion.Piso.Length > 3)
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
