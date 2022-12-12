namespace Automat
{
    class Sweets : VendingMachine
    {
        public static Sweets Snickers = new Sweets { Name = "Snickers", Price = 16M, Description = ":Descripton: this is a Snickers bar", ID = 1 };
        public static Sweets Pringles = new Sweets { Name = "Pringles", Price = 21M, Description = ":Descripton: this is a Pringles Can", ID = 2 };
        public static Sweets Twix = new Sweets { Name = "Twix", Price = 16M, Description = ":Descripton: this is a Twix bar", ID = 3 };

        public static List<Sweets> sweetsMenu = new List<Sweets>
        {
            Snickers,
            Pringles,
            Twix
        };
    }
}
