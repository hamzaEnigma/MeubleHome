using Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class SalesCommandDetail : IEntityBase
    {
        public int Id { get; set; }
        public int? IdCommand { get; set; }
        public int? IdProduct { get; set; }
        public int? Quantite { get; set; }
        public double? PrixUnitaire { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUser { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }

        public virtual SalesCommand IdCommandNavigation { get; set; }
        public virtual ProductProduct IdProductNavigation { get; set; }
    }
}
