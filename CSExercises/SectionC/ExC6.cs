using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            //remind and and get input
            Console.WriteLine("How many TV do you want to buy?");
            int tvQty = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many DVD do you want to buy?");
            int dvdQty = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("How many MP3 do you want to buy?");
            int mp3Qty = Convert.ToInt16(Console.ReadLine());

            //call the function and display
            Console.WriteLine("The total price of your goods is S${0}", CalculateTotalPrice(tvQty,dvdQty,mp3Qty));
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            //YOUR CODE HERE
            //const statement 
            const double tvPrice = 900;
            const double dvdPrice = 500;
            const double mp3Price = 700;

            //caculate each price and enforce convert
            double totalTvPrice = (double) tvPrice * tvQty;
            double totalDvdPrice = (double)dvdPrice * dvdPrice;
            double totalMp3Price = (double)mp3Price * mp3Qty;

            double totalDiscountPrice = totalTvPrice + totalDvdPrice;

            //discount variable statement 
            double discount;

            //conditional discount
            if (totalDiscountPrice >= 5000 && totalDiscountPrice < 10000)
                discount = 0.10;
            else if (totalDiscountPrice >= 10000)
                discount = 0.15;
            else
                discount = 0;

            //calculate totalPrice
            double totalPrice = totalMp3Price + (1 - discount) * totalDiscountPrice;

            //return
            return totalPrice;
        }
    }
}