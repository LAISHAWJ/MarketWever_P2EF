using Microsoft.EntityFrameworkCore;
using MarketWevers_Northwind.DataDb;
using MarketWevers_Northwind.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWevers_Northwind
{
        public interface IproductoCRUD
        {
            bool ActualizarProducto(int ProductID, string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice, short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued);
            bool AgregarProducto(string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice, short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued);
            bool EliminarProducto(string ProductName);
            List<Product> ObtenerProductos();
        }

        public class CRUDProduc : IproductoCRUD
        {
            string connectionString = Program.Configuration.GetConnectionString("NorthwindConnectionString");

            public List<Product> ObtenerProductos()
            {
                var dbcontext = new NorthwindContext();
                var productos = dbcontext.Products.ToList();
                return productos;
            }

            public bool AgregarProducto(string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice,
                                 short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued)
            {
                var dbcontext = new NorthwindContext();
                var producto = new Product();
                dbcontext.Products.Add(producto);
                if (producto == null)
                {
                    return false;
                }

                producto.ProductName = ProductName;
                producto.SupplierId = SupplierID;
                producto.CategoryId = CategoryID;
                producto.QuantityPerUnit = QuantityPerUnit;
                producto.UnitPrice = UnitPrice;
                producto.UnitsInStock = UnitsInStock;
                producto.UnitsOnOrder = UnitsOnOrder;
                producto.ReorderLevel = ReorderLevel;
                producto.Discontinued = Discontinued;

                try
                {
                    dbcontext.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }

            public bool ActualizarProducto(int ProductID, string ProductName, int SupplierID, int CategoryID, string QuantityPerUnit, decimal UnitPrice,
                               short UnitsInStock, short UnitsOnOrder, short ReorderLevel, bool Discontinued)
            {
                 var dbContext = new NorthwindContext();
                 var product = dbContext.Products.FirstOrDefault(p => p.ProductId == ProductID);
                 if (product == null)
                 {
                return false;
                 }
                    product.ProductName = ProductName;
                    product.SupplierId = SupplierID;
                    product.CategoryId = CategoryID;
                    product.QuantityPerUnit = QuantityPerUnit;
                    product.UnitPrice = UnitPrice;
                    product.UnitsInStock = UnitsInStock;
                    product.UnitsOnOrder = UnitsOnOrder;
                    product.ReorderLevel = ReorderLevel;
                    product.Discontinued = Discontinued;
                 try
                 {
                    dbContext.SaveChanges();
                    return true;
                 }
                catch (Exception ex)
                 {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                 }
            }
            public bool EliminarProducto(string ProductName)
            {
               var dbContext = new NorthwindContext();
               var product = dbContext.Products.FirstOrDefault(p => p.ProductName == ProductName);
               if (product == null)
               {
                    return false;
               }

               dbContext.Products.Remove(product);

               try
               {
                    dbContext.SaveChanges();
                    return true;
               }
               catch (Exception ex)
               {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
               }
            }

        }  
    
}
    

