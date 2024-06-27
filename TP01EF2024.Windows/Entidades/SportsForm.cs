using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.Entidades;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Windows.Helpers;
using TP01EF2024.Windows.Agregar_y_Editar;

namespace TP01EF2024.Windows.Entidades
{
    public partial class SportsForm : Form
    {
        private readonly IServiceProvider? servicioProvider = DI.ConfigurarServicios();

        private readonly ISportsService? _servicio;

        List<Sport> sports;

        string? textFil = null;

        Orden orden = Orden.SinOrden;

        private int cantidadPaginas;
        private int pageSize = 8;
        private int pageNum = 0;
        private int cantidadRegistros;
        public SportsForm()
        {
            InitializeComponent();
            _servicio = servicioProvider.GetService<ISportsService>();
        }

        private void SportsForm_Load(object sender, EventArgs e)
        {
            sports = _servicio.GetSportsPaginadosOrdenados(pageNum, pageSize, orden);

            SeleccionarLista();

            RecargarGrilla(sports, cantidadRegistros);
        }

        private void RecargarGrilla(List<Sport> sports, int cantReg)
        {

            cantidadPaginas = FormHelper.CalcularPaginas(cantidadRegistros, pageSize);

            CantidadPaginasLbl.Text = cantidadPaginas.ToString();

            PaginaActualLbl.Text = (pageNum + 1).ToString();

            CantidadDeportesLbl.Text = cantReg.ToString();

            GridHelper.MostrarDatosEnGrilla<Sport>(sports, DgvSports);

            foreach (DataGridViewRow r in DgvSports.Rows)
            {
                r.Height = 40;
            }
        }

        private void SeleccionarLista()
        {
            if (BuscarDeporteTxt.Text == "")
            {
                sports = _servicio.GetSportsPaginadosOrdenados(pageNum, pageSize, orden);
                cantidadRegistros = _servicio.GetCantidad();
            }
            else
            {
                textFil = BuscarDeporteTxt.Text;
                sports = _servicio.GetSportsPaginadosOrdenados(pageNum, pageSize, orden, textFil);
                cantidadRegistros = sports.Count();
            }
        }

        private void BuscarDeporteTxt_TextChanged(object sender, EventArgs e)
        {
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (DgvSports.SelectedRows.Count == 0) { return; }

            var r = DgvSports.SelectedRows[0];

            if (r.Tag is not null)
            {
                Sport sport = (Sport)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja el deporte {sport.SportName}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    if (!_servicio.EstaRelacionado(sport))
                    {
                        _servicio.Eliminar(sport);
                        GridHelper.QuitarFila(r, DgvSports);
                        MessageBox.Show("Registro eliminado satisfactoriamente!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro relacionado.. ¡Baja denegada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void NuevoDeporteBtn_Click(object sender, EventArgs e)
        {
            SportsFormAE frm = new SportsFormAE();

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Sport sport = frm.GetSport();

                if (sport is null) return;

                if (!_servicio.Existe(sport))
                {
                    _servicio.Guardar(sport);

                    SportsForm_Load(sender, e);

                    MessageBox.Show("Registro agregado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro ya existe, no es posible agregarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (DgvSports.SelectedRows.Count == 0) { return; }

            var r = DgvSports.SelectedRows[0];

            if (r.Tag is null) return;

            Sport sport = (Sport)r.Tag;

            SportsFormAE frm = new SportsFormAE();

            frm.SetSport(sport);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {
                sport = frm.GetSport();

                if (sport is null) return;

                if (!_servicio.Existe(sport))
                {
                    _servicio.Guardar(sport);

                    GridHelper.SetearFila(r, sport);

                    MessageBox.Show("Registro editado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El registro ya existe, no es posible agregarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.SinOrden;
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void PagUltimaBtn_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = cantidadPaginas - 1;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void PagPrimeraBtn_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void OrderABtn_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }

        private void OrderZBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            SeleccionarLista();
            RecargarGrilla(sports, cantidadRegistros);
        }
    }
}
