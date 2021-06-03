﻿using NetAPIPostgreSQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAPIPostgreSQL.Datos.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAllCars();

        //obtener un auto por id
        Task<Car> GetCarDetails(int id);

        Task<bool> InsertCar(Car car);

        Task<bool> UpdateCar(Car car);

        Task<bool> DeleteCar(Car car);
    }
}
