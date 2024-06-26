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
    public partial class SportsFormAE : Form
    {
        private Sport sport;

        public SportsFormAE()
        {
            InitializeComponent();
        }

        internal Sport GetSport()
        {
            return sport;
        }

        internal void SetSport(Sport sport)
        {
            this.sport = sport;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (sport != null)
            {
                DeporteTxt.Text = sport.SportName;
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
                if (sport == null)
                {
                    sport = new Sport();
                }
                sport.SportName = DeporteTxt.Text;

                DialogResult = DialogResult.OK;
            }
        }


        private bool ValidarDatos()
        {
            bool valido = true;

            errorProvider.Clear();

            if (string.IsNullOrEmpty(DeporteTxt.Text) || string.IsNullOrWhiteSpace(DeporteTxt.Text))
            {
                valido = false;
                errorProvider.SetError(DeporteTxt, "La marca es requerida.");
            }
            if (DeporteTxt.Text.Length > 20)
            {
                valido = false;
                errorProvider.SetError(DeporteTxt, "Sólo se permiten hasta 20 caracteres.");
            }

            return valido;
        }
    }
}
