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
    public class LandPlots : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public LandType LandType  { get; set; }
        public ServiceType ServiceType { get; set; }
        public ListedBy ListedBy { get; set; }

        public int PlotArea { get; set; }

        public int Length { get; set; }

        public int Breadth { get; set; }

        public FacingType FacingType { get; set; }

        public string ProjectName { get; set; }


    }
}
