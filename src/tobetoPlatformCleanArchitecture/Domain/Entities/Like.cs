﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Like : Entity<Guid>
{
    public int StudentId { get; set; }
    public Guid SectionId { get; set; }    

    public Student Student { get; set; }
    public Section Section { get; set; }
}