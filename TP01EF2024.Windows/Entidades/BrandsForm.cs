using Microsoft.Extensions.DependencyInjection;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.InversionOfControl;
using TP01EF2024.Servicios.Interfaces;
using TP01EF2024.Windows.Agregar_y_Editar;
using TP01EF2024.Windows.Helpers;

namespace TP01EF2024.Windows.Entidades
{
    public partial class BrandsForm : Form
    {
        private readonly IServiceProvider? servicioProvider = DI.ConfigurarServicios();

        private readonly IBrandsService? _servicio;

        Brand brandForShoesAE;

        List<Brand> brands;

        string? textFil;

        Orden orden = Orden.SinOrden;

        private int cantidadPaginas;
        private int pageSize = 8;
        private int pageNum = 0;
        private int cantidadRegistros;

        public BrandsForm()
        {
            InitializeComponent();
            _servicio = servicioProvider.GetService<IBrandsService>();

        }

        private void BrandsForm_Load(object sender, EventArgs e)
        {
            brands = _servicio.GetBrandsPaginadosOrdenados(pageNum, pageSize, orden);

            SeleccionarLista();

            RecargarGrilla(brands, cantidadRegistros);
        }

        private void RecargarGrilla(List<Brand> brands, int cantReg)
        {

            cantidadPaginas = FormHelper.CalcularPaginas(cantReg, pageSize);

            CantidadPaginasLbl.Text = cantidadPaginas.ToString();

            PaginaActualLbl.Text = (pageNum + 1).ToString();

            CantidadMarcasLbl.Text = cantReg.ToString();

            GridHelper.MostrarDatosEnGrilla<Brand>(brands, DgvBrands);

            foreach (DataGridViewRow r in DgvBrands.Rows)
            {
                r.Height = 40;
            }
        }

        private void BuscarMarcaTxt_TextChanged(object sender, EventArgs e)
        {
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void SeleccionarLista()
        {
            if (BuscarMarcaTxt.Text == "")
            {
                brands = _servicio.GetBrandsPaginadosOrdenados(pageNum, pageSize, orden);
                cantidadRegistros = _servicio.GetCantidad();
            }
            else
            {
                textFil = BuscarMarcaTxt.Text;
                brands = _servicio.GetBrandsPaginadosOrdenados(pageNum, pageSize, orden, textFil);
                cantidadRegistros = brands.Count();
            }
        }

        public void NuevaMarcaBtn_Click(object sender, EventArgs e)
        {
            BrandsFormAE frm = new BrandsFormAE();

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }
            try
            {
                Brand brand = frm.GetBrand();

                if (brand is null) return;

                if (!_servicio.Existe(brand))
                {
                    _servicio.Guardar(brand);

                    brandForShoesAE = brand;

                    BrandsForm_Load(sender, e);

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

        public Brand GetBrand()
        {
            return brandForShoesAE;
        }
        private void EditarMarcaBtn_Click(object sender, EventArgs e)
        {
            if (DgvBrands.SelectedRows.Count == 0) { return; }

            var r = DgvBrands.SelectedRows[0];

            if (r.Tag is null) return;

            Brand brand = (Brand)r.Tag;

            BrandsFormAE frm = new BrandsFormAE();

            frm.SetBrand(brand);

            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) { return; }

            try
            {
                brand = frm.GetBrand();

                if (brand is null) return;

                if (!_servicio.Existe(brand))
                {
                    _servicio.Guardar(brand);

                    GridHelper.SetearFila(r, brand);

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

        private void BorrarMarcaBtn_Click(object sender, EventArgs e)
        {
            if (DgvBrands.SelectedRows.Count == 0) { return; }

            var r = DgvBrands.SelectedRows[0];

            if (r.Tag is not null)
            {
                Brand brand = (Brand)r.Tag;

                DialogResult dr = MessageBox.Show($"¿Desea dar de baja a la marca {brand.BrandName}?",
                    "Confirmar Operación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.No) { return; }

                try
                {
                    if (!_servicio.EstaRelacionado(brand))
                    {
                        _servicio.Eliminar(brand);
                        GridHelper.QuitarFila(r, DgvBrands);
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

        private void PagUltimaBtn_Click(object sender, EventArgs e)
        {
            // Ir a la última página
            pageNum = cantidadPaginas - 1;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void PagSiguienteBtn_Click(object sender, EventArgs e)
        {
            // Ir a la siguiente página
            pageNum++;
            if (pageNum > cantidadPaginas - 1) { pageNum = cantidadPaginas - 1; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void PagAnteriorBtn_Click(object sender, EventArgs e)
        {
            // Ir a la página anterior
            pageNum--;
            if (pageNum < 0) { pageNum = 0; }
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void PagPrimeraBtn_Click(object sender, EventArgs e)
        {
            // Ir a la primera página
            pageNum = 0;
            PaginaActualLbl.Text = (pageNum + 1).ToString();
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void OrderABtn_Click(object sender, EventArgs e)
        {
            orden = Orden.AZ;
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void OrderZBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.ZA;
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

        private void ActualizarBtn_Click(object sender, EventArgs e)
        {
            orden = Orden.SinOrden;
            SeleccionarLista();
            RecargarGrilla(brands, cantidadRegistros);
        }

    }
}
