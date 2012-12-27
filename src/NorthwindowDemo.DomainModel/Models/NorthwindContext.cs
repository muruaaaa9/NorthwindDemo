using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using NorthwindowDemo.DomainModel.Models.Mapping;

namespace NorthwindowDemo.DomainModel.Models
{
    public interface INorthwindContext 
    {
        IDbSet<Category> Categories { get; set; }
        IDbSet<CustomerDemographic> CustomerDemographics { get; set; }
        IDbSet<Customer> Customers { get; set; }
        IDbSet<Employee> Employees { get; set; }
        IDbSet<Order_Detail> Order_Details { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<Product> Products { get; set; }
        IDbSet<Region> Regions { get; set; }
        IDbSet<Shipper> Shippers { get; set; }
        IDbSet<Supplier> Suppliers { get; set; }
        IDbSet<sysdiagram> sysdiagrams { get; set; }
        IDbSet<Territory> Territories { get; set; }
        IDbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        IDbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        IDbSet<Current_Product_List> Current_Product_Lists { get; set; }
        IDbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        IDbSet<Invoice> Invoices { get; set; }
        IDbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        IDbSet<Order_Subtotal> Order_Subtotals { get; set; }
        IDbSet<Orders_Qry> Orders_Qries { get; set; }
        IDbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        IDbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        IDbSet<Products_by_Category> Products_by_Categories { get; set; }
        IDbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        IDbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }
        IDbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        IDbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }

        int SaveChanges();

    }



    public class NorthwindContext : DbContext, INorthwindContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
            
        }

		public NorthwindContext()
			: base("Name=NorthwindContext")
		{
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
		}

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Order_Detail> Order_Details { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<Shipper> Shippers { get; set; }
        public IDbSet<Supplier> Suppliers { get; set; }
        public IDbSet<sysdiagram> sysdiagrams { get; set; }
        public IDbSet<Territory> Territories { get; set; }
        public IDbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        public IDbSet<Category_Sales_for_1997> Category_Sales_for_1997 { get; set; }
        public IDbSet<Current_Product_List> Current_Product_Lists { get; set; }
        public IDbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        public IDbSet<Invoice> Invoices { get; set; }
        public IDbSet<Order_Details_Extended> Order_Details_Extendeds { get; set; }
        public IDbSet<Order_Subtotal> Order_Subtotals { get; set; }
        public IDbSet<Orders_Qry> Orders_Qries { get; set; }
        public IDbSet<Product_Sales_for_1997> Product_Sales_for_1997 { get; set; }
        public IDbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        public IDbSet<Products_by_Category> Products_by_Categories { get; set; }
        public IDbSet<Sales_by_Category> Sales_by_Categories { get; set; }
        public IDbSet<Sales_Totals_by_Amount> Sales_Totals_by_Amounts { get; set; }
        public IDbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        public IDbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerDemographicMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new Order_DetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TerritoryMap());
            modelBuilder.Configurations.Add(new Alphabetical_list_of_productMap());
            modelBuilder.Configurations.Add(new Category_Sales_for_1997Map());
            modelBuilder.Configurations.Add(new Current_Product_ListMap());
            modelBuilder.Configurations.Add(new Customer_and_Suppliers_by_CityMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new Order_Details_ExtendedMap());
            modelBuilder.Configurations.Add(new Order_SubtotalMap());
            modelBuilder.Configurations.Add(new Orders_QryMap());
            modelBuilder.Configurations.Add(new Product_Sales_for_1997Map());
            modelBuilder.Configurations.Add(new Products_Above_Average_PriceMap());
            modelBuilder.Configurations.Add(new Products_by_CategoryMap());
            modelBuilder.Configurations.Add(new Sales_by_CategoryMap());
            modelBuilder.Configurations.Add(new Sales_Totals_by_AmountMap());
            modelBuilder.Configurations.Add(new Summary_of_Sales_by_QuarterMap());
            modelBuilder.Configurations.Add(new Summary_of_Sales_by_YearMap());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
