class Program
{
    static void Main()
    {
        InternetProvider provider = new InternetProvider();
        provider.AddTariff(new Econom("Corbina", 101, 150, 50, 120));
        provider.AddTariff(new Econom("EuroLux", 115, 120, 45, 120));
        provider.AddTariff(new Average("Kyivstar", 150, 280, 70, 200, "Netflix"));
        provider.AddTariff(new Expensive("Vodafone", 78, 400, 100, 1000, "YouTubePremium", "ESET", 10));
        Console.WriteLine("Кількість клієнтів по кожному тарифу:");
        provider.CountClientsByTariff();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("За об'ємом:");
        provider.OrderByVolume();
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Знаходження тарифу за параметрами: трафiк та вартість");
        provider.SearchByTrafficPrice(110, 140, 110, 155);
    }
}

