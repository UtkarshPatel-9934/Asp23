using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtkarshSandalsStore.Models
{
    public class Sandal
    {
            public int Id { get; set; }
            [Display(Name = "Art Number")]
            public int ArtNumber { get; set; }
            [Display(Name = "Company Name")]
            public string CompanyName { get; set; }
            public string Colour { get; set; }
            public string Material { get; set; }
            [Range(1,12)]
            public int Size { get; set; }
            [Column(TypeName = "decimal(18, 2)")]
            public decimal Price { get; set; }
            [Range(1,5)]
            public int Ratings { get; set; }
    }
}
