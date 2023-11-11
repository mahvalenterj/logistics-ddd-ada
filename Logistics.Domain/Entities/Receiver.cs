using Logistica.Domain.Entities;

namespace Logistics.Domain.Entities
{
    public class Receiver : BaseEntity
    {
        public Guid ReceiverID { get; set; }

        public Guid AddressID { get; set; }

        public string Name { get; set; }


    }

}

