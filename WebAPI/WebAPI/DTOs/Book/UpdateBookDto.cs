﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs.Book
{
    public class UpdateBookDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}