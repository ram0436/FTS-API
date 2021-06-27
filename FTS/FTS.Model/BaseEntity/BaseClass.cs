using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTS.Model.BaseEntity
{
   public abstract class BaseClass
    {
        public string Title { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
        public string PhotoId { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Neighbourhood { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public bool IsPremium { get; set; }
        public bool IsActive { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
       
    }
}
