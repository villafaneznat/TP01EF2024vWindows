﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Servicios.Interfaces;
using Size = TP01EF2024.Entidades.Size;

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

        public static void CargarComboTalles(IServiceProvider serviceProvider, ref ComboBox cbo)
        {
            var servicio = serviceProvider.GetService<ISizesService>();

            var lista = servicio?.GetSizes();

            var defaultSize = new Size
            {
                SizeNumber = 0
            };

            lista?.Insert(0, defaultSize);
            cbo.DataSource = lista;
            cbo.DisplayMember = "SizeNumber";
            cbo.ValueMember = "SizeId";
            cbo.SelectedIndex = 0;

            cbo.Format += (s, e) =>
            {
                if (e.ListItem != null)
                {
                    var size = (Size)e.ListItem;
                    if (size.SizeNumber == 0)
                    {
                        e.Value = "Seleccione...";
                    }
                    else
                    {
                        e.Value = size.SizeNumber.ToString();
                    }
                }
            };
        }


    }
}
