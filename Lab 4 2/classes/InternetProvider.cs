public class InternetProvider
{
    private List<Tariff> Tariffs = new List<Tariff>();

    public void AddTariff(Tariff Tariff)
    {
        Tariffs.Add(Tariff);
    }
    public void CountClientsByTariff()
    {
        foreach (var t in Tariffs)
        {
            Console.WriteLine($"Name of Tariff: {t.Name}; Number of Clients: {t.NumberOfClients};");
            //Console.WriteLine(t);
        }
    }
    // Відсортувати тарифи згідно з об'ємом трафіку, що надається.
    public void OrderByVolume()
    {
        foreach (var t in Tariffs.OrderBy(t => t.Traffic))
        {
            Console.WriteLine($"Name of Tariff: {t.Name}; Traffic: {t.Traffic};");
            //Console.WriteLine(t);
        }
    }
    // Знайти тариф, що відповідає вказаному діапазону трафіку та вартості абонплати.
    public void SearchByTrafficPrice(int MinTraff, int MaxTraff, int MinPrice, int MaxPrice)
    {
        foreach (var t in Tariffs)
        {
            if (t.Traffic > MinTraff && t.Traffic < MaxTraff && t.Price > MinPrice && t.Price < MaxPrice)
            {
                Console.WriteLine($"{t.Name}");
            }
        }
    }
}
