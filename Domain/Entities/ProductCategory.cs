using Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class ProductCategory : IEntityBase
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int? IdProduit { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUser { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }

        public virtual ProductProduct IdProduitNavigation { get; set; }
    }
}
