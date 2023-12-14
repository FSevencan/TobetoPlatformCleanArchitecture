using Core.Application.Responses;

namespace Application.Features.Lessons.Commands.Update;

public class UpdatedLessonResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ProducerCompanyId { get; set; }
    public Guid CourseId { get; set; }
    public Guid LanguageId { get; set; }
    public string Name { get; set; }
    public TimeSpan? Time { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
}