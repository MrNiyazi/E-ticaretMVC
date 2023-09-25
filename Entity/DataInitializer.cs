using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_ticaretMVC.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var Kategoriler = new List<Category>() 
            {
                new Category() { Name = "Kamera", Description = "Kamera ürünleri"},
                new Category() { Name = "Bilgisyar", Description = "Bilgisayar ürünleri"},
                new Category() { Name = "Elektronik", Description = "Elektronik ürünleri"},
                new Category() { Name = "Telefon", Description = "Telefon ürünleri"},
                new Category() { Name = "Beyaz Eşya", Description = "Beyaz Eşya ürünleri"},
            };
            foreach (var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>() 
            {
                new Product(){Name="test",Description="deneme",Price=1200, Stock=10, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="deneme",Description="deneme",Price=1000, Stock=10, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="test",Description="test",Price=100, Stock=20, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="test",Description="deneme",Price=1200, Stock=5, IsApproved=true, CategoryId=1, IsHome = true},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}