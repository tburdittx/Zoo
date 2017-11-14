﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Lion : AnimalThatCanBeGroomed, ICanHaveMuckSweptOut
    {
        public Lion(DateTime dateOfBirth) : base(dateOfBirth) { }

        public string ICanHaveMuckSweptOut { get; set; }
    }
}

