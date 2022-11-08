using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace Ambrus_Andrea_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
