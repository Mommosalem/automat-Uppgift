namespace Automat
{
    class Customer
    {
        private decimal money = 100M;
        public decimal Money { get { return money; } set { money = value; } }

        public List<VendingMachine> customerInventoryList = new List<VendingMachine>();



    }
}
