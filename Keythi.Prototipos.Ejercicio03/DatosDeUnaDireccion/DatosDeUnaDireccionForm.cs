using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keythi.Prototipos.Ejercicio03.DatosDeUnaDireccion
{
    public partial class DatosDeUnaDireccionForm : Form
    {
        private DatosDeUnaDireccionModelo modelo = new();
        private ListBox ListPaises;
        private ListBox ListProvincias;
        private ListBox ListLocalidades;

        public DatosDeUnaDireccionForm()
        {
            InitializeComponent();

            ListPaises = new ListBox();
            ListProvincias = new ListBox();
            ListLocalidades = new ListBox();

            ListPaises.Items.Add("Argentina");
            ListPaises.Items.Add("Peru");

            ListPaises.SelectedIndexChanged += ListPaises_SelectedIndexChanged;
            ListProvincia.SelectedIndexChanged += ListProvincias_SelectedIndexChanged;
            ListLocalidades.SelectedIndexChanged += ListLocalidades_SelectedIndexChanged;
        }
        
        private void ListPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListProvincias.Items.Clear();
            ListLocalidades.Items.Clear();

            string paisSeleccionado = ListPaises.SelectedItem?.ToString();
            if(string.IsNullOrEmpty(paisSeleccionado))
            {
                return;
            }

            if (paisSeleccionado == "Argentina")
            {
                ListProvincias.Items.Add("Buenos Aires");
                ListProvincias.Items.Add("Cordoba");
            }

            else if (paisSeleccionado == "Peru")
            {
                ListProvincias.Items.Add("Lima");
                ListProvincias.Items.Add("La libertad");
            }
        }

        private void ListProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListLocalidades.Items.Clear();

            string provinciaSeleccionada = ListPaises.SelectedItem?.ToString();
            if(string.IsNullOrEmpty (provinciaSeleccionada))
            {
                return;
            }

            if (provinciaSeleccionada == "Buenos Aires")
            {
                ListLocalidades.Items.Add("La plata");
                ListLocalidades.Items.Add("Mar del plata");
            }
            else if (provinciaSeleccionada == "Cordoba")
            {
                ListLocalidades.Items.Add("Achiras");
                ListLocalidades.Items.Add("Agua de oro");
            }
            else if (provinciaSeleccionada == "Lima")
            {
                ListLocalidades.Items.Add("Miraflores");
                ListLocalidades.Items.Add("San Isidro");
            }
            else if(provinciaSeleccionada == "La libertad")
            {
                ListLocalidades.Items.Add("Trujillo");
                ListLocalidades.Items.Add("La libertad");
            }
        }

        private void ListLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            var direccion = new Direccion();

            if(!int.TryParse(TxtNumero.Text, out int numero))
            {
                MessageBox.Show ("Ingrese un valor numerico");
                return;
            }

            direccion.Pais = ListPaises.SelectedItem.ToString();
            direccion.Provincia = ListProvincias.SelectedItem.ToString();
            direccion.Localidad = ListLocalidades.SelectedItem.ToString();
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
    }
}
