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
                    .ForMember(destinationMember => destinationMember.DepartmentName,
                        opt => opt.MapFrom(src => src.Department.Title.Trim() == "CSE" ? "Computer Engineer" : src.Department.Title))
                    .ForMember(destinationMember => destinationMember.FName,
                        opt => opt.MapFrom(src => src.FirstName))
                    .ForMember(destinationMember => destinationMember.LName,
                        opt => opt.MapFrom(src => src.LastName));

                sourceToDestination.CreateMap<Teacher, Student>()
                    .ForMember(destinationMember => destinationMember.DepartmentName,
                        opt => opt.MapFrom(src => src.Department.Title.Trim() == "CSE" ? src.Department.Title : "Not accepted"))
                    .ForMember(destinationMember => destinationMember.FirstName,
                        opt => opt.MapFrom(src => src.FName))
                    .ForMember(destinationMember => destinationMember.LastName,
                        opt => opt.MapFrom(src => src.LName));
            });
        }
    }
}