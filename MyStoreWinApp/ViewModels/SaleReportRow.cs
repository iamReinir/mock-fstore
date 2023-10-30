using BusinessObject;

namespace MyStoreWinApp.ViewModels
{
    public class SaleReportRow
    {
        public string Product_Id { get; private set; }
        public string Product_Name { get; private set; }
        public string Unit_price { get; private set; }
        public string Number_sold { get; private set; }
        public string Total_sale { get; private set; }

        private Product product;        
        
        private ICollection<OrderDetail> allDetails;

        public SaleReportRow(Product product, ICollection<OrderDetail> allDetails)
        {
            this.product = product;
            this.allDetails = allDetails;
            Product_Id = product.ID.ToString();
            Product_Name = product.Name;
            Unit_price = product.Unit_price.ToString();
            Number_sold = SumQuantity().ToString();
            Total_sale = TotalSale().ToString();

        }

        public int SumQuantity()
        {
            int res = 0;
            foreach(var item in allDetails) res += item.Quantity;
            return res;
        }

        public decimal TotalSale()
        {
            decimal res = 0;
            foreach (var item in allDetails) res += item.Quantity * product.Unit_price ?? 0.0m;
            return res;
        }

    }
}
