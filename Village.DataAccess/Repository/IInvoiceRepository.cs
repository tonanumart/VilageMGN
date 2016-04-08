using System.Collections.Generic;
using Village.Model;

namespace Village.DataAccess.Repository
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAllInvoice();

        List<Invoice> GetInvoiceByOwner(int ownerId);
    }
}