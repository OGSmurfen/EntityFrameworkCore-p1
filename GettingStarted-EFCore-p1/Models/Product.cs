using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted_EFCore_p1.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal (6, 2)")]
        public decimal Price { get; set; }
    }
}
