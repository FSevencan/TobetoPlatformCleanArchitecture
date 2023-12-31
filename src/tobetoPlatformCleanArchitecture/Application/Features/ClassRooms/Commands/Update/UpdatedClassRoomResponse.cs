using Core.Application.Responses;

namespace Application.Features.ClassRooms.Commands.Update;

public class UpdatedClassRoomResponse : IResponse
{
    public Guid Id { get; set; }
    public string Branch { get; set; }
    public Guid ClassRoomTypeId { get; set; }
}