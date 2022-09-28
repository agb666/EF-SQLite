
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLLite.Models
{
    public class Dummy
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name{ get; set; }

    }
}