﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieRentalsDto
    {

        public int CustomerId { get; set; }
        public List<int> MoviesId { get; set; }
    }
}