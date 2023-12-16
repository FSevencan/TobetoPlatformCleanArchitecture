﻿using Core.Persistence.Repositories;

namespace Domain.Entities;
public class Course : Entity<Guid>
{    
    public int TotalTime { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public  ICollection<SectionCourse>? SectionCourses { get; set; }    
}
