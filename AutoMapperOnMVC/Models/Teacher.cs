namespace AutoMapperOnMVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}