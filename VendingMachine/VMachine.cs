using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VMachine : IVMachine
    {

        private IInventory<Coin> coinInventory = new Inventory<Coin>();
        private IInventory<Item> itemInventory = new Inventory<Item>();
        private long totalSales;
        private Item currentItem;
        private long currentBalance;

        public VMachine()
        {
            coinInventory.Put(Coin.Penny, 5);
            coinInventory.Put(Coin.Nickel, 5);
            coinInventory.Put(Coin.Dime, 5);
            coinInventory.Put(Coin.Quarter, 5);

            itemInventory.Put(Item.Pepsi, 10);
            itemInventory.Put(Item.Coke, 10);
            itemInventory.Put(Item.Soda, 10);
        }

        public Bucket<Item, List<Coin>> CollectItemAndChange()
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(Coin coin)
        {
            currentBalance += (long)coin;
            coinInventory.Add(coin);
        }

        public List<Coin> Refund()
        {
            List<Coin> refundAmount = GetChange(currentBalance);
            
            return refundAmount;
        }

       
        public void Reset()
        {
            coinInventory.Clear();
            itemInventory.Clear();
            totalSales = 0;
            currentBalance = 0;
        }

        public long SelectItemAndPrice(Item item)
        {
            if (itemInventory.HasItem(item))
                return (long)item ;
                
            throw new SoldOutException("Item sold out, please select another Item");
        }

        private List<Coin> GetChange(long amount)
        {
            List<Coin> change = new List<Coin>();

            if (amount < 0)
                return change;


            throw new NotImplementedException();
        }

    }
}
