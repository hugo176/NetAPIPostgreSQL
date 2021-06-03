using NetAPIPostgreSQL.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetAPIPostgreSQL.Datos.Repositories
{
    public class CarRepository
    {
        private PostgreSQLConfiguration _connectionString;

        public CarRepository(PostgreSQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        public Task<bool> DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
