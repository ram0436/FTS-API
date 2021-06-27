﻿using FTS.Model.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FTS.Configuration.Enum.EnumList;

namespace FTS.Model.Entities
{
    public class Vehicles : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public VehicleType VehicleType { get; set; }
        public FuelType FuelType { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public TransmissionType TransmissionType { get; set; }
        public int KmDriven { get; set; }
        public int NoOfOwner { get; set; }

    }
}