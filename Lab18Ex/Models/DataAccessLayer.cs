using Lab18Ex.DatabaseStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab18Ex.Exceptions;

namespace Lab18Ex.Models
{
    public sealed class DataAccessLayer
    {
        private static DataAccessLayer instance = null;
        private DataAccessLayer()
        {

        }
        public static DataAccessLayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataAccessLayer();
                }

                return instance;

            }
        }

        public Car AddCar(string name, string manufacturerId, int productionYear,
            int cc) 
        {
            using var ctx = new AutoParkDBContext();
            if (!ctx.Manufacturers.Any(m=>m.Name==manufacturerId))
            {
                throw new InvalidManfIdException($"The Mnfucaturer id {manufacturerId} is not a valid id !");
            }
            var manufacturer = ctx.Manufacturers.First(m=>m.Name==manufacturerId);
            var key = new Key();
            var car = new Car {
                Name = name,
                ManufacturerId = manufacturer.Id,
                UserManual = new UserManual 
                { 
                ProductionYear=productionYear,
                CilindricCapacity=cc
                }
            };
           
            ctx.Cars.Add(car);
            car.Keys.Add(key);
            ctx.Keys.Add(key);
            
            manufacturer.Cars.Add(car);
            ctx.SaveChanges();
            return car;
        }
  
        public void RemoveCar(string name)
        {
            using var ctx = new AutoParkDBContext();
            var car = ctx.Cars.FirstOrDefault(m => m.Name==name);
            if (car != null)
            {
                throw new Exception();
            }
            ctx.Cars.Remove(car);
            ctx.SaveChanges();
        }
        public Manufacturer AddManufacturer(string name, string address)
        {
            using var ctx = new AutoParkDBContext();
                var manufacturer = new Manufacturer
                {
                    Name = name,
                    Address = address
                };
            ctx.Manufacturers.Add(manufacturer);    
            ctx.SaveChanges();
            return manufacturer;
        }

        public void RemoveManufacturer(string name)
        {
            using var ctx = new AutoParkDBContext();
            var manufacturer = ctx.Manufacturers.FirstOrDefault(m => m.Name==name);
            if (manufacturer != null)
            {
                throw new Exception();
            }
            ctx.Manufacturers.Remove(manufacturer);
            ctx.SaveChanges();

        }
        public  Key AddKey(int carId)
        {
            using var ctx = new AutoParkDBContext();
            var key = new Key
            {
                CarId = carId,
            };
            ctx.Keys.Add(key);
            ctx.SaveChanges();
            return key;

        }
        public void RemoveKey(int keyId)
        {
            using var ctx = new AutoParkDBContext();
            var key = ctx.Keys.FirstOrDefault(x => x.Id== keyId);
            if (key != null) 
            {
                throw new Exception();
            }
            ctx.Keys.Remove(key);
            ctx.SaveChanges();


        }
        public void ReplaceUserManual(int carid, UserManual userManual)
        {
            using var ctx = new AutoParkDBContext();
            var car = ctx.Cars.FirstOrDefault(c=> c.Id== carid);
            if (car != null)
            {
                throw new InvalidDataException();
            }
            car.UserManual = userManual;
            ctx.SaveChanges();
        }
    }
}
