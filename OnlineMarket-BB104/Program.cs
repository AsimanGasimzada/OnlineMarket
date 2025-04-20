using OnlineMarket_BB104.Models;

namespace OnlineMarket_BB104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    OnlineMarket market = new("Aile market");


            //restart:
            //    Console.WriteLine("`[1] Markete mehsul elave et`\r\n\r\n`[2] Marketden mehsul sil`\r\n\r\n`[3] Sebete mehsul at`\r\n\r\n`[4] Marketdeki mehsulları göster`\r\n\r\n`[5] Sebetdeki mehsulları göster`");

            //    Console.Write("Seciminiz:");
            //    string choice = Console.ReadLine();


            //    Console.Clear();

            //    try
            //    {

            //        switch (choice)
            //        {
            //            case "1":
            //                Console.Write("Mehsul adı:");
            //                string name = Console.ReadLine();

            //                Console.Write("Mehsul qiymeti:");
            //                decimal price = Convert.ToDecimal(Console.ReadLine());

            //                Product product = new(name, price);

            //                market.AddProduct(product);
            //                break;

            //            case "2":

            //                market.ShowProducts();
            //                Console.WriteLine("\n  Hansi id-li producti silmek isteyirsiniz?");
            //                int removedProductId = Convert.ToInt32(Console.ReadLine());

            //                market.RemoveProduct(removedProductId);
            //                Console.WriteLine("Ugurla silindi");
            //                break;

            //            case "3":
            //                market.ShowProducts();

            //                Console.WriteLine("\n  Hansi id-li productu sebetinize atmaq isteyirsiniz?");
            //                int productId = Convert.ToInt32(Console.ReadLine());

            //                Console.WriteLine("bu mehsuldan nece eded isteyirsiniz?");
            //                int count = Convert.ToInt32(Console.ReadLine());

            //                market.AddToCart(productId, count);
            //                Console.WriteLine("Mehsul sebete ugurla elave olundu");
            //                break;

            //            case "4":
            //                Console.WriteLine("Marketdeki mehsullar:");
            //                market.ShowProducts();
            //                break;

            //            case "5":
            //                Console.WriteLine("Sebetdeki mehsullar:");
            //                market.ShowCart();
            //                break;

            //            default:
            //                Console.WriteLine("Duzgun secim edin");
            //                break;
            //        }



            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }


            //    Console.WriteLine();
            //    Console.WriteLine();

            //    goto restart;


            List<int> numbers = [];

            Console.WriteLine("Capacity:"+numbers.Capacity);
            Console.WriteLine("Count:"+numbers.Count);

            Console.WriteLine();

            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);
            numbers.Add(1);

            Console.WriteLine("Capacity:" + numbers.Capacity);
            Console.WriteLine("Count:" + numbers.Count);

        }
    }
}
