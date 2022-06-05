using Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public  class ProductProduct : IEntityBase
    {
        public ProductProduct()
        {
            SalesCommandDetails = new List<SalesCommandDetail>();
        }

        public int Id { get; set; }
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double? Prix { get; set; }
        public int? Stock { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUser { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }

        public virtual ICollection<SalesCommandDetail> SalesCommandDetails { get; set; }
    }
}
