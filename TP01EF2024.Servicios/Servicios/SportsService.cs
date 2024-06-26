﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01EF2024.Datos.Interfaces;
using TP01EF2024.Entidades;
using TP01EF2024.Entidades.Enums;
using TP01EF2024.Servicios.Interfaces;

namespace TP01EF2024.Servicios.Servicios
{
    public class SportsService : ISportsService
    {
        private readonly ISportsRepository _repository;

        private readonly IUnitOfWork _unitOfWork;

        public SportsService(ISportsRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Eliminar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();
                _repository.Eliminar(sport);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public bool EstaRelacionado(Sport sport)
        {
            try
            {
                return _repository.EstaRelacionado(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Sport sport)
        {
            try
            {
                return _repository.Existe(sport);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Sport? GetSportPorId(int id)
        {
            try
            {
                return _repository.GetSportPorId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Sport> GetSports()
        {
            try
            {
                return _repository.GetSports();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            return _repository.GetCantidad();
        }

        public void Guardar(Sport sport)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                if (sport.SportId == 0)
                {
                    _repository.Agregar(sport);
                }
                else
                {
                    _repository.Editar(sport);
                }

                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public List<Shoe>? GetShoes(Sport sport)
        {
            return _repository.GetShoes(sport);
        }

        public List<Sport> GetSportsPaginadosOrdenados(int page, int pageSize, Orden? orden = null)
        {
            return _repository.GetSportsPaginadosOrdenados(page, pageSize, orden);
        }
    }
}
