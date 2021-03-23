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

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{1} -- [2} --  {3} -- {4}"+ car.BrandName+car.CarName+car.ColorName+car.DailyPrice);
            }

            

        }
    }
}
