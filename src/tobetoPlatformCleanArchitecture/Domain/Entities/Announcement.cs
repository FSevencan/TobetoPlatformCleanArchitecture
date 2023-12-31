﻿using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Announcement : Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
}
