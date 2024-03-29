﻿using Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Queries.GetById.Dtos;
public class GetStudentSectionListDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CategoryName { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
