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
    public partial class GenresForm : Form
    {
        private readonly IServiceProvider? servicioProvider = DI.ConfigurarServicios();

        private readonly IGenresService? _servicio;

        List<Genre> genres;

        string? textFil;

        Orden orden = Orden.SinOrden;

        private int cantidadPaginas;
        private int pageSize = 8;
        private int pageNum = 0;
        private int cantidadRegistros;

        public GenresForm()
        {
            InitializeComponent();
            _servicio = servicioProvider.GetService<IGenresService>();

        }

        private void GenresForm_Load(object sender, EventArgs e)
        {
            genres = _servicio.GetGenresPaginadosOrdenados(pageNum, pageSize, orden);

            SeleccionarLista();

            RecargarGrilla(genres, cantidadRegistros);
        }

        private void RecargarGrilla(List<Genre> genres, int cantReg)
        {

            cantidadPaginas = FormHelper.CalcularPaginas(cantReg, pageSize);

            CantidadPaginasLbl.Text = cantidadPaginas.ToString();

            PaginaActualLbl.Text = (pageNum + 1).ToString();

            CantidadGenerosLbl.Text = cantReg.ToString();

            GridHelper.MostrarDatosEnGrilla<Genre>(genres, DgvGenres);

            foreach (DataGridViewRow r in DgvGenres.Rows)
            {
                r.Height = 40;
            }
        }

        private void SeleccionarLista()
        {
            if (BuscarGeneroTxt.Text == "")
            {
                genres = _servicio.GetGenresPaginadosOrdenados(pageNum, pageSize, orden);
                cantidadRegistros = _servicio.GetCantidad();
            }
            else
            {
                textFil = BuscarGeneroTxt.Text;
                genres = _servicio.GetGenresPaginadosOrdenados(pageNum, pageSize, orden, textFil);
                cantidadRegistros = genres.Count();
            }
        }

        private void BuscarGeneroTxt_TextChanged(object sender, EventArgs e)
        {
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void NuevoGeneroBtn_Click(object sender, EventArgs e)
        {
            GenresFormAE frm = new GenresFormAE();

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Genre genre = frm.GetGenre();

                if (genre is null) return;

                if (!_servicio.Existe(genre))
                {
                    _servicio.Guardar(genre);

                    GenresForm_Load(sender, e);

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
            if (DgvGenres.SelectedRows.Count == 0) { return; }

            var r = DgvGenres.SelectedRows[0];

            if (r.Tag is null) return;

            Genre genre = (Genre)r.Tag;

            GenresFormAE frm = new GenresFormAE();

            frm.SetGenre(genre);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {
                genre = frm.GetGenre();

                if (genre is null) return;

                if (!_servicio.Existe(genre))
                {
                    _servicio.Guardar(genre);

                    GridHelper.SetearFila(r, genre);

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

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (DgvGenres.SelectedRows.Count == 0) { return; }

            var r = DgvGenres.SelectedRows[0];

            if (r.Tag is not null)
            {
                Genre genre = (Genre)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la marca {genre.GenreName}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    if (!_servicio.EstaRelacionado(genre))
                    {
                        _servicio.Eliminar(genre);
                        GridHelper.QuitarFila(r, DgvGenres);
                        MessageBox.Show("¡Registro eliminado satisfactoriamente!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void PagUltimaBtn_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = cantidadPaginas - 1;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void PagPrimeraBtn_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void OrderABtn_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void OrderZBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.SinOrden;
            SeleccionarLista();
            RecargarGrilla(genres, cantidadRegistros);
        }

    }
}
