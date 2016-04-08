using System.Collections.Generic;
using Village.Model;

namespace Village.Service.Repository
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAllInvoice();

        List<Invoice> GetInvoiceByOwner(int ownerId);
    }
}