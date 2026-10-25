// Q1
var seafoodProducts = Products
    .Where(s => s.Category = "Seafood")
    .Select(s => s.Name, s.UnitPrice);

// Q2
var productNames = Products
    .Select(s => s.Name);

// Q3
var sortedProducts = Products
    .OrderByAscending(s => s.UnitPrice)
    .Select(s => s.Name, s.UnitPrice);

// Q4
var productsBetween10and30 = Products
    .Where(s => s.UnitPrice > 10 && s.UnitPrice < 30);

// Q5
var condimentProducts = Products
    .Select(s => s.Category = "Condiments" && s.UnitsInStock > 0);

// Q6
var AnonymousProduct = products
    .Select(s => new {s.Name, s.UnitPrice, s.UnitsInStock > 0 ? "Available" : "Out of stock"});
forEach(product in AnonymousProduct){
    Console.WriteLine(product);
}

// Q7
var indexedNames = products
    .Select((product, index) => $"{index+1}. {product.Name}");


// Q8
var doubleSort = products
    .OrderByAscending(s => s.Category)
    .ThenByDescending(s => s.UnitPrice);

// Q9
var beverageProducts = products
    .Where(s => s.Category = "Beverages")
    .Select(s => s.Name, s.UnitsInStock);

// Q10
var orders1997 = from customer in customers
                from order in customer.Orders
                where order.OrderDate.Year >= 1997
                select new 
                { 
                    CustomerID = order.CustomerID,
                    OrderDate = order.OrderDate 
                };

// Q11
var indexedProducts = products.Select((product, index) => new 
    { 
        Position = index + 1, 
        ProductName = product.ProductName 
    });

// Q12
string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

var sortedWords = Arr
    .OrderBy(word => word.Length)
    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

// Q13
string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

var result = digits
    .Where(d => d.Length > 1 && char.ToLower(d[1]) == 'i')
    .Reverse();