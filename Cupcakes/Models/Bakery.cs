using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Cupcakes.Models
{
    public class Bakery
    {
        [Key]
        public int BakeryId { get; set; }
        [StringLength(50, MinimumLength = 4)]
        public string BakeryName { get; set; }
        [StringLength(40, MinimumLength = 1)]
        public int Quantity { get; set; }
        [StringLength(50, MinimumLength = 4)]
        public string Address { get; set; }
        public virtual ICollection<Cupcake> Cupcakes { get; set; }
    }
}
