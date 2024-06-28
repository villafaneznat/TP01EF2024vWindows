using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;

namespace TP01EF2024.Windows.Helpers
{
    public static class GridHelper
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }

        public static void QuitarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object item)
        {
            switch (item)
            {
                case Brand brand:
                    r.Cells[0].Value = brand.BrandName;
                    break;
                case Sport sport:
                    r.Cells[0].Value = sport.SportName;
                    break;
                case Colour colour:
                    r.Cells[0].Value = colour.ColourName;
                    break;
                case Genre genre:
                    r.Cells[0].Value = genre.GenreName;
                    break;
                case ShoeDto shoeDto:
                    r.Cells[0].Value = shoeDto.Model;
                    r.Cells[1].Value = shoeDto.Brand;
                    r.Cells[2].Value = shoeDto.Color;
                    r.Cells[3].Value = shoeDto.Sport;
                    r.Cells[4].Value = shoeDto.Genre;
                    r.Cells[5].Value = shoeDto.Price;
                    break;
                case Shoe shoe:
                    r.Cells[0].Value = shoe.Model;
                    r.Cells[1].Value = shoe.Description;
                    r.Cells[2].Value = shoe.Brand.BrandName;
                    r.Cells[3].Value = shoe.Colour.ColourName;
                    r.Cells[4].Value = shoe.Sport.SportName;
                    r.Cells[5].Value = shoe.Genre.GenreName;
                    r.Cells[6].Value = shoe.Price;
                    break;
                default:
                    break;

            }
            r.Tag = item;
        }

        public static void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgvDatos) where T : class
        {
            LimpiarGrilla(dgvDatos);

            foreach (T t in lista)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, t);
                AgregarFila(r, dgvDatos);
            }
        }
    }
}
