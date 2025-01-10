using ProjetoPOO.NotificationContext;

namespace ProjetoPOO.ContentContext
{
    public abstract class BaseContent : Notifiable
    {
        public BaseContent()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}