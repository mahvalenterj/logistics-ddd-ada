using System;
using AutoMapper;
using techLogistica.Domain.Entities;

public class CreateMessageMapper : Profile
{
	public CreateMessageMapper()
	{
        CreateMap<CreateMessageRequest, Message>();
        CreateMap<Message, CreateMessageResponse>();
    }
}

