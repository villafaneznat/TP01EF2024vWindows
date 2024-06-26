using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades;

namespace TP01EF2024.Windows.Agregar_y_Editar
{
    public partial class BrandsFormAE : Form
    {
        private readonly IServiceProvider servicioProvider;

        private Brand brand;

        public BrandsFormAE()
        {
            InitializeComponent();
        }

        internal Brand GetBrand()
        {
            return brand;
        }

        internal void SetBrand(Brand brand)
        {
            this.brand = brand;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (brand != null)
            {
                MarcaTxt.Text = brand.BrandName;
            }
        }
        private void BrandsFormAE_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (brand == null)
                {
                    brand = new Brand();
                }
                brand.BrandName = MarcaTxt.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(MarcaTxt.Text) || string.IsNullOrWhiteSpace(MarcaTxt.Text))
            {
                valido = false;
                errorProvider.SetError(MarcaTxt, "La marca es requerida.");
            }
            if (MarcaTxt.Text.Length > 50)
            {
                valido = false;
                errorProvider.SetError(MarcaTxt, "Sólo se permiten hasta 50 caracteres.");
            }

            return valido;
        }
    }
}
