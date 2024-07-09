using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Helpers;
using Size = TP01EF2024.Entidades.Size;

namespace TP01EF2024.Windows
{
    public partial class ShoesFiltroForm : Form
    {
        private IServiceProvider _serviceProvider;
        public Brand? brand;
        public Colour? colour;
        public Sport? sport;
        public Genre? genre;
        public Size? size;
        public decimal? precioMin = null;
        public decimal? precioMax = null;

        public ShoesFiltroForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboMarcas(_serviceProvider, ref ComboMarcas);
            CombosHelper.CargarComboDeportes(_serviceProvider, ref ComboDeportes);
            CombosHelper.CargarComboGeneros(_serviceProvider, ref ComboGeneros);
            CombosHelper.CargarComboColores(_serviceProvider, ref ComboColores);
            CombosHelper.CargarComboTalles(_serviceProvider, ref ComboTalles);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void AplicarFiltroBtn_Click(object sender, EventArgs e)
        {
            if (ComboMarcas.SelectedIndex != 0)
            {
                brand = (Brand?)ComboMarcas.SelectedItem;
            }
            if (ComboDeportes.SelectedIndex != 0)
            {
                sport = (Sport?)ComboDeportes.SelectedItem;
            }
            if (ComboGeneros.SelectedIndex != 0)
            {
                genre = (Genre?)ComboGeneros.SelectedItem;
            }
            if (ComboColores.SelectedIndex != 0)
            {
                colour = (Colour?)ComboColores.SelectedItem;
            }
            if (ComboTalles.SelectedIndex != 0)
            {
                size = (Size?)ComboTalles.SelectedItem;
            }
            if (PreciosValidos())
            {
                DialogResult = DialogResult.OK;
            }

        }

        private bool PreciosValidos()
        {
            errorProvider.Clear();
            bool valido = true;

            if (!string.IsNullOrEmpty(PrecioMinimoText.Text) || !string.IsNullOrWhiteSpace(PrecioMinimoText.Text))
            {
                if (!decimal.TryParse(PrecioMinimoText.Text, out decimal pMin))
                {
                    errorProvider.SetError(PrecioMinimoText, "Ingreso Incorrecto");
                    valido = false;
                }
                else
                {
                    precioMin = decimal.Parse(PrecioMinimoText.Text);
                }
            }
            else
            {
                precioMin = null;
            }
            if (!string.IsNullOrEmpty(PrecioMaximoText.Text) || !string.IsNullOrWhiteSpace(PrecioMaximoText.Text))
            {
                if (!decimal.TryParse(PrecioMaximoText.Text, out decimal pMin))
                {
                    errorProvider.SetError(PrecioMaximoText, "Ingreso Incorrecto");
                    valido = false;
                }
                else
                {
                    precioMax = decimal.Parse(PrecioMaximoText.Text);
                }
            }
            else
            {
                precioMax = null;
            }
            return valido;

        }
    }
}
