using System.ComponentModel.DataAnnotations;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace Lab18Ex.Models
{
    [Index(nameof(Name))]
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        /// <summary>
        /// CUM O ANNOTEZ  LA ONE 2 MANYY
        /// </summary>
        public List<Car> Cars { get; set; }= new List<Car>();

    }
}
