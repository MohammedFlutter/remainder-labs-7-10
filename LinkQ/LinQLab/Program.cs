using LinQLab;
using System.Collections.Generic;
using static L2O___D09.ListGenerators;


//1.Find all products that are out of stock.
var products1 = ProductList.Where(p => p.UnitsInStock == 0);
//2. Find all products that are in stock and cost more than 3.00 per unit.
var products2 = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

//3 Returns digits whose name is shorter than their value.
string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
var digit = Arr.Where(e => e.Length == Arr.Min(c => c.Length)).ToList();
digit.ForEach(Console.WriteLine);

//1.Get first Product out of Stock 
var product1 = ProductList.First(p => p.UnitsInStock == 0);
var product2 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

//Retrieve the second number greater than 5 
int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine(Arr2.Where(e => e > 5).Take(2).ToList()[1]);

//Find the unique Category names from Product List
var categroys = ProductList.Select(e => e.Category).ToHashSet().ToList();
//categroys.ForEach(Console.WriteLine);

var productNames = ProductList.Select(e => e.ProductName);
var companyNames = CustomerList.Select(e => e.CompanyName);
var productNameFirstLetter = productNames.Where(e => e.Length != 0).Select(e => e[0]);
var companyNamesFirstLetter = companyNames.Where(e => e.Length != 0).Select(e => e[0]);


//1
var uniqueFirstLetter1 = productNameFirstLetter.Union(companyNamesFirstLetter).ToHashSet().ToList();
var uniqueFirstLetter2 = productNameFirstLetter.Intersect(companyNamesFirstLetter).ToHashSet().ToList();
var uniqueFirstLetter3 = productNameFirstLetter.Except(companyNamesFirstLetter).ToHashSet().ToList();
var last3 = productNames.Concat(companyNames).Where(e => e.Length > 2).Select(e => e.Substring(e.Length - 3));

//last3.ToList().ForEach(Console.WriteLine);

int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
Console.WriteLine(Arr3.Count(e => e % 2 == 1));


CustomerList.Select(e => new { e.CompanyName, e.Orders.Length }).ToList();
var category1 = ProductList.GroupBy(e => e.Category).Select(e => e.ToList()).Select(e => new { e[0].Category, e.Count });
//category1.ToList().ForEach(Console.WriteLine);


//Console.WriteLine($"Sum: {Arr2.Sum()}");
//Console.WriteLine($"min length {ReadDictionary.Names.Min(e => e.Length)}"); ;
var categoryProduct = ProductList.GroupBy(e => e.Category).Select(e => e.ToList());
categoryProduct.Select(e => new { e[0].Category, min = e.Min(e1 => e1.UnitPrice) });
//.ToList().ForEach(Console.WriteLine);
categoryProduct.Select(e => new { e[0].Category, min = e.MinBy(e1 => e1.UnitPrice) });
//.ToList().ForEach(Console.WriteLine);
Console.WriteLine("longest words: " + ReadDictionary.Names.MaxBy(e => e.Length));
categoryProduct.Select(e => new { e[0].Category, max = e.Max(e1 => e1.UnitPrice) });
categoryProduct.Select(e => new { e[0].Category, max = e.MaxBy(e1 => e1.UnitPrice) });

Console.WriteLine("average words: " + ReadDictionary.Names.Average(e => e.Length));
categoryProduct.Select(e => new { e[0].Category, average = e.Average(e1 => e1.UnitPrice) });


ProductList.OrderBy(e => e.ProductName);

string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
words.Order(StringComparer.OrdinalIgnoreCase);
//.ToList().ForEach(Console.WriteLine);
ProductList.OrderByDescending(e => e.UnitsInStock);

Arr.OrderBy(e => e.Length).ThenBy(e => e);
//.ToList().ForEach(Console.WriteLine);

words.OrderBy(e => e.Length).ThenBy(e => e, StringComparer.OrdinalIgnoreCase);
//.ToList().ForEach(Console.WriteLine);
ProductList.OrderBy(e => e.Category).ThenByDescending(e => e.UnitPrice);
//.ToList().ForEach(Console.WriteLine);
words.OrderBy(e => e.Length).ThenByDescending(e => e, StringComparer.OrdinalIgnoreCase);
//.ToList().ForEach(Console.WriteLine);
Arr.Where(e => e[1] == 'i').Reverse();
//.ToList().ForEach(Console.WriteLine);

CustomerList.Where(e => e.Address == "Washington").Select(e => e.Orders.Take(3).ToList());
//.ToList().ForEach(Console.WriteLine);

CustomerList.Where(e => e.Address == "Washington").Select(e => e.Orders.Skip(2).ToList());
//.ToList().ForEach(Console.WriteLine);

Arr2.Where((e, i) => e >= i);
//.ToList().ForEach(Console.WriteLine);
Arr2.SkipWhile((e) => e % 3 == 0);
//.ToList().ForEach(Console.WriteLine);
Arr2.TakeWhile((e, i) => e >= i);
//.ToList().ForEach(Console.WriteLine);
ProductList.Select(e => e.ProductName);
//.ToList().ForEach(Console.WriteLine);
words.Select(e => new { upper = e.ToUpper(), lower = e.ToLower() });
//.ToList().ForEach(Console.WriteLine);

ProductList.Select(e => new { Price = e.UnitPrice });
//.ToList().ForEach(Console.WriteLine);

Arr2.Select((e, i) => new { e, match = e == i });
//.ToList().ForEach(Console.WriteLine);

int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
int[] numbersB = { 1, 3, 5, 7, 8 };

numbersA.SelectMany(
   a => numbersB,
   (a, b) => new { a, b }
).Where(pair => (pair.a < pair.b));
//.ToList().ForEach(Console.WriteLine);
CustomerList.SelectMany(e => e.Orders).Where(e => e.Total < 500);
//.ToList().ForEach(Console.WriteLine);
CustomerList.SelectMany(e => e.Orders).Where(e => e.OrderDate >= new DateTime(1998, 1, 1));
//.ToList().ForEach(Console.WriteLine);
Console.WriteLine("dictionary contain 'ei' " + (ReadDictionary.Names.Any(e => e.Contains("ei"))));

ProductList.GroupBy(e => e.Category).Where(e => e.Any(e => e.UnitsInStock == 0)).Select(e => e.ToList());
//.ToList().ForEach(e=>e.ForEach(Console.WriteLine));

ProductList.GroupBy(e => e.Category).Where(e => e.All(e => e.UnitsInStock > 0)).Select(e => e.ToList());
//.ToList().ForEach(e=>e.ForEach(Console.WriteLine));

List<int> numbers = Enumerable.Range(0, 15).ToList();

numbers.GroupBy(e => e % 5).Select(e => e.ToList())
    .ToList().ForEach(e =>
    {
        Console.WriteLine($"Numbers with a remainder of {e[0] % 5} when divided by 5:");
        e.ForEach(Console.WriteLine);
    });

ReadDictionary.Names.GroupBy(e => e[0]).Select(e => e.ToList());
    //.ToList().ForEach(e =>
    //    e.ForEach(Console.WriteLine)
    //);

string[] Arr4 = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
Arr4.GroupBy(e => e, new SameCharactersComparer())
    .Select(e => e.ToList())
    .ToList().ForEach(e =>
{
    Console.WriteLine("Words with same characters:");
    e.ForEach(Console.WriteLine);
});


class SameCharactersComparer : IEqualityComparer<string>
{
    public bool Equals(string word1, string word2)
    {
        if (word1.Trim().Length != word2.Trim().Length) return false;

        var list1 = word1.Trim().ToCharArray().OrderBy(e=>e).ToList();
        var list2 = word2.Trim().ToCharArray().OrderBy(e=>e).ToList();

        return list1.Zip(list2, (e1, e2) => e1 == e2).All(e => e);
    }

    public int GetHashCode(string obj)
    {
        return new string(obj.Trim().OrderBy(c => c).ToArray()).GetHashCode();
    }
}