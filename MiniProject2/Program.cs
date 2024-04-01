using MiniProject2;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

List<Product> products = new List<Product>();

while (true)
{
    string command = Menu.GetCommand();
    string cmd = command.Trim().ToLower();

    if (cmd == "q")  //If quit/print list
    {
        products = products.OrderByDescending(p => p.Price).ToList();
        Menu.Quit(products, products.Sum(p => p.Price));
        break;

    } else if (cmd == "p") //If add to list
    {  
        string category = Menu.GetCategory();
        while (!Regex.IsMatch(category, "^[A-Za-z]+$"))  //Check if category is reasonable
        {
            Menu.PrintError("Product category can only be letters");
            category = Menu.GetCategory();
        }

        string name = Menu.GetName();
        while (!Regex.IsMatch(name, "^[A-Za-z]+$"))  //Check if name is reasonable
        {
            Menu.PrintError("Product name can only be letters");
            category = Menu.GetCategory();
        }

        string price = Menu.GetPrice();
        while (!int.TryParse(price, out int p)) //Check if price can be seen as an int
        {
            Menu.PrintError("Price must be a whole number");
            price = Menu.GetPrice();
        }
        
        products.Add(new Product(category, name, Int32.Parse(price)));  //Now we know price is an int
            
    } else if (cmd == "s")  //If search for a product
    {
        string name = Menu.GetName();
        products = products.OrderByDescending(p => p.Price).ToList();
        Menu.PrintSearch(products, products.Where(product => product.Name.Contains(name)).ToList());

    } else
    {
        Menu.PrintError(command);
    }
}