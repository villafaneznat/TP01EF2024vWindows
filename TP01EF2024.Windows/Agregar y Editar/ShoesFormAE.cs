using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.Windows.Entidades;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Agregar_y_Editar
{
    public partial class ShoesFormAE : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private Shoe shoe;

        private Brand? brand;

        private Sport? sport;

        private Genre? genre;

        private Colour? colour;

        public ShoesFormAE(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        internal Shoe GetShoe()
        {
            return shoe;
        }

        internal void SetShoe(Shoe shoe)
        {
            this.shoe = shoe;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            CombosHelper.CargarComboMarcas(_serviceProvider, ref ComboMarcas);
            CombosHelper.CargarComboDeportes(_serviceProvider, ref ComboDeportes);
            CombosHelper.CargarComboGeneros(_serviceProvider, ref ComboGeneros);
            CombosHelper.CargarComboColores(_serviceProvider, ref ComboColores);

            if (shoe != null)
            {
                ModeloTxt.Text = shoe.Model;
                DescripcionTxt.Text = shoe.Description;
                PrecioTxt.Text = shoe.Price.ToString();
                ComboMarcas.SelectedValue = shoe.BrandId;
                ComboDeportes.SelectedValue = shoe.SportId;
                ComboGeneros.SelectedValue = shoe.GenreId;
                ComboColores.SelectedValue = shoe.ColourId;
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (shoe == null)
                {
                    shoe = new Shoe();
                }
                shoe.Model = ModeloTxt.Text;
                shoe.Description = DescripcionTxt.Text;
                shoe.Price = decimal.Parse(PrecioTxt.Text);
                shoe.Brand = brand;
                shoe.BrandId = brand.BrandId;
                shoe.Sport = sport;
                shoe.SportId = sport.SportId;
                shoe.Colour = colour;
                shoe.ColourId = colour.ColourId;
                shoe.Genre = genre;
                shoe.GenreId = genre.GenreId;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(ModeloTxt.Text) || string.IsNullOrWhiteSpace(ModeloTxt.Text))
            {
                valido = false;
                errorProvider.SetError(ModeloTxt, "El modelo es requerido.");
            }
            if (ModeloTxt.Text.Length > 150)
            {
                valido = false;
                errorProvider.SetError(ModeloTxt, "Sólo se permiten hasta 150 caracteres.");
            }
            if (string.IsNullOrEmpty(DescripcionTxt.Text) || string.IsNullOrWhiteSpace(DescripcionTxt.Text))
            {
                valido = false;
                errorProvider.SetError(DescripcionTxt, "La descripción es requerida.");
            }
            if (string.IsNullOrEmpty(PrecioTxt.Text) || string.IsNullOrWhiteSpace(PrecioTxt.Text))
            {
                valido = false;
                errorProvider.SetError(PrecioTxt, "El precio es requerido.");
            }
            if (!decimal.TryParse(PrecioTxt.Text, out decimal precio) || (precio <= 0))
            {
                valido = false;
                errorProvider.SetError(PrecioTxt, "Precio no válido o mal ingresado");
            }
            if (ComboMarcas.SelectedIndex == 0 && brand == null)
            {
                valido = false;
                errorProvider.SetError(ComboMarcas, "Debe seleccionar una marca");
            }
            if (ComboDeportes.SelectedIndex == 0 && sport == null)
            {
                valido = false;
                errorProvider.SetError(ComboDeportes, "Debe seleccionar un deporte");
            }
            if (ComboGeneros.SelectedIndex == 0 && genre == null)
            {
                valido = false;
                errorProvider.SetError(ComboGeneros, "Debe seleccionar un género");
            }
            if (ComboColores.SelectedIndex == 0 && colour == null)
            {
                valido = false;
                errorProvider.SetError(ComboColores, "Debe seleccionar un color");
            }

            return valido;
        }

        private void ComboMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMarcas.SelectedIndex > 0)
            {
                brand = (Brand?)ComboMarcas.SelectedItem;
            }
            else
            {
                brand = null;
            }
        }

        private void ComboColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboColores.SelectedIndex > 0)
            {
                colour = (Colour?)ComboColores.SelectedItem;
            }
            else
            {
                colour = null;
            }

        }

        private void ComboDeportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDeportes.SelectedIndex > 0)
            {
                sport = (Sport?)ComboDeportes.SelectedItem;
            }
            else
            {
                sport = null;
            }

        }

        private void ComboGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboGeneros.SelectedIndex > 0)
            {
                genre = (Genre?)ComboGeneros.SelectedItem;
            }
            else
            {
                genre = null;
            }

        }

        private void NuevaMarcaLbl_Click(object sender, EventArgs e)
        {
            BrandsForm frm = new BrandsForm();

            // Invoca el método que ya tengo en BrandsForm
            frm.NuevaMarcaBtn_Click(sender, e);

            // Actualizo el ComboBox de marcas
            CombosHelper.CargarComboMarcas(_serviceProvider, ref ComboMarcas);

            //Selecciono la marca que acabo de agregar
            brand = frm.GetBrand();

            if (brand != null)
            {
                ComboMarcas.SelectedValue = brand.BrandId;
            }
        }

        private void NuevoColorLbl_Click(object sender, EventArgs e)
        {
            ColoursForm frm = new ColoursForm();

            frm.NuevoColorBtn_Click(sender, e);

            CombosHelper.CargarComboColores(_serviceProvider, ref ComboColores);

            colour = frm.GetColour();

            if (colour != null)
            {
                ComboColores.SelectedValue = colour.ColourId;
            }

        }

        private void NuevoDeporteLbl_Click(object sender, EventArgs e)
        {
            SportsForm frm = new SportsForm();

            frm.NuevoDeporteBtn_Click(sender, e);

            CombosHelper.CargarComboDeportes(_serviceProvider, ref ComboDeportes);

            sport = frm.GetSport();

            if (colour != null)
            {
                ComboDeportes.SelectedValue = sport.SportId;
            }

        }

        private void NuevoGeneroLbl_Click(object sender, EventArgs e)
        {
            GenresForm frm = new GenresForm();

            frm.NuevoGeneroBtn_Click(sender, e);

            CombosHelper.CargarComboGeneros(_serviceProvider, ref ComboGeneros);

            genre = frm.GetGenre();

            if (colour != null)
            {
                ComboGeneros.SelectedValue = genre.GenreId;
            }

        }
    }
}
