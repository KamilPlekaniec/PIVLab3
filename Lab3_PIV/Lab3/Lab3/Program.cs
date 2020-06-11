﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Kontekst();
            db.Database.EnsureCreated();
            db.Zajecias.Add(new Zajecia()
            {
                Nazwa = "P4x",
                GodzinaRozpozcecia = new DateTime(2020, 1, 1, 13, 30, 00)
            });
            db.SaveChanges();

            var zajecia = db.Zajecias.Where(x => x.ID > 2);
            foreach (var item in zajecia)
            {
                Console.WriteLine($"{ item.ID}. { item.Nazwa}. { item.GodzinaRozpozcecia}");
            }

            var zajeciaDoZmiany = db.Zajecias.First(x => x.Nazwa.StartsWith("P"));
            zajeciaDoZmiany.Nazwa = "AM2";
            db.Update(zajeciaDoZmiany);
            db.SaveChanges();


            //first db

            //var nwctx = new NorthwindContext();
            //var join = nwctx.Orders.Include(x => x.Customer);
            //var query = join.Take(5);
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.Customer.CustomerId} : {item.OrderId} : {item.OrderDate}");
            //}

            //foreach (var order in nwctx.order.Includex(x => x.Customer))
            //{
            //    Console.WriteLine(order.OrderId);
            //}

            //foreach (var item in nwctx.PozycjeZamowienia.Include(x => x))
            //{
            //    Console.WriteLine($"Id zamówienia:{item.IdZamówienia} Id produktu:{item.IdProduktu}   " +
            //        $"Nazwa produktu:{item.IdProduktuNavigation.NazwaProduktu} Cena jednostkowa:{item.IdProduktuNavigation.CenaJednostkowa} " +
            //        $"Ilość: {item.Ilość}");
            //}
            var NorthwindContext = new NorthwindContext();
            var join = NorthwindContext.Orders.Include(x => x.Customer);
            var query = join.Take(5);
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Customer.CustomerId} : {item.OrderId} : {item.OrderDate}");
            }


        }
    }
}
