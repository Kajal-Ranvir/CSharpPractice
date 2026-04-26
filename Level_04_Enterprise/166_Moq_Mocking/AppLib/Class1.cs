namespace AppLib
{
    public interface IMessageService
    {
        void SendMessage();
    }

    public class Notification
    {
        private readonly IMessageService _service;

        public Notification(IMessageService service)
        {
            _service = service;
        }

        public void Notify()
        {
            _service.SendMessage();
        }
    }
}