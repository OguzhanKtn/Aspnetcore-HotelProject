﻿namespace WebUI.Dtos.MessageDetailDto
{
    public class SendboxMessageDetailDto
    {
        public string Receiver { get; set; }
        public string ReceiverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
