using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDeneme.Models;

namespace WebApiDeneme.Services
{
    public class CarRepository : Interfaces.ICarRepository
    {
        private readonly DataContext _dataContext;
        public CarRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Delete(int id)
        {
            Models.Car car = Get(id);
            _dataContext.Cars.Remove(car);
            _dataContext.SaveChanges();
        }

        public Car Get(int id)
        {
            return _dataContext.Cars.Find(id);
        }

        public Car Insert(Car car)
        {
            _dataContext.Cars.Add(car);
            _dataContext.SaveChanges();

            return car;
        }

        public List<Car> List()
        {
            return _dataContext.Cars.ToList();
        }

        public Car Update(Car car)
        {
            _dataContext.Cars.Update(car);
            _dataContext.SaveChanges();
            return car;
        }
    }
}
