using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ViewModels
{
    public class ProductDTO
    {
        public string Reference { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double? Prix { get; set; }
        public int? Stock { get; set; }
    }
}
