using AppLib;
using Xunit;
using Moq;

public class Tests
{
    [Fact]
    public void Notify_ShouldCallSendMessage()
    {
        var mock = new Mock<IMessageService>();

        var notification = new Notification(mock.Object);

        notification.Notify();

        mock.Verify(x => x.SendMessage(), Times.Once);
    }
}