using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class StudentClassRoomRepository : EfRepositoryBase<StudentClassRoom, Guid, BaseDbContext>, IStudentClassRoomRepository
{
    public StudentClassRoomRepository(BaseDbContext context) : base(context)
    {
    }
}