﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Servicios.Interfaces
{
    public interface IShoesService
    {
        void Guardar(Shoe shoe);
        void Eliminar(Shoe shoe);
        bool Existe(Shoe shoe);
        List<Shoe> GetShoes();
        int GetCantidad();
        Shoe GetShoePorId(int id);
        bool EstaRelacionado(Shoe shoe);
        ShoeSize? GetShoeSize(Shoe shoe, Size size);
        bool ExisteShoeSize(ShoeSize shoesize);

        void AgregarShoeSize(ShoeSize nuevaRelacion);
        List<Shoe> GetListaShoesPaginadaOrdenadaFiltrada(
            int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        int GetCantidadFiltrada(Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);

        List<Size> GetSizesForShoe(int shoeId);

        int GetStockShoeSize(Shoe shoe, Size size);

        List<ShoeDto> GetListaDto();

        List<ShoeDto> GetListaShoesDtosPaginadaOrdenadaFiltrada(
            int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        void EliminarShoeSize(ShoeSize shoeSize);
        void ActualizarShoeSize(ShoeSize shoesize);

        List<ShoeSize> GetShoesSizesPaginados(int page, int pageSize, Shoe shoe);
    }
}
