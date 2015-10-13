using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS.Entities;
using System.Data.Entity;

namespace BS.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            
            using (var ctx = new MagazinBDEntities())
            {
                //1.
                //var measures = ctx.Measures;
                //
                //foreach (var m in measures)
                //{
                //    Console.WriteLine("{0}. {1} - {2}", m.Id, m.Name, m.ShortName);
                //}
                ////2.
                //var customers = ctx.Customers;
                //Console.WriteLine("-----------------------");
                //foreach (var c in customers)
                //{
                //    Console.WriteLine("{0}. {1} - {2}, {3}", c.Id, c.Name, c.Address , c.Phone);
                //}
                //3.
                //Query Syntax
                //var product = from p in ctx.Products
                //              where p.ProducerId == 2
                //              select p;
                //
                //Method Syntax
                //var product2 =
                //    ctx.Products.Where(p => p.ProducerId == 2);
                //Console.WriteLine("-----------------------------------");
                //foreach(var p in product2)
                //{
                //    Console.WriteLine("{0}. {1} - {2}" , p.Id , p.ProducerId , p.Name);
                //}
                //4.
                int idReq = 15;
               // var _answ4_1 =
               //     from p in ctx.Products
               //     join c in ctx.Categories
               //      on p.CategoryId equals c.Id
               //     where c.ParentId == idReq
               //     select new
               //     {
               //         SubCategoryName = c.Name,
               //         ProductName = p.Name
               //     };
               //

               // List<Product> _answ4_2 = ctx.Products
               //     .Where(p => p.Categories.ParentId == idReq).ToList();
               //
               // foreach (var a in _answ4_2)
               // {
               //     Console.WriteLine("{0}. {1} ({2})" , a.Id , a.Name , a.Categories.Name);
               // }
                //5.
                //var _answ5_1 =
                //    from pp in ctx.Packages
                //    join p in ctx.Products
                //    on pp.ProductId equals p.Id
                //    where pp.Volume < 20
                //    select new { 
                //    ProdPackageId = pp.Id,
                //    ProdName = p.Name,
                //    ProdPackageVol = pp.Volume
                //    }; 
                //foreach(var a in _answ5_1)
                //{
                //    Console.WriteLine(a.ProdPackageId + "." + a.ProdName + " " + a.ProdPackageVol);
                //}
               // var _answ5_2 =
               //     ctx.Packages.Include(pg => pg.Product)
               //     .Where(p => p.Volume < 20);
               // foreach(var a in _answ5_2)
               // {
               //     Console.WriteLine(a.Id+ "." + a.Product.Name + " " + a.Volume);
               // }
                //6.
                //DateTime date1 = new DateTime(2014, 3, 15);
                //DateTime date2 = new DateTime(2014, 4, 1);
                //var _answ6_1 =
                //    from io in ctx.Orders
                //    where (io.Time >= date1 && io.Time <= date2)
                //    select io;
                //    foreach(var a in _answ6_1)
                //{
                //    Console.WriteLine(a.Id+ "." + a.CustomerId  + " " + a.Time + " "+ a.Status);
                //}
                //
                    //var _answ6_2 = ctx.Orders
                    //    .Where(io => io.Time >= date1 && io.Time <= date2);
                //8.


                //9.
                //var _answ9_1 =
                //    from prop in ctx.Products
                //    orderby prop.Name
                //    select prop;
                //foreach (var a in _answ9_1)
                //{
                //    Console.WriteLine(a.Id + " :" + a.Name + " " + a.ProducerId + " " + a.CategoryId);
                //}
                //var _answ_9_2 = ctx.Products
                //    .OrderBy(p => p.Name);
                //12
                //var _answ12_1 = from p in ctx.Products
                //                where p.Name.ToLower().Contains("піно")
                //                select p;
                //foreach (var a in _answ12_1)
                //{
                //    Console.WriteLine(a.Id + " ." + a.Name);
                //}
                //var _answ12_2 = ctx.Products.Where(p => p.Name.ToLower().Contains("піно"));
                //foreach (var a in _answ12_2)
                //{
                //    Console.WriteLine(a.Id + " ." + a.Name);
                //}
                //13.
                //var _answ13_1 =
                //    from pg in ctx.Packages
                //    join p in ctx.Products
                //    on pg.ProductId equals p.Id
                //    join c in ctx.Categories
                //    on p.CategoryId equals c.Id
                //    join cc in ctx.Categories
                //    on c.ParentId equals cc.Id
                //    join pr in ctx.Producers
                //    on p.ProducerId equals pr.Id
                //    join m in ctx.Measures
                //    on pg.MeasureId equals m.Id
                //    join mm in ctx.Measures
                //    on pg.VolumeMeasureId equals mm.Id
                //    select new
                //    {
                //        packId = pg.Id,
                //        prodName = p.Name,
                //        prodCategory = c.Name,
                //        prodGroupCategory = cc.Name,
                //        producerName = pr.Name,
                //        packVolume = pg.Volume,
                //        packVolMeasue = mm.Name,
                //        packMeasure = m.Name
                //    };
                //foreach (var a in _answ13_1)
                //{
                //    Console.WriteLine(a.packId + " " + a.prodName + " " + a.prodCategory + " " +  a.prodGroupCategory +" " +a.producerName + " "
                //        + a.packVolume + " " + a.packVolMeasue+ " " + a.packMeasure);
                //}
                //var _answ13_2 = ctx.Packages
                //    .Join(ctx.Products, pg => pg.ProductId, p => p.Id, (pg, p) => new { pg, p })
                //    .Join(ctx.Categories, pc => pc.p.CategoryId, c => c.Id, (pc, c) => new { pc, c })
                //    .Join(ctx.Categories, pcc => pcc.c.ParentId, cc => cc.Id, (pcc, cc) => new { pcc, cc })
                //    .Join(ctx.Producers, ppr => ppr.pcc.pc.p.ProducerId, pr => pr.Id, (ppr, pr) => new { ppr, pr })
                //    .Join(ctx.Measures, vm => vm.ppr.pcc.pc.pg.VolumeMeasureId, m => m.Id, (vm, m) => new { vm, m })
                //    .Join(ctx.Measures, ppm => ppm.vm.ppr.pcc.pc.pg.MeasureId, pm => pm.Id, (ppm, pm) => new {ppm , pm })
                //    .Select(res => new
                //    {
                //        packId = res.ppm.vm.ppr.pcc.pc.pg.Id,
                //        prodName = res.ppm.vm.ppr.pcc.pc.p.Name,
                //        prodCategory = res.ppm.vm.ppr.pcc.c.Name,
                //        prodGroupCat = res.ppm.vm.ppr.cc.Name,
                //        producerName = res.ppm.vm.pr.Name,
                //        packVolume = res.ppm.vm.ppr.pcc.pc.pg.Volume,
                //        packVolumeMeasureId = res.ppm.m.ShortName,
                //        packMeasure = res.pm.Name
                //
                //    });
                //foreach (var a in _answ13_2)
                //{
                //    Console.WriteLine(a.packId + " " + a.prodName + " " + a.prodCategory + " " + a.prodGroupCat + " " + a.producerName + " "
                //        + a.packVolume + " " + a.packVolumeMeasureId + " " + a.packMeasure);
                //}
            }   //
            
        }
    }
}
