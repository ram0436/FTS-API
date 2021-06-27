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
    public class OfficeShops : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public FurnishingStatus FurnishingStatus { get; set; }
        public ServiceType ServiceType { get; set; }

        // in case of sale ConstructionStatus prop will applicable
        public ConstructionStatus ConstructionStatus { get; set; }
        public ListedBy ListedBy { get; set; }

        public int SuperBuildupArea { get; set; }

        public int CarpetArea { get; set; }

        public int MaintainenceCost { get; set; }

        public int CarParking { get; set; }

        public int WashRooms { get; set; }
        public string ProjectName { get; set; }

    }
}
