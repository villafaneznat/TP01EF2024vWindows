using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;

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
