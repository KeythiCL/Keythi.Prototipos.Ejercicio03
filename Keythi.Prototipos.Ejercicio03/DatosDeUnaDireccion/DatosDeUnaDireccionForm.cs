namespace Keythi.Prototipos.Ejercicio03.DatosDeUnaDireccion
{
    public partial class DatosDeUnaDireccionForm : Form
    {
        private DatosDeUnaDireccionModelo modelo = new();

        public DatosDeUnaDireccionForm()
        {
            InitializeComponent();
        }

        private void ListLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implementación si es necesario para la localidad seleccionada
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            var direccion = new Direccion();

            if (!int.TryParse(TxtNumero.Text, out int numero))
            {
                MessageBox.Show("Ingrese un valor numerico");
                return;
            }

            var paisSeleccionado = ListPais.SelectedItem.ToString();
            if (Enum.TryParse<TiposPais>(paisSeleccionado, out var pais))
            {
                direccion.Pais = pais;
            }
            else
            {
                MessageBox.Show("Pais no válida seleccionada.");
            }

            var provinciaSeleccionado = ListProvincia.SelectedItem.ToString();
            if (Enum.TryParse<TiposProvincia>(provinciaSeleccionado, out var provincia))
            {
                direccion.Provincia = provincia;
            }
            else
            {
                MessageBox.Show("Pais no válida seleccionada.");

            }

            var localidadSeleccionado = ListLocalidad.SelectedItem.ToString();
            if (Enum.TryParse<TiposLocalidad>(localidadSeleccionado, out var localidad))
            {
                direccion.Localidad = localidad;
            }
            else
            {
                MessageBox.Show("Pais no válida seleccionada.");

            }

            direccion.Calle = TxtCalle.Text;
            direccion.Numero = numero;
            direccion.Piso = TxtPiso.Text;
            direccion.Departamento = TxtDepartamento.Text;

            var error = modelo.IngresarDireccion(direccion);

            if (error == null)
            {
                MessageBox.Show("Datos ingresados correctamente");
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void ListProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListLocalidad.Items.Clear();

            string provinciaSeleccionada = ListProvincia.SelectedItem.ToString(); // Cambiado a ListProvincias
            if (string.IsNullOrEmpty(provinciaSeleccionada))
            {
                return;
            }

            if (provinciaSeleccionada == "Buenos Aires")
            {
                ListLocalidad.Items.Add("La Plata");
                ListLocalidad.Items.Add("Mar del Plata");
            }
            else if (provinciaSeleccionada == "Cordoba")
            {
                ListLocalidad.Items.Add("Achiras");
                ListLocalidad.Items.Add("Agua de Oro");
            }
            else if (provinciaSeleccionada == "Lima")
            {
                ListLocalidad.Items.Add("Miraflores");
                ListLocalidad.Items.Add("San Isidro");
            }
            else if (provinciaSeleccionada == "La Libertad")
            {
                ListLocalidad.Items.Add("Trujillo");
                ListLocalidad.Items.Add("La Libertad");
            }
        }

        private void ListPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListProvincia.Items.Clear();
            ListLocalidad.Items.Clear();

            string paisSeleccionado = ListPais.SelectedItem.ToString();
            if (string.IsNullOrEmpty(paisSeleccionado))
            {
                return;
            }

            if (paisSeleccionado == "Argentina")
            {
                ListProvincia.Items.Add("Buenos Aires");
                ListProvincia.Items.Add("Cordoba");
            }
            else if (paisSeleccionado == "Peru")
            {
                ListProvincia.Items.Add("Lima");
                ListProvincia.Items.Add("La Libertad");
            }
        }
    }
}
