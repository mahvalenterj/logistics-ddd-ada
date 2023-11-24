using System;
using techLogistica.Domain.Enums;

namespace techLogistica.Domain.Entities;

public class Message
{
    public Guid Id { get; set; }
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public MessageStatus Status { get; set; }
}