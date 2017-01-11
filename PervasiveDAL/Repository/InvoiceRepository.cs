using System.Collections.Generic;

namespace PervasiveDAL.Repository
{
    public abstract class InvoiceRepository
    {
        public abstract Invoice SelectInvoiceById(int invoiceId);
        public abstract IList<Invoice> SelectInvoicesByEquipmentId(int equipmentId);
    }
}