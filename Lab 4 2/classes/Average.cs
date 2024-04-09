class Average : Tariff
{
    public string TVServices {  get; set; }
    public Average(string name, int numberOfClients, int price, int speed, int traffic, string tvservices)
    : base(name, numberOfClients, price, speed, traffic)
    {
       this.TVServices = tvservices;
    }
    public override string ToString()
    {
        return $"Name: {Name}; NumberOfClients: {NumberOfClients}; Price: {Price}, Speed: {Speed}; Traffic: {Traffic}; TVServices: {TVServices};";
    }
}