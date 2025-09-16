namespace MyReal06_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new OnlineRestaurant();
            var shippingService = new ShippingService();
            var chickenOrder = new Order() { DishName = "Chicken with rice", DishPrice = 20.0, User = "User1", ShippingAddress = "Random street 123" };
            var sushiOrder = new Order() { DishName = "Sushi", DishPrice = 52.0, User = "User2", ShippingAddress = "More random street 321" };
            restaurant.AddOrderToCart(chickenOrder);
            restaurant.AddOrderToCart(sushiOrder);
            restaurant.CompleteOrders();
            shippingService.AcceptOrder(chickenOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();
            shippingService.AcceptOrder(sushiOrder);
            shippingService.CalculateShippingExpenses();
            shippingService.ShipOrder();
            Console.ReadLine();
        }
    }
}