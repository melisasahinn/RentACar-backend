﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {

        public int RentalId { get; set; }
        public string CarName { get; set; }
        public string CustomerFullName { get; set; }
        public string ImagePath { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime RentStartDate { get; set; }
        public DateTime? RentEndDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
