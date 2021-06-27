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
    public class PG : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public PGType PGType { get; set; }
        public FurnishingStatus FurnishingStatus { get; set; }
        public ListedBy ListedBy { get; set; }
        public int CarParking { get; set; }
        public bool IsMealsIncluded { get; set; }

    }
}
