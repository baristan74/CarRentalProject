using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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


            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car Name : " + car.BrandName + car.CarName + "Car Color:" + car.ColorName + "Car Daily Price:" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            

            

        }
    }
}
