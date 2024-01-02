using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBT819.Models {
    public class Student {
        [Key]
        public string ID { get; set; }
        public string PersonID { get; set; }
        public int Age { get; set; }
    }
}