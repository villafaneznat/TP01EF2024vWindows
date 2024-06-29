using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Dtos;
using TP01EF2024.Entidades.Enums;

namespace TP01EF2024.Datos.Interfaces
{
    public interface IShoesRepository
    {
        void Agregar(Shoe shoe);
        void Editar(Shoe shoe);
        void Eliminar(Shoe shoe);
        bool EstaRelacionado(Shoe shoe);
        bool Existe(Shoe shoe);
        Shoe? GetShoePorId(int id);
        List<Shoe> GetShoes();
        int GetCantidad();
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

        void AgregarShoeSize(ShoeSize nuevaRelacion);

        ShoeSize? GetShoeSize(Shoe shoe, Size size);

        void ActualizarShoeSize(ShoeSize shoeSize);

        List<ShoeDto> GetListaDto();

        List<ShoeDto> GetListaShoesDtosPaginadaOrdenadaFiltrada(int page,
            int pageSize,
            Orden? orden = null,
            string? textFil = null,
            Brand? brand = null,
            Sport? sport = null,
            Genre? genre = null,
            Colour? colour = null,
            decimal? maximo = null,
            decimal? minimo = null);
        bool ExisteShoeSize(ShoeSize shoesize);
        void EliminarShoeSize(ShoeSize shoeSize);

        List<ShoeSize> GetShoesSizesPaginados(int page, int pageSize, Shoe shoe);
    }
}
