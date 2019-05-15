using AutoMapperOnMVC.Models;

namespace AutoMapperOnMVC.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(sourceToDestination =>
            {
                sourceToDestination.CreateMap<Student, Teacher>()
                    .ForMember(destinationTeacherMember => destinationTeacherMember.DepartmentName,
                        sourceStudentMember => sourceStudentMember.MapFrom(src => src.Department.Title.Trim() == "CSE" ? "Computer Engineer" : src.Department.Title))

                        .ForMember(destinationTeacherMember => destinationTeacherMember.FName,
                        sourceStudentMember => sourceStudentMember.MapFrom(src => src.FirstName))

                        .ForMember(destinationTeacherMember => destinationTeacherMember.LName,
                        sourceStudentMember => sourceStudentMember.MapFrom(src => src.LastName));

                sourceToDestination.CreateMap<Teacher, Student>()
                    .ForMember(destinationStudentMember => destinationStudentMember.DepartmentName,
                        sourceTeacherMember => sourceTeacherMember.MapFrom(src => src.Department.Title.Trim() == "CSE" ? src.Department.Title : "Not accepted"))
                    
                    .ForMember(destinationStudentMember => destinationStudentMember.FirstName,
                        sourceTeacherMember => sourceTeacherMember.MapFrom(src => src.FName))
                   
                    .ForMember(destinationStudentMember => destinationStudentMember.LastName,
                        sourceTeacherMember => sourceTeacherMember.MapFrom(src => src.LName));
            });
        }
    }
}
