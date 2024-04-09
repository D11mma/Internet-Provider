public class Tariff
{
    public string Name { get; set; }
    public int NumberOfClients { get; set; }
    public int Traffic { get; set; }
    public int Price { get; set; }
    public int Speed { get; set; }

    public Tariff(string Name, int NumberOfClients, int Price, int Speed, int Traffic)
    {
        this.Name = Name;
        this.NumberOfClients = NumberOfClients;
        this.Price = Price;
        this.Speed = Speed;
        this.Traffic = Traffic;
    }
    public override string ToString()
    {
        return $"Name: {Name}; NumberOfClients: {NumberOfClients}; Price: {Price}; Speed: {Speed}; Traffic: {Traffic};";
    }
}
