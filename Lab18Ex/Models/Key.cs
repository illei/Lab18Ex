using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab18Ex.Models
{
    public class Key
    {
        [Key]
        public int Id { get; set; }
       
        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }
        public Guid AccesCode { get; set; }= Guid.NewGuid();
    }
}
