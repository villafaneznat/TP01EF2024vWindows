using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Agregar_y_Editar;
using TP01EF2024.Windows.Detalles;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Entidades
{
    public partial class ShoesForm : Form
    {
        private readonly IServiceProvider? servicioProvider = DI.ConfigurarServicios();

        private readonly IShoesService? _servicio;

        List<ShoeDto> shoesDtos;

        string? textFil;

        Orden orden = Orden.SinOrden;

        bool filtro = false;

        private int cantidadPaginas;
        private int pageSize = 8;
        private int pageNum = 0;
        private int cantidadRegistros;

        public ShoesForm()
        {
            InitializeComponent();
            _servicio = servicioProvider.GetService<IShoesService>();
        }

        private void ShoesForm_Load(object sender, EventArgs e)
        {
            shoesDtos = _servicio.GetListaShoesDtosPaginadaOrdenadaFiltrada(pageNum, pageSize, orden);
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);

        }

        private void RecargarGrilla(List<ShoeDto> shoes, int cantReg)
        {
            cantidadPaginas = FormHelper.CalcularPaginas(cantReg, pageSize);

            CantidadPaginasLbl.Text = cantidadPaginas.ToString();

            PaginaActualLbl.Text = (pageNum + 1).ToString();

            CantidadZapatosLbl.Text = cantReg.ToString();

            GridHelper.MostrarDatosEnGrilla<ShoeDto>(shoes, DgvShoes);

            foreach (DataGridViewRow r in DgvShoes.Rows)
            {
                r.Height = 40;
            }
        }

        private void SeleccionarLista()
        {
            if (filtro)
            {
                cantidadRegistros = shoesDtos.Count();
            }
            else if (BuscarZapatoTxt.Text == "")
            {
                shoesDtos = _servicio.GetListaShoesDtosPaginadaOrdenadaFiltrada(pageNum, pageSize, orden);
                cantidadRegistros = _servicio.GetCantidad();
            }
            else
            {
                textFil = BuscarZapatoTxt.Text;
                shoesDtos = _servicio.GetListaShoesDtosPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, textFil);
                cantidadRegistros = shoesDtos.Count();
            }
        }

        private void PagUltimaBtn_Click(object sender, EventArgs e)
        {
            pageNum = cantidadPaginas - 1;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void PagPrimeraBtn_Click(object sender, EventArgs e)
        {
            pageNum = 0;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void OrderABtn_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void OrderZBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.SinOrden;
            filtro = false;
            BuscarZapatoTxt.Enabled = true;
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void OrderPMinBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.MenorPrecio;
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void OrderPMaxBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.MayorPrecio;
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void NuevoZapatoBtn_Click(object sender, EventArgs e)
        {
            ShoesFormAE frm = new ShoesFormAE(servicioProvider);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Shoe shoe = frm.GetShoe();

                if (shoe is null) return;

                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);

                    ShoesForm_Load(sender, e);

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

        private void EditarZapatoBtn_Click(object sender, EventArgs e)
        {
            if (DgvShoes.SelectedRows.Count == 0) { return; }

            var r = DgvShoes.SelectedRows[0];

            ShoeDto shoeDto = (ShoeDto)r.Tag;

            if (shoeDto == null) return;

            Shoe shoe = _servicio.GetShoePorId(shoeDto.ShoeId);

            ShoesFormAE frm = new ShoesFormAE(servicioProvider);

            frm.SetShoe(shoe);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {
                shoe = frm.GetShoe();

                if (shoe == null) return;

                if (!_servicio.Existe(shoe))
                {
                    _servicio.Guardar(shoe);

                    SeleccionarLista();

                    ShoesForm_Load(sender, e);

                    MessageBox.Show("Registro editado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("El registro ya existe, no es posible agregarlo nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    shoe = null;
                    shoeDto = null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void BorrarZapatoBtn_Click(object sender, EventArgs e)
        {
            if (DgvShoes.SelectedRows.Count == 0) { return; }

            var r = DgvShoes.SelectedRows[0];

            if (r.Tag is not null)
            {
                ShoeDto shoeDto = (ShoeDto)r.Tag;

                Shoe shoe = _servicio.GetShoePorId(shoeDto.ShoeId);

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja el zapato {shoe.Model}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    if (!_servicio.EstaRelacionado(shoe))
                    {
                        _servicio.Eliminar(shoe);

                        GridHelper.QuitarFila(r, DgvShoes);

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

        private void BuscarZapatoTxt_TextChanged(object sender, EventArgs e)
        {
            SeleccionarLista();
            RecargarGrilla(shoesDtos, cantidadRegistros);
        }

        private void VerDetallesBtn_Click(object sender, EventArgs e)
        {
            if (DgvShoes.SelectedRows.Count == 0) { return; }

            var r = DgvShoes.SelectedRows[0];

            ShoeDto shoeDto = (ShoeDto)r.Tag;

            Shoe shoe = _servicio.GetShoePorId(shoeDto.ShoeId);

            ShoesFormDetalles frm = new ShoesFormDetalles(shoe, _servicio);

            frm.Show();
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
                       
            if (filtro)
            {
                MessageBox.Show("Un filtro ya se ha a aplicado, debe actualizar para poder volver a filtrar","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                ShoesFiltroForm frm = new ShoesFiltroForm(servicioProvider);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    shoesDtos = _servicio.GetListaShoesDtosPaginadaOrdenadaFiltrada(pageNum, pageSize, orden, null, frm.brand, frm.sport, frm.genre, frm.colour, frm.precioMax, frm.precioMin, frm.size);
                    RecargarGrilla(shoesDtos, shoesDtos.Count());
                    filtro = true;
                    //FiltrarBtn.Enabled = false;
                    //FiltrarBtn. = Color.FromArgb(224, 224, 224);
                    BuscarZapatoTxt.Enabled = false;
                }
                catch (Exception)
                {

                    throw;
                }

            }


        }
    }
}
