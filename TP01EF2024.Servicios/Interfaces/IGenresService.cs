﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IGenresService
    {
        void Guardar(Genre genre);
        void Eliminar(Genre genre);
        bool EstaRelacionado(Genre genre);
        bool Existe(Genre genre);
        Genre? GetGenrePorId(int id);
        List<Genre> GetGenres();
        int GetCantidad();
        List<Shoe>? GetShoes(Genre genre);
        List<Genre> GetGenresPaginadosOrdenados(int page, int pageSize, Orden? orden = null);
    }
}
