using Core.Application.Responses;
using Domain.Entities;

namespace Application.Features.SectionAbouts.Queries.GetById;

public class GetByIdSectionAboutResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ProducerCompanyId { get; set; }
    public Guid SectionId { get; set; }
    public string? Text { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double EstimatedDuration { get; set; }
    //public Section Section { get; set; }
    //public ProducerCompany ProducerCompany { get; set; }
}