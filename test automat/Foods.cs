using Automat;

namespace test_automat
{
    internal class Foods : VendingMachine
    {
        public static Foods ChickenNoodle = new Foods { Name = "Chicken Noodle", Price = 20M, Description = ":Descripton: this is a Chicken Noodle packet",ID = 1 };
        public static Foods PrawnNoodle = new Foods { Name = "Prawn Noodle", Price = 20M, Description = ":Descripton: this is a Prawn Noodle packet", ID = 2 };
        public static Foods BeefnNodles = new Foods { Name = "Beef Noodle", Price = 20M, Description = ":Descripton: this is a Beef Noodle packet", ID = 3 };

        public static List<Foods> foodsMenu = new List<Foods>
        {
            ChickenNoodle,
            PrawnNoodle,
            BeefnNodles
            
        };
    }
}
