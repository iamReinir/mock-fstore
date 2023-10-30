using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{

    public static class RepositoryObjects
    {
        internal class RepoAttrs<TResult>
        {
            public Func<string, string>? mapper = null;
            public Func<object[], TResult>? constructor = null;
            public string[]? insertAttrs = null;
            public string[]? eqAttrs = null;
            public string[]? selectAttrs = null;

            public void set(Repository<TResult> result)
            {              
                result.Constructor = constructor;
                result.Mapper = mapper;
                result.EqualAttributes = eqAttrs;
                result.InsertUpdateAttributes = insertAttrs;
                result.SelectAttributes = selectAttrs;
            }
        }
        static public IRepository<TResult> GetRepository<TResult>(
                IDbConnection db)
        {
            
            var curType = typeof(TResult);
            var result = new Repository<TResult>();
            result.Database = db;
            if (curType == typeof(Member))
                MemberRepos().set(result as Repository<Member>);
            else if (curType == typeof(Product))
                ProductRepos().set(result as Repository<Product>);
            else if (curType == typeof(Order))
                OrderRepos().set(result as Repository<Order>);
            else if(curType == typeof(OrderDetail))
                DetailRepos().set(result as Repository<OrderDetail>);
            return result;
        }

        private static RepoAttrs<Member> MemberRepos()
        {
            return new RepoAttrs<Member>()
            {
                mapper = (field) =>
                {
                    switch (field)
                    {
                        case "Member": return "members";
                        case "ID": return "Id";
                        case "Name": return "name";
                        case "Email": return "email";
                        case "Password": return "password";
                        case "CompanyName": return "company_name";
                        case "City": return "city";
                        case "Country": return "country";
                        default: throw new Exception("Invalid Field");
                    }
                },
                selectAttrs = new string[] {
                    "ID", "Name", "Email", "Password", "CompanyName", "City", "Country"
                },
                eqAttrs = new string[] { "ID" },
                insertAttrs = new string[] {
                    "Name", "Email", "Password", "CompanyName", "City", "Country"
                },
                constructor = (fields) =>
                {
                    return new Member()
                    {
                        ID = (int)fields[0],
                        Name = ((string)fields[1]).Trim(),
                        Email = ((string)fields[2]).Trim(),
                        Password = ((string)fields[3]).Trim(),
                        CompanyName = ((string)fields[4]).Trim(),
                        City = ((string)fields[5]).Trim(),
                        Country = ((string)fields[6]).Trim()
                    };
                },
            };
        }

        private static RepoAttrs<Product> ProductRepos()
        {
            return new RepoAttrs<Product>()
            {
                mapper = (field) =>
                {
                    if (field == "Product") return "products";
                    return field;
                },
                constructor = (fields) => {
                    Product result = new Product();
                    result.ID = (int)fields[0];
                    result.Name = ((string)fields[1]).Trim();
                    result.Category = ((string)fields[2]).Trim();
                    result.Weight = ((string)fields[3]).Trim();
                    result.Unit_price = (decimal)fields[4];
                    result.Unit_instock = (int)fields[5];
                    return result;
                },
                selectAttrs = new string[] 
                    { "ID", "Name", "Category", "Weight", "Unit_price", "Unit_instock" },
                eqAttrs = new string[] { "ID" },
                insertAttrs = new string[] { "Name", "Category", "Weight", "Unit_price", "Unit_instock" },
            };
        }
        private static RepoAttrs<Order> OrderRepos()
        {
            return new RepoAttrs<Order>()
            {
                mapper = (field) =>
                {
                    if (field == "Order") return "orders";
                    return field;
                },
                constructor = (fields) => {
                    Order result = new Order();
                    result.Id = (int)fields[0];
                    result.Member_id = (int)fields[1];
                    result.Order_date = (DateTime)fields[2];
                    result.Require_date = (DateTime)fields[3];
                    result.Shipped_date = (DateTime)fields[4];
                    result.Freight = (decimal)fields[5];                   
                    return result;
                },
                selectAttrs = new string[]
                    { "Id", "Member_id", "Order_date", "Require_date", "Shipped_date" ,"Freight" },
                eqAttrs = new string[] { "Id" },
                insertAttrs = new string[] 
                    { "Member_id", "Order_date", "Require_date", "Shipped_date", "Freight" },
            };
        }
        private static RepoAttrs<OrderDetail> DetailRepos()
        {
            return new RepoAttrs<OrderDetail>()
            {
                mapper = (field) =>
                {
                    if (field == "OrderDetail") return "order_detail";
                    return field;
                },
                constructor = (fields) => {
                    OrderDetail result = new OrderDetail();
                    result.Order_id = (int)fields[0];
                    result.Product_id = (int)fields[1];
                    result.Quantity = (int)fields[2];
                    result.Discount = (double)fields[3];                   
                    return result;
                },
                selectAttrs = new string[]
                    { "Order_id", "Product_id", "Quantity", "Discount" },
                eqAttrs = new string[] { "Order_id", "Product_id" },
                insertAttrs = new string[]
                    { "Order_id", "Product_id", "Quantity", "Discount" },
            };
        }
    }
}
