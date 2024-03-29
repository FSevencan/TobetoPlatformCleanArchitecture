using Domain.Entities;
using Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IChoiceRepository : IAsyncRepository<Choice, Guid>, IRepository<Choice, Guid>
{
}