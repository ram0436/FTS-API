using FTS.Model.BaseEntity;
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
    public class HouseApartments : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public HouseType HouseType { get; set; }
        public ServiceType ServiceType { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public FurnishingStatus FurnishingStatus { get; set; }
        public ConstructionStatus  ConstructionStatus { get; set; }
        public ListedBy ListedBy { get; set; }
        public int SuperBuildUpArea { get; set; }
        public int CarpetArea { get; set; }

        // In case of Rent, BachelorAllowed prop consider
        public bool BachelorAllowed { get; set; }
        public int MaintenanceCharge { get; set; }

        public int TotalFloors { get; set; }

        public int FloorNumber { get; set; }

        public int CarParking { get; set; }

        public FacingType FacingType { get; set; }

        public string ProjectName { get; set; }


    }
}
