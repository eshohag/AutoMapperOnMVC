using System.Collections.Generic;
using System.ComponentModel;

namespace AutoMapperOnMVC.Models
{
    public class Department
    {
        public Department()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }
        public int Id { get; set; }
        [DisplayName("Department")]
        public string Title { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Teacher> Teachers { get; set; }
    }
}