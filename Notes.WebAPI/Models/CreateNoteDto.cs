﻿using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Application.Notes.Commands.CreateNotes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.WebAPI.Models;

public class CreateNoteDto : IMapWith<CreateNoteCommand>
{
    [Required]
    public string Title { get; set; }
    public string Details { get; set; }

    public void Mapping (Profile profile)
    {
        profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
            .ForMember(noteCommand => noteCommand.Title,
            opt => opt.MapFrom(noteDto => noteDto.Title))
                   .ForMember(noteCommand => noteCommand.Details,
            opt => opt.MapFrom(noteDto => noteDto.Details));

    }
}
