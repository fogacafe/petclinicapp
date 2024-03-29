﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetClinicApp.Source.Modules.Clinics.DTO
{
    public class ClinicDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
    }
}
