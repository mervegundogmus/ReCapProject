using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.ColorId);
            }
          
            Console.WriteLine(carManager.Added(new Car { Id = 1, CarName = "Kiralık", BrandId = 1, ColorId = 3, ModelYear = 2019, DailyPrice = 150, Description = "Car-1" }));
        }
    }
}