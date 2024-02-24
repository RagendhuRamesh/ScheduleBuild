using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBuildA4
{
   public class ProductMng
   {
       static SortedList<int, Product> plist = new SortedList<int, Product>()
       {
            { 1,new Product(){ Name="Coconut oil",Price=59,Brand="Parachut",ManufacturingDate=new DateTime(day:1,month:12,year:2023),ExpiryDate=new DateTime(day:1,month:12,year:2026)} },
            { 2,new Product(){ Name="gulab jamun",Price=150,Brand="rajamandri",ManufacturingDate=new DateTime(day:1,month:5,year:2023),ExpiryDate=new DateTime(day:1,month:11,year:2023)} },
            { 3,new Product(){ Name="Coco cola",Price=65,Brand="COla",ManufacturingDate=new DateTime(day:1,month:1,year:2022),ExpiryDate=new DateTime(day:1,month:1,year:2025)} },
            { 4,new Product(){ Name="Center fresh",Price=2,Brand="Perfetti",ManufacturingDate=new DateTime(day:1,month:12,year:2023),ExpiryDate=new DateTime(day:1,month:12,year:2024)} },
            { 5,new Product(){ Name="santoor",Price=35,Brand="Wipro",ManufacturingDate=new DateTime(day:1,month:12,year:2023),ExpiryDate=new DateTime(day:1,month:12,year:2026)} },
            { 6,new Product(){ Name="Milk",Price=60,Brand="Arokya",ManufacturingDate=new DateTime(day:16,month:2,year:2024),ExpiryDate=new DateTime(day:20,month:2,year:2024)} },
            { 7,new Product(){ Name="Milkpowder",Price=260,Brand="Babydown",ManufacturingDate=new DateTime(day:5,month:2,year:2024),ExpiryDate=new DateTime(day:20,month:2,year:2025)} },
            // { 8,new Product(){ Name="Sprite",Price=99,Brand="Cola",ManufacturingDate=new DateTime(day:7,month:11,year:2024),ExpiryDate=new DateTime(day:7,month:11,year:2026)} }
       };
        public SortedList<int, Product> AllProducts()
        {
            return plist;
        }
    }
}