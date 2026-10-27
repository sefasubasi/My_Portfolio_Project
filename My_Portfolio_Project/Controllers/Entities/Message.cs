namespace My_Portfolio_Project.Controllers.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SenderName { get; set; }
        public string SebderEmail { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public string SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
