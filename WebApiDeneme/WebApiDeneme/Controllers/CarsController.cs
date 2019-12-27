using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDeneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly Interfaces.ICarRepository _carRepository;
        public CarsController(Interfaces.ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.Car> cars = _carRepository.List();

            return new JsonResult(cars);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Models.Car car = _carRepository.Get(id);
           return new JsonResult(car);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Car car)
        {
            _carRepository.Insert(car);
            return new JsonResult(car);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Car car)
        {
            _carRepository.Update(car);
            return new JsonResult(car);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _carRepository.Delete(id);
            return Ok();
        }
     }
}