using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Customer customer1 = new Customer("Kris Dunn", "261 W 200 S", "Springville", "Utah", "United States");
        Order order1 = new Order(customer1);
        Product product1 = new Product("Bread", 2);
        Product product2 = new Product("Cheese", 1);
        Product product3 = new Product("Soda", 4);
        order1.AddToOrder(product1);
        order1.AddToOrder(product2);
        order1.AddToOrder(product3);
        orders.Add(order1);

        Customer customer2 = new Customer("Von Alleman", "190 W 100 S", "Springville", "Utah", "United States");
        Order order2 = new Order(customer2);
        Product product4 = new Product("Sugar", 2);
        Product product5 = new Product("Detergent", 1);
        Product product6 = new Product("Apples", 5);
        order2.AddToOrder(product4);
        order2.AddToOrder(product5);
        order2.AddToOrder(product6);
        orders.Add(order2);

        Customer customer3 = new Customer("Carol Deschamps", "30 D'Epinay Ave", "Flat 2B", "Quatre Bornes", "Mauritius", "France");
        Order order3 = new Order(customer3);
        Product product7 = new Product("Milk", 1);
        Product product8 = new Product("Bananas", 3);
        Product product9 = new Product("Peanut Butter", 1);
        order3.AddToOrder(product7);
        order3.AddToOrder(product8);
        order3.AddToOrder(product9);
        orders.Add(order3);

        foreach (Order order in orders){
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Packing Label:");
            Console.WriteLine();
            order.DisplayPackingLabel();
            Console.WriteLine();
            Console.WriteLine("Shipping Label:");
            Console.WriteLine();
            order.DisplayShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"Order Total:  ${Math.Round(order.GetTotal(), 2)}");

        }
    }
}