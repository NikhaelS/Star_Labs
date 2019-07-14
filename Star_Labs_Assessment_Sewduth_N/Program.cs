using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Labs_Assessment_Sewduth_N
{
    abstract class Products
    {
        public string Name = "";
        public string Size = "";
        public double DP = 0;
        public double SP = 0;

        //Method to calculate default price based on size of Product.
        public double DefaultPrice()
        {
            if (Size == "S" || Size =="s")
            {
                DP = 10;
            }
            else if (Size == "M" || Size == "m")
            {
                DP = 20;
            }
            else if (Size == "L" || Size == "l")
            {
                DP = 30;
            }
            return DP;
        }

        public abstract double SpecialPrice();
    }

    class TShirt : Products
    {
        //Method to calculate price based on special parameters. T-shirts have none so default price is returned.
        public override double SpecialPrice()
        {
            return SP = DefaultPrice();
        }
    }

    class Golfer : Products
    {
        //Method to calculate price based on special parameters. Golfers have their default size price doubled.
        public override double SpecialPrice()
        {
            return SP = DefaultPrice() * 2;
        }
    }

    class Jeans : Products
    {
        //Method to calculate price based on special parameters. Jeans have none so default price is returned.
        public override double SpecialPrice()
        {
            return SP = DefaultPrice();
        }
    }

    class FormalPants : Products
    {
        //Method to calculate price based on special parameters. Formal pants have R30 added to their default size price.
        public override double SpecialPrice()
        {
            return SP = DefaultPrice() + 30;
        }
    }

    //Basket class to store items and calculate total cost.
    class Basket
    {
        //List used to store T-shirts and Golfers.
        public List<Products> Shirts = new List<Products>();

        //List used to store Jeans and Formal Pants.
        public List<Products> Pants = new List<Products>();

        //Method that calculates item prices and adds them together.
        public double TotalPrice()
        {
            double Price = 0;
            foreach (var prod in Shirts)
            {
                if (prod is TShirt)
                {
                    Price = Price + prod.SpecialPrice();
                }
                else if (prod is Golfer)
                {
                    Price = Price + prod.SpecialPrice();
                }
            }

            foreach (var prod in Pants)
            {
                if (prod is Jeans)
                {
                    Price = Price + prod.SpecialPrice();
                }
                else if (prod is FormalPants)
                {
                    Price = Price + prod.SpecialPrice();
                }
            }
            return Price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "Superdry";
            tshirt.Size = "S";
            basket.Shirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Polo";
            golfer.Size = "L";
            basket.Shirts.Add(golfer);

            var jeans = new Jeans();
            jeans.Name = "Levis";
            jeans.Size = "S";
            basket.Pants.Add(jeans);

            var pants = new FormalPants();
            pants.Name = "Gucci";
            pants.Size = "L";
            basket.Pants.Add(pants);

            //Runs TotalPrice() and displays total price of items.
            Console.WriteLine("Your total price is R{0}", basket.TotalPrice());
            Console.Read();
        }
    }
}
