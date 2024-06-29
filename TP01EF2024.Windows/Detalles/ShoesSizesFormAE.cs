using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using Size = TP01EF2024.Entidades.Size;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Detalles
{
    public partial class ShoesSizesFormAE : Form
    {

        private readonly IServiceProvider _serviceProvider = DI.ConfigurarServicios();
        private readonly ISizesService _servicioTalles;
        private readonly IShoesService _shoesService;

        ShoeSize? shoeSize;

        Shoe? shoe;

        Size size;

        public ShoesSizesFormAE(Shoe? shoe, IShoesService shoesService)
        {
            InitializeComponent();
            _servicioTalles = _serviceProvider.GetService<ISizesService>();
            this.shoe = shoe;
            this._shoesService = shoesService;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboTalles(_serviceProvider, ref ComboTalles);
            if (shoeSize != null)
            {
                ComboTalles.SelectedValue = shoeSize.SizeId;
                StockTxt.Text = shoeSize.QuantityInStock.ToString();
                ComboTalles.Enabled = false;
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
                if (shoeSize == null)
                {
                    shoeSize = new ShoeSize();
                }

                //shoeSize.Shoe = shoe;
                shoeSize.ShoeId = shoe.ShoeId;
                //shoeSize.Size = size;
                shoeSize.SizeId = size.SizeId;
                shoeSize.QuantityInStock = int.Parse(StockTxt.Text);

                DialogResult = DialogResult.OK;
            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(StockTxt.Text) || string.IsNullOrWhiteSpace(StockTxt.Text))
            {
                valido = false;
                errorProvider.SetError(StockTxt, "El stock es requerido.");
            }
            if (!int.TryParse(StockTxt.Text, out int stock) || (stock < 0))
            {
                valido = false;
                errorProvider.SetError(StockTxt, "Stock no válido o mal ingresado");
            }
            if (ComboTalles.SelectedIndex == 0 && size == null)
            {
                valido = false;
                errorProvider.SetError(ComboTalles, "Debe seleccionar un talle");
            }

            return valido;
        }

        private void ComboTalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTalles.SelectedIndex > 0)
            {
                size = (Size?)ComboTalles.SelectedItem;
            }
            else
            {
                size = null;
            }


        }

        internal ShoeSize GetShoeSize()
        {
            return shoeSize;
        }

        internal void SetShoeSize(ShoeSize shoeSize)
        {
            this.shoeSize = shoeSize;
        }
    }
}
