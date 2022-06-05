using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    interface IEntityBase
    {
        public int Id { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUser { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }
    }
}
