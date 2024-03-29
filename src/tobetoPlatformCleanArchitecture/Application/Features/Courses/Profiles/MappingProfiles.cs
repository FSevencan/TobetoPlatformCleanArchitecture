using Application.Features.Courses.Commands.Create;
using Application.Features.Courses.Commands.Delete;
using Application.Features.Courses.Commands.Update;
using Application.Features.Courses.Queries.GetById;
using Application.Features.Courses.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Domain.Entities;
using Core.Persistence.Paging;
using Application.Features.Lessons.Queries.GetList;
using Application.Features.Sections.Queries.GetById.Dtos;

namespace Application.Features.Courses.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Course, CreateCourseCommand>().ReverseMap();
        CreateMap<Course, CreatedCourseResponse>().ReverseMap();
        CreateMap<Course, UpdateCourseCommand>().ReverseMap();
        CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
        CreateMap<Course, DeleteCourseCommand>().ReverseMap();
        CreateMap<Course, DeletedCourseResponse>().ReverseMap();
        CreateMap<Course, GetByIdCourseResponse>().ReverseMap();
        CreateMap<Course, GetListCourseListItemDto>().ReverseMap();
        CreateMap<Course, GetListCourseDto>().ReverseMap();

        CreateMap<Course, GetCourseLessonListDto>().ReverseMap();

        CreateMap<IPaginate<Course>, GetListResponse<GetListCourseListItemDto>>().ReverseMap();
        CreateMap<IPaginate<Course>, GetListResponse<GetListLessonListItemDto>>().ReverseMap();
    }
}