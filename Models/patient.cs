using System.ComponentModel.DataAnnotations;

namespace hospitalproject.Models
{
    public class patient
    {
        [Key]
        public  int id { get; set; }
        [Required]
        public string name { get; set; }
        public string Gendar { get; set; }
        public int age { get; set; }
        [Required]
        public DateTime appoinment { get; set; }
    }
}
