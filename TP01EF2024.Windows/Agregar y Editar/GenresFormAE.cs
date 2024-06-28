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
    public partial class GenresFormAE : Form
    {
        private Genre genre;

        public GenresFormAE()
        {
            InitializeComponent();
        }

        internal Genre GetGenre()
        {
            return genre;
        }

        internal void SetGenre(Genre genre)
        {
            this.genre = genre;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (genre != null)
            {
                GeneroTxt.Text = genre.GenreName;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void IngresarBtn_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (genre == null)
                {
                    genre = new Genre();
                }
                genre.GenreName = GeneroTxt.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(GeneroTxt.Text) || string.IsNullOrWhiteSpace(GeneroTxt.Text))
            {
                valido = false;
                errorProvider.SetError(GeneroTxt, "El género es requerido.");
            }
            if (GeneroTxt.Text.Length > 10)
            {
                valido = false;
                errorProvider.SetError(GeneroTxt, "Sólo se permiten hasta 10 caracteres.");
            }

            return valido;
        }
    }
}

