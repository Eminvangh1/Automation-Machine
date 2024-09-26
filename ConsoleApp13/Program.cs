namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
         
            string[] products = { "Water", "Wafer", "CocoCola", "biscuit" };


            double[] prices = { 10, 15, 17.50, 12.50 };                     

              for (int i = 0; i < products.Length; i++)

            {

                Console.WriteLine(products[i]);
                Console.WriteLine(prices[i]);

            }
            Console.WriteLine("Select a Product");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            double productprice = prices[a];
            double totalbalance = 0;

            while (totalbalance < productprice)
            {
                Console.Write($"Products Prices: {productprice} \n Please Please Input Money");
                double moneyinflow= Convert.ToDouble(Console.ReadLine());
                totalbalance += moneyinflow;
                Console.Clear();
                if (totalbalance < productprice)
                {
                    Console.WriteLine($"Insufficient funds! Total: {totalbalance}  Required money: {productprice} TL");
                }
            }


            Console.WriteLine($"{prices[a]}product purchased Total Balance: {totalbalance} TL");

            if (totalbalance > productprice)
            {
                Console.Clear();
                Console.WriteLine($" Remaining Balance Is Refunded: {totalbalance - productprice} TL");

            }
        }
    }
}
