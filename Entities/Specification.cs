﻿using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Specification : IEntity
    {

        public int Id { get; set; }

        public string? Key { get; set; } 

        public string Value { get; set; } = null!;  
    }
}
