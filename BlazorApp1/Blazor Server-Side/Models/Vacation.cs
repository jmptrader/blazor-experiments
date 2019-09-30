﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSide.Models
{
    public class Vacation
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public ICollection<User> Likes { get; set; }
    }
}
