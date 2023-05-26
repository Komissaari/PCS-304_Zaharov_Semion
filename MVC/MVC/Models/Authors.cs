using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Authors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Author { get; set; }
        public string? Au_Surname { get; set; }
        public string? Au_Name { get; set; }
        public string? Au_Patrinomic { get; set; }
        public virtual ICollection<Books>? Books { get; set; }
    }
}
