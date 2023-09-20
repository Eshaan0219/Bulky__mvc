using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Explorer
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
