using LINQ_Aggregation;

List<Phone> phones = new List<Phone>
{
    new Phone("iPhone 15", "Apple", 999, new DateOnly(2023, 9, 22)),
    new Phone("Galaxy S23", "Samsung", 899, new DateOnly(2023, 2, 17)),
    new Phone("Pixel 8", "Google", 699, new DateOnly(2023, 10, 4)),
    new Phone("OnePlus 11", "OnePlus", 749, new DateOnly(2023, 2, 7)),
    new Phone("Xperia 1 IV", "Google", 1199, new DateOnly(2022, 5, 11))
};

// Посчитайте количество телефонов
var phoneCount = phones.Select(phone => phone).Count();
Console.WriteLine($"{phoneCount} - Phone count");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Посчитайте количество телефонов с ценой больше 100
var phoneCountGreaterThan100 = phones.Where(phone => phone.Price > 750).Count();
Console.WriteLine($"{phoneCountGreaterThan100} - Phone count with price bigger than 750");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Посчитайте количество телефонов с ценой в диапазоне от 400 до 700
var phoneCountPriceRange = phones.Where(phone => phone.Price > 750 && phone.Price < 1000).Count();
Console.WriteLine($"{phoneCountPriceRange} - Phone count with price in range 750-1000");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Посчитайте количество телефонов конкретного производителя
var phonesFromCompany = phones
    .GroupBy(phone => phone.Company)
    .Select(group => new
    {
        Company = group.Key,
        Count = group.Count()
    }); 

foreach (var phone in phonesFromCompany)
{
    Console.WriteLine(phone);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Найдите телефон с минимальной ценой
var minPricePhone = phones
    .OrderBy(phone => phone.Price)  
    .First(); 
Console.WriteLine($"{minPricePhone} - phone with the min price");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

var maxPricePhone = phones
    .OrderByDescending(phone => phone.Price)
    .First();
Console.WriteLine($"{maxPricePhone} - phone with the max price");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите информацию о самом старом телефоне
var oldestPhone = phones
    .OrderBy(phone => phone.ReleaseDate)
    .First();
Console.WriteLine($"{oldestPhone} - oldest phone");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите информацию о самом свежем телефоне
var newestPhone = phones
    .OrderByDescending(phone => phone.ReleaseDate)
    .First();
Console.WriteLine($"{newestPhone} - newest phone");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Найдите среднюю цену телефона
var averagePrice = phones
    .Average(phone => phone.Price);
Console.WriteLine($"{averagePrice} - average price");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите пять самых дорогих телефонов
var top3Expensive = phones
    .OrderByDescending(phone => phone.Price)
    .Take(3);
Console.WriteLine("Top 3 expensive phones:");
foreach(var item in top3Expensive)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите пять самых дешевых телефонов
var top3Cheapest = phones
    .OrderBy(phone=>phone.Price)
    .Take(3);
Console.WriteLine("Top 3 cheapest phones:");
foreach (var item in top3Cheapest)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите три самых старых телефона
var top3Oldest = phones
    .OrderBy(phone=>phone.ReleaseDate)
    .Take(3);
Console.WriteLine("Top 3 oldest phones:");
foreach (var item in top3Oldest)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите три самых новых телефона
var top3Newest = phones
    .OrderByDescending(phone => phone.ReleaseDate)
    .Take(3);
Console.WriteLine("Top 3 oldest phones:");
foreach (var item in top3Newest)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// Отобразите статистику по количеству телефонов каждого производителя. Например: Sony – 3, Samsung – 4, Apple – 5 и т. д.

foreach (var phone in phonesFromCompany)
{
    Console.WriteLine($"{phone.Company} = {phone.Count}");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите статистику по количеству моделей телефонов. Например: IPhone 13 – 12, IPhone 10 – 11, Galaxy S22 – 8
var groupByName = phones
    .GroupBy(phone =>phone.Name)
    .Select(group => new
    {
        Name = group.Key,
        Count = group.Count()
    });
foreach (var phone in groupByName)
{
    Console.WriteLine($"{phone.Name} = {phone.Count}");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// Отобразите статистику телефонов по годам. Например: 2021 – 10, 2022 – 5, 2019 – 3
var groupByYear = phones
    .GroupBy(phone => phone.ReleaseDate.Year)
    .Select(group => new
    {
        Year = group.Key,
        Count = group.Count()
    });
foreach (var phone in groupByYear)
{
    Console.WriteLine($"{phone.Year} = {phone.Count}");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();










