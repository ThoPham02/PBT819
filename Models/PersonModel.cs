using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBT819.Models {
    public class Person {
        [Key]
        public string ID { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
    }
}