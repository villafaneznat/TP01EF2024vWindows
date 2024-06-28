using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboMarcas(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IBrandsService>();

            var lista = servicio?.GetBrands();

            var defaultBrand = new Brand
            {
                BrandName = "Seleccione..."
            };

            lista?.Insert(0, defaultBrand);
            cbo.DataSource = lista;
            cbo.DisplayMember = "BrandName";
            cbo.ValueMember = "BrandId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboDeportes(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISportsService>();

            var lista = servicio?.GetSports();

            var defaultSport = new Sport
            {
                SportName = "Seleccione..."
            };

            lista?.Insert(0, defaultSport);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SportName";
            cbo.ValueMember = "SportId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboGeneros(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IGenresService>();

            var lista = servicio?.GetGenres();

            var defaultGenre = new Genre
            {
                GenreName = "Seleccione..."
            };

            lista?.Insert(0, defaultGenre);
            cbo.DataSource = lista;
            cbo.DisplayMember = "GenreName";
            cbo.ValueMember = "GenreId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboColores(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<IColoursService>();

            var lista = servicio?.GetColours();

            var defaultColour = new Colour
            {
                ColourName = "Seleccione..."
            };

            lista?.Insert(0, defaultColour);
            cbo.DataSource = lista;
            cbo.DisplayMember = "ColourName";
            cbo.ValueMember = "ColourId";
            cbo.SelectedIndex = 0;
        }


    }
}
