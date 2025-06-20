﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DTOs
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string UserId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        public CarShortDto Car { get; set; }
    }
}
