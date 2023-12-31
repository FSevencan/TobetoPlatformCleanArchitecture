using Core.Application.Responses;
using Domain.Entities;

namespace Application.Features.Lessons.Queries.GetById;

public class GetByIdLessonResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ProducerCompanyId { get; set; }
    public Guid CourseId { get; set; }
    public Guid LanguageId { get; set; }
    public string Name { get; set; }
    public double Time { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public Course Course { get; set; }
    public Language Language { get; set; }
    public ProducerCompany ProducerCompany { get; set; }
}