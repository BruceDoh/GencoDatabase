namespace PervasiveDAL
{
    public class Invoice
    {
        public Invoice(int invoiceId, string customerId, int equipmentId, 
                       int previousOdometerReading, int odometerReading, 
                       int workorderId, string customerPoNumber, string invoiceDate, 
                       decimal totalNet, decimal currentCost, decimal averageCost, 
                       string nextServiceDate
)
        {
            InvoiceId = invoiceId;
            CustomerId = customerId;
            EquipmentId = equipmentId;
            PreviousOdometerReading = previousOdometerReading;
            OdometerReading = odometerReading;
            WorkorderId = workorderId;
            CustomerPoNumber = customerPoNumber;
            InvoiceDate = invoiceDate;
            TotalNet = totalNet;
            CurrentCost = currentCost;
            AverageCost = averageCost;
            NextServiceDate = nextServiceDate;
        }

        public int InvoiceId { get; set; }
        public string CustomerId { get; set; }
        public int EquipmentId { get; set; }
        public int PreviousOdometerReading { get; set; }
        public int OdometerReading { get; set; }
        public int WorkorderId { get; set; }
        public string CustomerPoNumber { get; set; }
        public string InvoiceDate { get; set; }
        public decimal TotalNet { get; set; }
        public decimal CurrentCost { get; set; }
        public decimal AverageCost { get; set; }
        public string NextServiceDate { get; set; }
    }
}