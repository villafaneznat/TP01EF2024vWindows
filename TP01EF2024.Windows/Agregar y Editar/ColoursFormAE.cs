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
    public partial class ColoursFormAE : Form
    {
        private Colour colour;

        public ColoursFormAE()
        {
            InitializeComponent();
        }

        internal Colour GetColour()
        {
            return colour;
        }

        internal void SetColour(Colour colour)
        {
            this.colour = colour;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (colour != null)
            {
                ColorTxt.Text = colour.ColourName;
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
                if (colour == null)
                {
                    colour = new Colour();
                }
                colour.ColourName = ColorTxt.Text;

                DialogResult = DialogResult.OK;
            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(ColorTxt.Text) || string.IsNullOrWhiteSpace(ColorTxt.Text))
            {
                valido = false;
                errorProvider.SetError(ColorTxt, "El color es requerido.");
            }
            if (ColorTxt.Text.Length > 50)
            {
                valido = false;
                errorProvider.SetError(ColorTxt, "Sólo se permiten hasta 50 caracteres.");
            }

            return valido;
        }
    }
}
