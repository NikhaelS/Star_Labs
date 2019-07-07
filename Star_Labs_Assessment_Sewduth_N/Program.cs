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
            if (Size == "s")
            {
                DP = 10;
            }
            else if (Size == "m")
            {
                DP = 20;
            }
            else if (Size == "l")
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
        //List used to store T-shirts.
        public List<TShirt> TShirts = new List<TShirt>();

        //List used to store Golfers.
        public List<Golfer> Golfers = new List<Golfer>();

        //List used to store Jeans.
        public List<Jeans> Pants = new List<Jeans>();

        //List used to store Formal Pants.
        public List<FormalPants> Formal = new List<FormalPants>();

        double Price = 0;

        //Assigns name and size and then calculates cost of TShirt.
        public double calcTShirt()
        {
            foreach (TShirt prod in TShirts)
            {
                var tee = new TShirt();
                tee.Name = prod.Name;
                tee.Size = prod.Size;
                Price = tee.SpecialPrice();

            }
            return Price;
        }

        //Assigns name and size and then calculates cost of Golfer.
        public double calcGolfer()
        {
            foreach (Golfer prod in Golfers)
            {
                Golfer golf = new Golfer();
                golf.Name = prod.Name;
                golf.Size = prod.Size;
                Price = golf.SpecialPrice();
            }
            return Price;
        }

        //Assigns name and size and then calculates cost of Jeans.
        public double calcJeans()
        {
            foreach (Jeans prod in Pants)
            {
                var jean = new Jeans();
                jean.Name = prod.Name;
                jean.Size = prod.Size;
                Price = jean.SpecialPrice();
            }
            return Price;
        }

        //Assigns name and size and then calculates cost of Formal pants.
        public double calcFormal()
        {
            foreach (FormalPants prod in Formal)
            {
                var formal = new FormalPants();
                formal.Name = prod.Name;
                formal.Size = prod.Size;
                Price = formal.SpecialPrice();
            }
            return Price;
        }

        //Runs methods that calculate item prices and adds them together.
        public double TotalPrice()
        {
            double TP = 0;
            TP = calcTShirt() + calcGolfer() + calcJeans() + calcFormal();
            return TP;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "Marvel";
            tshirt.Size = "s";
            basket.TShirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Polo";
            golfer.Size = "l";
            basket.Golfers.Add(golfer);

            var jeans = new Jeans();
            jeans.Name = "Levis";
            jeans.Size = "s";
            basket.Pants.Add(jeans);

            var pants = new FormalPants();
            pants.Name = "Gucci";
            pants.Size = "l";
            basket.Formal.Add(pants);

            //Runs TotalPrice() and displays total price of items.
            Console.WriteLine("Your total price is R{0}", basket.TotalPrice());

            Console.Read();
        }
    }
}
