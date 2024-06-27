using Notes.Tests.Common;
using Notes.Application.Notes.Commands.DeleteCommand;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exceptions;
namespace Notes.Tests.Notes.Commands;

public class DeleteNoteCommandHandlerTests : TestCommandBase
{
    [Fact]
    public async Task DeleteNoteCommandHandler_Success()
    {
        //Arrange 
        var handler = new DeleteNoteCommandHandler(Context);

        //Act 
        await handler.Handle(new DeleteNoteCommand
        {
            Id = NotesContextFactory.NoteIdForDelete,
            UserId = NotesContextFactory.UserAId
        }, CancellationToken.None);

        // Assert 

        Assert.NotNull(Context.Notes.SingleOrDefault(note =>
        note.Id == NotesContextFactory.NoteIdForDelete));

    }

    [Fact]
    public async Task DeleteNoteCommandHandler_FailOnWrongId()
    {
        //Arrange 
        var handler = new DeleteNoteCommandHandler(Context);

        //Act
        //Assert
        await Assert.ThrowsAsync<NotFoundException>(async () =>
        await handler.Handle(
            new DeleteNoteCommand
            {
                Id = Guid.NewGuid(),
                UserId = NotesContextFactory.UserAId
            },
            CancellationToken.None));
    }

    [Fact]
    public async Task DeleteNoteCommandHandler_FailOnWrongUserId()
    {

    }
}