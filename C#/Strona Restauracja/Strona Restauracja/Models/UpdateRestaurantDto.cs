﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja.Models
{
    public class UpdateRestaurantDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool HasDelivery { get; set; }
    }
}
