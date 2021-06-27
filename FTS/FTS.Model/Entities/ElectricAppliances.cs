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
    public class ElectricAppliances : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public ElectronicApplianceType ElectronicApplianceType { get; set; }

    }
}
