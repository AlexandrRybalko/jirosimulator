using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiroSimulator
{
    class p1
    {
        static void Main(string[] args)
        {
            var carBogus = new Faker<Car>()
                    .RuleFor(r => r.CompanyId, f => f.Random.Number(1, 7))
                    .RuleFor(r => r.Model, f => f.Vehicle.Model())
                    .RuleFor(r => r.BodyType, f => f.Vehicle.Type())
                    .RuleFor(r => r.ColorId, f => f.Random.Number(1, 87))
                    .RuleFor(r => r.GearboxTypeId, f => f.Random.Number(4))
                    .RuleFor(r => r.FuelType, f => f.Vehicle.Fuel())
                    .RuleFor(r => r.DriverName, f => f.Name.FullName())
                    .RuleFor(r => r.DriverContactPhone, f => f.Phone.PhoneNumber())
                    .RuleFor(r => r.ManufactureYear, f => f.Random.Number(2015, 2020))
                    .RuleFor(r => r.Mileage, f => f.Random.Number(500, 250000));


            var accidentBogus = new Faker<Accident>()
                .RuleFor(r => r.AccidentAddress, f => f.Address.FullAddress())
                .RuleFor(r => r.AccidentDate, f => f.Date.Past(8))
                .RuleFor(r => r.Description, f => f.Lorem.Sentence());

            var damageBogus = new Faker<Damage>()
                .RuleFor(r => r.DamageDescription, f => f.Lorem.Sentence())
                .RuleFor(r => r.EstimatedRepairCostUSD, f => (f.Random.Number(40) + 1) * 100)
                .RuleFor(r => r.IsRepaired, f => f.Random.Number(3) != 0 ? true : false);

            var imageBogus = new Faker<Image>()
                .RuleFor(r => r.Description, f => f.Lorem.Sentence())
                .RuleFor(r => r.ImageURL, f => f.Image.PicsumUrl(320, 240));


            var cars = carBogus.Generate(faker.Random.Number(120, 200));
            foreach (var car in cars)
            {
                var carImageLinks = new List<ImageCar>();

                var carImages = imageBogus.Generate(faker.Random.Number(0, 5));
                foreach (var carImage in carImages)
                {
                    carImageLinks.Add(new ImageCar
                    {
                        Image = carImage
                    });
                }

                car.ImageLinks = carImageLinks;
            }
        }
        }
    }
}
