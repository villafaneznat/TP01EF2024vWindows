using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Agregar_y_Editar;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Entidades
{
    public partial class ColoursForm : Form
    {
        private readonly IServiceProvider? servicioProvider = DI.ConfigurarServicios();

        private readonly IColoursService? _servicio;

        List<Colour> colours;

        string? textFil = null;

        Orden orden = Orden.SinOrden;

        private int cantidadPaginas;
        private int pageSize = 8;
        private int pageNum = 0;
        private int cantidadRegistros;

        public ColoursForm()
        {
            InitializeComponent();
            _servicio = servicioProvider.GetService<IColoursService>();

        }

        private void ColoursForm_Load(object sender, EventArgs e)
        {
            colours = _servicio.GetColoursPaginadosOrdenados(pageNum, pageSize, orden);

            SeleccionarLista();

            RecargarGrilla(colours, cantidadRegistros);
        }

        private void RecargarGrilla(List<Colour> colours, int cantReg)
        {

            cantidadPaginas = FormHelper.CalcularPaginas(cantidadRegistros, pageSize);

            CantidadPaginasLbl.Text = cantidadPaginas.ToString();

            PaginaActualLbl.Text = (pageNum + 1).ToString();

            CantidadColoresLbl.Text = cantReg.ToString();

            GridHelper.MostrarDatosEnGrilla<Colour>(colours, DgvColours);

            foreach (DataGridViewRow r in DgvColours.Rows)
            {
                r.Height = 40;
            }
        }

        private void SeleccionarLista()
        {
            if (BuscarColorTxt.Text == "")
            {
                colours = _servicio.GetColoursPaginadosOrdenados(pageNum, pageSize, orden);
                cantidadRegistros = _servicio.GetCantidad();
            }
            else
            {
                textFil = BuscarColorTxt.Text;
                colours = _servicio.GetColoursPaginadosOrdenados(pageNum, pageSize, orden, textFil);
                cantidadRegistros = colours.Count();
            }
        }

        private void BuscarColorTxt_TextChanged(object sender, EventArgs e)
        {
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            if (DgvColours.SelectedRows.Count == 0) { return; }

            var r = DgvColours.SelectedRows[0];

            if (r.Tag is not null)
            {
                Colour colour = (Colour)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja el deporte {colour.ColourName}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    if (!_servicio.EstaRelacionado(colour))
                    {
                        _servicio.Eliminar(colour);
                        GridHelper.QuitarFila(r, DgvColours);
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

        private void NuevoColorBtn_Click(object sender, EventArgs e)
        {
            ColoursFormAE frm = new ColoursFormAE();

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Colour colour = frm.GetColour();

                if (colour is null) return;

                if (!_servicio.Existe(colour))
                {
                    _servicio.Guardar(colour);

                    ColoursForm_Load(sender, e);

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
            if (DgvColours.SelectedRows.Count == 0) { return; }

            var r = DgvColours.SelectedRows[0];

            if (r.Tag is null) return;

            Colour colour = (Colour)r.Tag;

            ColoursFormAE frm = new ColoursFormAE();

            frm.SetColour(colour);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {
                colour = frm.GetColour();

                if (colour is null) return;

                if (!_servicio.Existe(colour))
                {
                    _servicio.Guardar(colour);

                    GridHelper.SetearFila(r, colour);

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
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void PagUltimaBtn_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = cantidadPaginas - 1;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void PagPrimeraBtn_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void OrderABtn_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

        private void OrderZBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            SeleccionarLista();
            RecargarGrilla(colours, cantidadRegistros);
        }

    }
}
