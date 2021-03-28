using Business.Concrete;
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
            //CarTest
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Car name ="+car.CarName+ " "+ "Günlük fiyat = "+" "+car.DailyPrice );
            //}


            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("Car Name : " + car.BrandName + car.CarName + "Car Color:" + car.ColorName + "Car Daily Price:" + car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User {UserId=2,FirstName="Can",LastName="Temiz",Email="asdad@gmail.com",Password="123" });



            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { CarId = 9, ColorId = 1, CarName="ads",ModelYear = 1999, DailyPrice =500 , Description = "asdasdasd" });



        }
    }
}
