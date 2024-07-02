﻿using AutoMapper;
using Notes.Application.Notes.Queries.GetNoteDetails;
using Notes.Persistence;
using Notes.Tests.Common;
using Shouldly;

namespace Notes.Tests.Notes.Queries;


[Collection("QueryCollection")]
public class GetNoteDetailsQueryHandlerTests
{
    private readonly NotesDbContext Context;
    private readonly IMapper Mapper;

    public GetNoteDetailsQueryHandlerTests(QueryTestFixture fixture)
    {
        Context = fixture.Context;
        Mapper = fixture.Mapper;
    }


    [Fact]
    public async Task GetNoteDetailsQueryHandlerTests_Success()
    {
        //Arrange
        var handler = new GetNoteDetailsQueryHandler(Context, Mapper);

        //Act

        var result = await handler.Handle(
            new GetNoteDetailsQuery
            {
                UserId = NotesContextFactory.UserBId,
                Id = Guid.Parse("0DFC814C-F625-4B0B-8A69-1A8731591999")
            },
            CancellationToken.None);

        //Assert
        result.ShouldBeOfType<NoteDetailsVM>();
        result.Title.ShouldBe("Title2");
        result.CreationDate.ShouldBe(DateTime.Today);
    }
}
