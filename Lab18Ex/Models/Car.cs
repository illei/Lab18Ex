using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexAttribute = Microsoft.EntityFrameworkCore.IndexAttribute;

namespace Lab18Ex.Models
{
    [Index(nameof(Name))]
    public class Car
    {

        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        [ForeignKey(nameof(Manufacturer))]
        public int ManufacturerId { get; set; }
        /// <summary>
        /// CUM NOTAM Navigation prop cu annotation
        /// </summary>
        public Manufacturer Manufacturer { get; set; }

        public UserManual UserManual { get; set; }
       
        public List<Key> Keys { get; set; }=new List<Key>();

    }
}
