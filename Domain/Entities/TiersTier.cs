using Domain.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Entities
{
    public partial class TiersTier : IEntityBase
    {
        public TiersTier()
        {
            SalesCommands = new HashSet<SalesCommand>();
            TiersAdresses = new HashSet<TiersAdress>();
        }
        public int Id { get ; set ; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int? Telephone { get; set; }

        public virtual ICollection<SalesCommand> SalesCommands { get; set; }
        public virtual ICollection<TiersAdress> TiersAdresses { get; set; }
        public DateTime? CreatedOnDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? CreatedByUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedOnDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? UpdatedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
