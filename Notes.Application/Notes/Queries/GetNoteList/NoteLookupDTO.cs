using AutoMapper;
using Notes.Application.Common.Mappings;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNoteList;

public class NoteLookupDTO : IMapWith<Note>
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public void Mapping (Profile profile)
    {
        profile.CreateMap<Note, NoteLookupDTO>()
            .ForMember(notedDto => notedDto.Id,
            opt => opt.MapFrom(note => note.Id))
            .ForMember(notedDto => notedDto.Title,
            opt => opt.MapFrom(note => note.Title));
    }
}
