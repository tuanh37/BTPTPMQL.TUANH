namespace MvcMovie.Models
{
    public class InvoiceModel
    {
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double Index() 
        {
            return Quantity * UnitPrice;
        }
    }
}
