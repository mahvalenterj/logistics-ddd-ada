using System;
using AutoMapper;
using techLogistica.Domain.Entities;

public class ConsumerMessageMapper : Profile
{
    public ConsumerMessageMapper()
    {
        CreateMap<ConsumerMessageRequest, MessageReceivedEventArgs>();
    }
}
