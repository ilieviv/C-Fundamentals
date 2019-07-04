using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    class Person
    {
       public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> Bag { get; set; } = new List<string>();

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }

        public void BuyProduct(Product productToBuy)
        {
            if (this.Money >= productToBuy.Price)
            {
                this.Bag.Add(productToBuy.Name);
                this.Money -= productToBuy.Price;
                Console.WriteLine($"{this.Name} bought {productToBuy.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {productToBuy.Name}");
            }
        }
    }
}
