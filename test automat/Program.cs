using test_automat;

namespace Automat;
internal class Program
{

    public static Customer customer = new Customer();
    public static bool start = true;

    static void Main(string[] args)
    {

        Console.WriteLine("Press 'D' for Drinks, 'S' for Sweets and F for Food. 'I' to view inventory. Any other key to quit: ");

        char itemType = Console.ReadKey().KeyChar;
        Console.WriteLine();

        while (itemType != 'q')
        {

            switch (itemType)
            {
                case 'd':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back.");
                    foreach (Drinks drinks in Drinks.drinkMenu) 
                    {
                        Console.WriteLine($"{drinks.ID}: {drinks.Name} {drinks.Description} ({drinks.Price:c})");
                    }
                    char customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':
                            customer.customerInventoryList.Add(Drinks.CocaCola);
                            customer.Money -= Drinks.CocaCola.Price;
                            Console.WriteLine($"\nYou bought a {Drinks.CocaCola.Name}");
                            break;
                        case '2':
                            customer.customerInventoryList.Add(Drinks.PepsiMax);
                            customer.Money -= Drinks.PepsiMax.Price;
                            Console.WriteLine($"\nYou bought a {Drinks.PepsiMax.Name}");
                            break;
                        case '3':
                            customer.customerInventoryList.Add(Drinks.Fanta);
                            customer.Money -= Drinks.Fanta.Price;
                            Console.WriteLine($"\nYou bought a {Drinks.Fanta.Name}");
                            break;
                        case '4':
                            customer.customerInventoryList.Add(Drinks.Sprite);
                            customer.Money -= Drinks.Sprite.Price;
                            Console.WriteLine($"\nYou bought a {Drinks.Sprite.Name}");
                            break;
                    }
                    break;


                case 's':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back.");
                    foreach (Sweets sweets in Sweets.sweetsMenu)
                    {
                        Console.WriteLine($"{sweets.ID}: {sweets.Name} {sweets.Description} ({sweets.Price:c})");
                    }
                    customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':
                            customer.customerInventoryList.Add(Sweets.Snickers);
                            customer.Money -= Sweets.Snickers.Price;
                            Console.WriteLine($"\nYou bought a {Sweets.Snickers.Name} for {Sweets.Snickers.Price:c}.");
                            break;
                        case '2':
                            customer.customerInventoryList.Add(Sweets.Pringles);
                            customer.Money -= Sweets.Pringles.Price;
                            Console.WriteLine($"\nYou bought a {Sweets.Pringles.Name} for {Sweets.Pringles.Price:c}.");
                            break;
                        case '3':
                            customer.customerInventoryList.Add(Sweets.Twix);
                            customer.Money -= Sweets.Twix.Price;
                            Console.WriteLine($"\nYou bought a {Sweets.Twix.Name} for {Sweets.Twix.Price:c}.");
                            break;
                    }
                    break;


                case 'f':
                    Console.WriteLine("\nPress the corresponding buttons to choose a vending machine item. Any other button to go back.");
                    foreach (Foods foods in Foods.foodsMenu)
                    {
                        Console.WriteLine($"{foods.ID}: {foods.Name} {foods.Description} ({foods.Price:c})");
                    }
                    customerItem = Console.ReadKey().KeyChar;

                    switch (customerItem)
                    {
                        case '1':
                            customer.customerInventoryList.Add(Foods.ChickenNoodle);
                            customer.Money -= Foods.ChickenNoodle.Price;
                            Console.WriteLine($"\nYou bought a {Foods.ChickenNoodle.Name} for {Foods.ChickenNoodle.Price:c}.");
                            break;
                        case '2':
                            customer.customerInventoryList.Add(Foods.PrawnNoodle);
                            customer.Money -= Foods.PrawnNoodle.Price;
                            Console.WriteLine($"\nYou bought a {Foods.PrawnNoodle.Name} for {Foods.PrawnNoodle.Price:c}.");
                            break;
                        case '3':
                            customer.customerInventoryList.Add(Foods.BeefnNodles);
                            customer.Money -= Foods.BeefnNodles.Price;
                            Console.WriteLine($"\nYou bought a {Foods.BeefnNodles.Name} for {Foods.BeefnNodles.Price:c}.");
                            break;
                    }
                    break;




                case 'i':
                    Console.WriteLine($"\nCustomer money: {customer.Money:c}.");
                    Console.WriteLine($"Customer inventory:");
                    foreach (VendingMachine customerItemInventory in customer.customerInventoryList)
                    {
                        Console.WriteLine(customerItemInventory.Name);
                    }
                    break;


                default:
                    return;
            }
            Console.WriteLine("\n\nPress 'D' for Drinks and 'S' for Sweets. 'I' to view inventory. Any other key to quit: ");
            itemType = Console.ReadKey().KeyChar;

        }
    }
}