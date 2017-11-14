using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic
{
    public class Jobs : IScheduler
    {
        public string AssignJobs { get; set; }

        public void Jobs1()
        {
            var lion = new Lion(DateTime.Now);
            var zebra = new Zebra(DateTime.Now);
            var rabbit = new Rabbit(DateTime.Now);


            List<string> Jobs1 = new List<string>
            {
                // AssignFeedingJobs,
                //AssignGroomingJobs
            };

            List<Animal> animals = new List<Animal>();
            animals.Add(lion);
            animals.Add(zebra);
            animals.Add(rabbit);

            var animals1 = new[] { animals };

            // var keepers = new animals();

            List<Keeper> keepers = new List<Keeper>();


            Console.WriteLine("Assign Jobs");
            var feedingScheduler = FeedingScheduler.Instance;
            var groomingScheduler = GroomingScheduler.Instance;

            while (true)
            {
                Console.WriteLine("Feeding the animals...");
                feedingScheduler.AssignFeedingJobs(keepers, animals);

                Console.WriteLine("Grooming the animals...");
                groomingScheduler.AssignGroomingJobs(keepers, animals);

                Console.WriteLine("Done. Results:");

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }

            }

        }
        public Jobs()
        {
            Jobs1();
        }
    }
}
