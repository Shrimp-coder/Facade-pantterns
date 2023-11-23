using System;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();

            Console.Write("\n--------------------------\n");
            Console.WriteLine("Chuong trinh nay dang chay");
            Console.Read();
        }
    }
}
