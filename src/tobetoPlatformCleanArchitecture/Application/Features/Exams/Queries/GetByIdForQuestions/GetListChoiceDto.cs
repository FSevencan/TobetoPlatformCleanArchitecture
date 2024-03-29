﻿using Core.Application.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Exams.Queries.GetByIdForQuestions;
public class GetListChoiceDto : IDto
{
    public Guid Id { get; set; }    
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
}
