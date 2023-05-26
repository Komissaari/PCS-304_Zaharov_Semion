using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Books
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Book { get; set; }
        public string? Book_Name { get; set; }
        public int ID_Author { get; set; }
        public int ID_Publisher { get; set; }
        public virtual Authors? Authors { get; set; }
        public virtual Publisher? Publisher { get; set; }
    }
}
