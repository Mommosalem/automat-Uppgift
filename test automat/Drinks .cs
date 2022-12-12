namespace Automat
{
    class Drinks : VendingMachine
    {
        public static Drinks CocaCola = new Drinks { Name = "Coca-Cola:", Price = 10M, Description = ":Descripton: this is a Coca-Cola can", ID = 1 };
        public static Drinks PepsiMax = new Drinks { Name = "Pepsi Max", Price = 14M, Description = ":Descripton: this is a Pepsi can", ID = 2 };
        public static Drinks Fanta = new Drinks { Name = "Fanta", Price = 10M, Description = ":Descripton: this is a Fanta can", ID = 3 };
        public static Drinks Sprite = new Drinks { Name = "Sprite", Price = 10M, Description = ":Descripton: this is a Sprite can", ID = 4 };

        public static List<Drinks> drinkMenu = new List<Drinks>
        {
            CocaCola,
            PepsiMax,
            Fanta,
            Sprite,
        };
        
    }
}
