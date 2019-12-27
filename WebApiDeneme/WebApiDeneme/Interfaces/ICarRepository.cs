using System.Collections.Generic;

namespace WebApiDeneme.Interfaces
{
    public interface ICarRepository
    {
        Models.Car Insert(Models.Car car);
        Models.Car Update(Models.Car car);
        void Delete(int id);
        List<Models.Car> List();
        Models.Car Get(int id);
    }
}
