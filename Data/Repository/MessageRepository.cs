using MySocialNetwork.Models.Users;

namespace MySocialNetwork.Data.Repository
{
    public class MessageRepository: Repository<Message>
    {
        public MessageRepository(ApplicationDbContext context) : base(context) { }
    }
}
