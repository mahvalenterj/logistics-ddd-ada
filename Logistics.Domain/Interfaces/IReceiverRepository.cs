using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Domain.Interfaces
{
    public interface IReceiverRepository
    {
        Task AddReceiverAsync(Receiver receiver);
    }
}
