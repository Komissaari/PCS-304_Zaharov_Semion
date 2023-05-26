using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Publisher { get; set; }
        public string? Name_Publisher { get; set; }

        public virtual ICollection<Books>? Books { get; set; }
    }
}
