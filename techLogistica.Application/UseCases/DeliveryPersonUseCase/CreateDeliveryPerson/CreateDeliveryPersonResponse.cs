using System;

namespace techLogistica.Application.UseCases.DeliveryPerson.CreateDeliveryPerson
{
    public class CreateDeliveryPersonResponse
    {
        public Guid Id { get; init; }
        public string DeliveryPersonName { get; init; } = string.Empty; // Inicializado como string vazia para evitar null
        public string DeliveryPersonPhone { get; init; }
        public string DeliveryLicensePlate { get; init; }
        
    }
}