using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab18Ex.Models
{
    public class UserManual
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public int ProductionYear { get; set; }
        public int CilindricCapacity { get; set; }
        public string VIN { get; set; }= Guid.NewGuid().ToString();
    }
}
