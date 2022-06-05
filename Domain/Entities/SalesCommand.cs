using Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class SalesCommand : IEntityBase
    {
        public SalesCommand()
        {
            SalesCommandDetails = new HashSet<SalesCommandDetail>();
        }

        public int Id { get; set; }
        public string Reference { get; set; }
        public int? IdTiers { get; set; }
        public DateTime? DateCommande { get; set; }
        public double? Remise { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? CreatedByUser { get; set; }
        public DateTime? UpdatedOnDate { get; set; }
        public int? UpdatedByUserId { get; set; }

        public virtual TiersTier IdTiersNavigation { get; set; }
        public virtual ICollection<SalesCommandDetail> SalesCommandDetails { get; set; }
    }
}
