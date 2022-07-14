using System.ComponentModel.DataAnnotations;

namespace MVCDbConnect.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }
        
        public string Depaertment { get; set; }
    }
}
