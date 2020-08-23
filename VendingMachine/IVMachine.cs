using System.Collections.Generic;

namespace VendingMachine
{
    public interface IVMachine
    {
        void InsertCoin(Coin coin);
        long SelectItemAndPrice(Item item);
        List<Coin> Refund();
        void Reset();
        Bucket<Item, List<Coin>> CollectItemAndChange();
    }

    public enum Coin
    {
        Penny = 1,
        Nickel = 5,
        Dime = 10,
        Quarter = 25
    }

    public enum Item
    {
        Pepsi = 25,
        Coke = 35,
        Soda = 45
    }
}
