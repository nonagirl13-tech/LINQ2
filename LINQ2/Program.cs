using LINQ.DataSources;
using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        #region Q1
       /* var result = Source.ProductList
          .OrderByDescending(p => p.UnitPrice)
          .Take(3);

        PrintCollection(result);
    }*/
        #endregion

        #region Q2

        /* var result = Source.ProductList
             .Skip(5)
             .Take(5);

         PrintCollection(result);*/
        #endregion

        #region Q3

        /*var result = Source.ProductList
        .OrderBy(p => p.UnitPrice)
        .TakeWhile(p => p.UnitPrice < 25);

        PrintCollection(result);*/
        #endregion

        #region Q4

        /* bool result = Source.ProductList
             .Where(p => p.Category == "Seafood")
             .All(p => p.UnitsInStock > 0);

         Console.WriteLine(result);*/
        #endregion

        #region Q5

        /* int[] ids = { 3, 9, 13, 18 };

         bool result = ids.Contains(9);

         Console.WriteLine(result);*/
        #endregion

        #region Q6

        /*var result = Source.ProductList
        .GroupBy(p => p.Category)
        .Select(g => $"{g.Key}: {g.Count()}");

        PrintCollection(result);*/
        #endregion

        #region Q7
        /*var result = Source.ProductList
            .GroupBy(p => p.Category)
            .Select(g => $"{g.Key}: {string.Join(", ", g.Select(p => p.ProductName))}");

        PrintCollection(result);*/
        #endregion

        #region Q8

        /* var result = Source.ProductList
            .GroupBy(p => p.Category)
            .Where(g => g.Count() > 3)
            .Select(g => $"{g.Key}: {g.Count()}");

        PrintCollection(result);*/

        #endregion

        #region Q9
        /* var result =
             from c in Source.CustomerList
             group c by c.Country into g
             select new
             {
                 Country = g.Key,
                 Count = g.Count(),
                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
             };

         PrintCollection(result);*/

        #endregion

        #region Q10
        /*var result = Source.ProductList
            .Sum(p => p.UnitsInStock);

        Console.WriteLine(result);*/
        #endregion

        #region Q11

        /* var cheapest = Source.ProductList.Min(p => p.UnitPrice);
         var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

         Console.WriteLine($"Cheapest Price: ${cheapest}");
         Console.WriteLine($"Most Expensive Price: ${mostExpensive}");*/
        #endregion

        #region Q12
        /*var result = Source.ProductList
            .Select(p => p.Category)
            .Distinct();

        PrintCollection(result);*/
        #endregion

        #region Q13
        /*int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        int[] setB = { 3, 6, 9, 12, 15, 13 };

        var result = setA.Except(setB);

        PrintCollection(result);*/
        #endregion

        #region Q14
        /* string[] list1 = { "Germany", "France", "UK", "Spain" };
         string[] list2 = { "france", "SPAIN", "Italy" };

         var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

         PrintCollection(result);*/

        #endregion

        #region Q15
        /* Dictionary<int, Product> productsDictionary = Source.ProductList
         .ToDictionary(p => p.ProductID);

         Product result = productsDictionary[18];

         Console.WriteLine(result);*/
        #endregion

        #region Q16
        /* var result = Source.ProductList
         .First(p => p.UnitPrice > 50);

         Console.WriteLine(result);*/
        #endregion

        #region Q17
        /*var result = Source.ProductList
        .FirstOrDefault(p => p.UnitPrice > 500);

        Console.WriteLine(result);*/
        #endregion

        #region Q18
        /* var result = Enumerable.Range(1, 10)
         .Select(i => $"7 x {i} = {7 * i}");

         PrintCollection(result);*/
        #endregion

        #region Q19
        /*var result = Enumerable.Range(1, 30)
        .Where(n => n % 2 == 0);

        PrintCollection(result);*/
        #endregion

        #region Q20
        /* var result = Source.ProductList
        .Select(p => p.ProductName)
        .Take(3)
        .Concat(
         Source.CustomerList
             .Select(c => c.CustomerName)
             .Take(3)
     );

         PrintCollection(result);*/
        #endregion

        #region Q21
        /*  var result = Source.ProductList
          .Zip(
          Source.CustomerList,
          (product, customer) =>
              $"{product.ProductName} sold to {customer.CustomerName}"
      );

          PrintCollection(result);*/
        #endregion


    }
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item);
        }
    }
}