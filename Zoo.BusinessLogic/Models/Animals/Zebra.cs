using System;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Zebra : AnimalThatCanBeGroomed, ICanHaveMuckSweptOut, IScheduler
    {
        public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
        { }

        public string ICanHaveMuckSweptOut { get; set; }

        public new string AssignJobs { get; set; }

        public string AssignJobs1()
        {
            string message = "Munch Munch";

            return message;
        }
    }
}




