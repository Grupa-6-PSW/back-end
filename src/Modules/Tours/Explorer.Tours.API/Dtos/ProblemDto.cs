﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Dtos
{
    public class ProblemDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public int IdTourist { get; set; }
        public int IdAuthor { get; set; }
    }
}