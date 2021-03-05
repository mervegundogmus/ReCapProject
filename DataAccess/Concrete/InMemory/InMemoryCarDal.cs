using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=1, CarName = "Kiralık", ModelYear=2019,DailyPrice=150,Description="Car-1" },
            new Car{Id=1,BrandId=1,ColorId=1, CarName = "Kiralık", ModelYear=2019,DailyPrice=180,Description="Car-2" },
            new Car{Id=1,BrandId=2,ColorId=1, CarName = "Kiralık", ModelYear=2020,DailyPrice=250,Description="Car-3" },
            new Car{Id=2,BrandId=3,ColorId=1, CarName = "Satılık", ModelYear=2021,DailyPrice=300,Description="Car-4" },
            new Car{Id=2,BrandId=4,ColorId=1, CarName = "Satılık", ModelYear=2018,DailyPrice=50,Description="Car-5" },
            new Car{Id=2,BrandId=5,ColorId=1, CarName = "Satılık", ModelYear=2018,DailyPrice=40,Description="Car-6" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car); //eklendi
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(_cars => _cars.Id == car.Id); //linq kullanarak silinmek istenen arabanın referansını bulduk.
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(_cars => _cars.Id == Id).ToList(); //Id'ye göre listeleme yaptık ve bu listeyi çağırılan yere gönderdik.
        }

        public void UpDate(Car car)
        {
            Car CarToUpDate = _cars.SingleOrDefault(_cars => _cars.Id == car.Id); //linq kullanarak güncellenmek istenen arabanın referansını bulduk.
            CarToUpDate.Id = car.Id;
            CarToUpDate.BrandId = car.BrandId;
            CarToUpDate.ColorId = car.ColorId;
            CarToUpDate.ModelYear = car.ModelYear;
            CarToUpDate.DailyPrice = car.DailyPrice;
            CarToUpDate.Description = car.Description; //ve bize gönderilen değerler ile güncellenmek istenen yeri ona göre güncelledik.
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}