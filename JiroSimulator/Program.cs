using Bogus;
using JiroSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace JiroSimulator
{
class Program
{
        static void Main(string[] args)
        {
            var taskBogus = new Faker<BaseTask>()
                    .RuleFor(r => r.Estimation, f => f.Random.Number(1, 7))
                    .RuleFor(r => r.Title, f => f.Lorem.Sentence())
                    .RuleFor(r => r.Description, f => f.Lorem.Sentence())
                    .RuleFor(r => r.Id, f => Guid.NewGuid().ToString())
                    .RuleFor(r => r.UpdatedDate, f => DateTime.Now)
                    .RuleFor(r => r.Status, f => f.Random.Enum<TaskStatuses>());


            var userBogus = new Faker<User>()
                .RuleFor(r => r.FirstName, f => f.Name.FirstName())
                .RuleFor(r => r.LastName, f => f.Name.LastName())
                .RuleFor(r => r.Id, f => Guid.NewGuid().ToString())
                .RuleFor(r => r.Image, f => f.Image.Locale);


            /*var tasks = taskBogus.Generate(new Faker().Random.Number(120, 200));
            foreach (var task in tasks)
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
            }*/
        }
    }
}
