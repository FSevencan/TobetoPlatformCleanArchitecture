using Application.Features.Sections.Queries.GetList;
using Core.Application.Dtos;

namespace Application.Features.Categories.Queries.GetList;

public class GetListCategoryListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<GetListCategorySectionsDto> Sections { get; set; }
}