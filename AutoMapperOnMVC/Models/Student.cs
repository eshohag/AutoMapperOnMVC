namespace AutoMapperOnMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}