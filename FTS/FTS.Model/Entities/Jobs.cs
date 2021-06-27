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
    public class Jobs : BaseClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public SalaryPeriodType SalaryPeriodType { get; set; }
        public PositionType PositionType { get; set; }
        public int SalaryFrom { get; set; }
        public int SalaryTo { get; set; }
        public int Salary1To { get; set; }

    }
}
